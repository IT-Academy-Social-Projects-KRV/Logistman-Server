using AutoMapper;
using Core.DTO;
using Core.DTO.NotificationDTO;
using Core.Entities.NotificationEntity;
using Core.Entities.OfferEntity;
using Core.Entities.TripEntity;
using Core.Helpers;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Core.Specifications;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Services
{
    public class NotificationService : INotificationService
    {
        private readonly IRepository<Notification> _notificationRepository;
        private readonly IRepository<Offer> _offerRepository;
        private readonly IMapper _mapper;

        public NotificationService(
            IRepository<Notification> notificationRepository,
            IRepository<Offer> offerRepository,
            IMapper mapper)
        {
            _notificationRepository = notificationRepository;
            _offerRepository = offerRepository;
            _mapper = mapper;
        }

        public async Task<PaginatedList<NotificationPreviewDTO>> GetByUserIdAsync(
            string userId, PaginationFilterDTO paginationFilter)
        {
            var notificationsCount = await _notificationRepository.CountAsync(
                new NotificationSpecification.GetByUserId(userId, paginationFilter));

            int totalPages = PaginatedList<NotificationPreviewDTO>
                .GetTotalPages(paginationFilter, notificationsCount);

            if (totalPages == 0)
            {
                return null;
            }

            var notifications = await _notificationRepository.ListAsync(
                new NotificationSpecification.GetByUserId(userId, paginationFilter));

            return PaginatedList<NotificationPreviewDTO>.Evaluate(
                _mapper.Map<List<NotificationPreviewDTO>>(notifications),
                paginationFilter.PageNumber,
                notificationsCount,
                totalPages);
        }

        public async Task ManageTripNotificationsAsync(
            Trip trip, List<BriefNotificationDTO> notificationsDTOs)
        {
            var previousTripNotifications = await _notificationRepository.ListAsync(
                new NotificationSpecification.GetSingleByTripId(trip.Id));

            var newNotifications = new List<Notification>();
            var notificationsIdsForDelete = new List<int>();

            foreach (var previousNotification in previousTripNotifications)
            {
                var offerId = previousNotification.OfferId;

                if (notificationsDTOs.Any(n => n.OfferId == offerId))
                {
                    notificationsDTOs.Remove(notificationsDTOs.First(n => n.OfferId == offerId));
                }
                else
                {
                    notificationsIdsForDelete.Add(previousNotification.Id);
                }
            }

            foreach (var notification in notificationsDTOs)
            {
                newNotifications.Add(new Notification
                {
                    OfferId = notification.OfferId,
                    UserId = notification.UserId,
                    TripId = trip.Id
                });
            }

            if (notificationsIdsForDelete.Count > 0)
            {
                var notificationsForDelete = await _notificationRepository.ListAsync(
                    new NotificationSpecification.GetByIds(notificationsIdsForDelete));

                await _notificationRepository.DeleteRangeAsync(notificationsForDelete);
            }

            if (newNotifications.Count > 0)
            {
                var notifications = await _notificationRepository.AddRangeAsync(newNotifications);

                foreach (var notification in notifications)
                {
                    var offer = await _offerRepository.GetByIdAsync(notification.OfferId);

                    offer.NotificationId = notification.Id;
                }

                await _offerRepository.SaveChangesAsync();
            }
        }

        public async Task DeleteNotificationsAsync(int tripId)
        {
            var notifications = await _notificationRepository.ListAsync(
                new NotificationSpecification.GetByTripId(tripId));

            if (notifications.Count == 0)
            {
                return;
            }

            await _notificationRepository.DeleteRangeAsync(notifications);
        }
    }
}
