using AutoMapper;
using Core.DTO;
using Core.DTO.InviteDTO;
using Core.Entities.InviteEntity;
using Core.Exceptions;
using Core.Helpers;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Core.Specifications;
using System.Collections.Generic;
using System.Linq;
using Core.DTO.OfferDTO;
using Core.Entities.PointEntity;
using System.Threading.Tasks;
using Core.Entities.OfferEntity;

namespace Core.Services
{
    public class InviteService : IInviteService
    {
        private readonly IRepository<Invite> _inviteRepository;
        private readonly IRepository<Offer> _offerRepository;
        private readonly IRepository<PointData> _pointRepository;
        private readonly IMapper _mapper;
        private readonly INotificationService _notificationService;

        public InviteService(
            IRepository<Invite> inviteRepository,
            IRepository<Offer> offerRepository,
            IRepository<PointData> pointRepository,
            IMapper mapper,
            INotificationService notificationService)
        {
            _inviteRepository = inviteRepository;
            _offerRepository = offerRepository;
            _pointRepository = pointRepository;
            _mapper = mapper;
            _notificationService = notificationService;
        }

        public async Task ManageAsync(ManageInviteDTO manageInviteDTO, string userId)
        {
            var invite = await _inviteRepository.GetBySpecAsync(
                new InviteSpecification.GetUnansweredByInviteAndUserIds(manageInviteDTO.InviteId, userId));

            ExceptionMethods.InviteNullCheck(invite);

            invite.IsAccepted = manageInviteDTO.IsAccepted;
            invite.IsAnswered = true;

            await _inviteRepository.SaveChangesAsync();
            await _notificationService.SendNotificationsForTripParticipantsAsync(invite.Trip, invite.IsAccepted);
        }

        public async Task<PaginatedList<InvitePreviewDTO>> GetByUserIdAsync(
            string userId, PaginationFilterDTO paginationFilter)
        {
            var invitesCount = await _inviteRepository.CountAsync(
                new InviteSpecification.GetByUserId(userId, paginationFilter));

            int totalPages = PaginatedList<InvitePreviewDTO>
                .GetTotalPages(paginationFilter, invitesCount);

            if (totalPages == 0)
            {
                return null;
            }

            var invites = await _inviteRepository.ListAsync(
                new InviteSpecification.GetByUserId(userId, paginationFilter));

            var driverInvites = new List<InvitePreviewDTO>();

            foreach (var invite in invites)
            {
                var offers = await _offerRepository.ListAsync(
                    new OfferSpecification.GetByTripId(invite.TripId));

                offers = offers.OrderBy(o => o.Point.Order).ToList();

                float totalGoodsWeight = 0;

                foreach (var offer in offers)
                {
                    totalGoodsWeight += offer.GoodsWeight;
                }

                var tripPoints = await _pointRepository.ListAsync(
                    new PointDataSpecification.GetByTripId(invite.TripId));

                driverInvites.Add(new InvitePreviewDTO
                {
                    Id = invite.Id,
                    PointFromInfo = _mapper.Map<PointPreviewDTO>(tripPoints.First()),
                    PointToInfo = _mapper.Map<PointPreviewDTO>(tripPoints.Last()),
                    IsAnswered = invite.IsAnswered,
                    IsAccepted = invite.IsAccepted,
                    TotalGoodsWeight = totalGoodsWeight,
                    TotalDistance = invite.Trip.Distance,
                    TotalOffersCount = offers.Count,
                    OffersInfo = _mapper.Map<List<OfferPreviewInTripInviteDTO>>(offers.Take(4))
                });
            }

            return PaginatedList<InvitePreviewDTO>.Evaluate(
                    driverInvites,
                    paginationFilter.PageNumber,
                    invitesCount,
                    totalPages
                );
        }

        public async Task AddDriverInvite(int tripId, string userId)
        {
            var isInvite = await _inviteRepository.AnyAsync(
                new InviteSpecification.GetByTripId(tripId));

            if (isInvite)
            {
                return;
            }

            await _inviteRepository.AddAsync(
                new Invite
                {
                    IsAccepted = false,
                    IsAnswered = false,
                    UserId = userId,
                    TripId = tripId
                });
        }
    }
}
