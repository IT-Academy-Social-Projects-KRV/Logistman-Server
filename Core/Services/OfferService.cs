using AutoMapper;
using Core.Constants;
using Core.DTO;
using Core.DTO.OfferDTO;
using Core.Entities.OfferEntity;
using Core.Entities.PointEntity;
using Core.Entities.TripEntity;
using Core.Entities.UserEntity;
using Core.Exceptions;
using Core.Helpers;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Core.Resources;
using Core.Specifications;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Core.Services
{
    public class OfferService : IOfferService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Offer> _offerRepository;
        private readonly IRepository<Trip> _tripRepository;
        private readonly IRepository<PointData> _pointRepository;
        private readonly UserManager<User> _userManager;
        private readonly IGoodCategoryService _goodCategoryService;
        private readonly IOfferRoleService _offerRoleService;
        private readonly IPointService _pointService;
        private IOfferService _offerServiceImplementation;

        public OfferService(
            IMapper mapper,
            IRepository<Offer> offerRepository,
            IRepository<Trip> tripRepository,
            IRepository<PointData> pointRepository,
            UserManager<User> userManager,
            IGoodCategoryService goodCategoryService,
            IOfferRoleService offerRoleService,
            IPointService pointService)
        {
            _pointService = pointService;
            _offerRoleService = offerRoleService;
            _pointRepository = pointRepository;
            _mapper = mapper;
            _offerRepository = offerRepository;
            _tripRepository = tripRepository;
            _userManager = userManager;
            _goodCategoryService = goodCategoryService;
        }

        public async Task CreateOfferAsync(OfferCreateDTO offerCreate, string userId)
        {
            ExceptionMethods.UserNullCheck(await _userManager.FindByIdAsync(userId));

            var offer = _mapper.Map<Offer>(offerCreate);

            offer.OfferCreatorId = userId;
            offer.CreationDate = DateTimeOffset.UtcNow;
            offer.IsClosed = false;
            offer.CreatorRoleId = await _offerRoleService.GetRoleByNameAsync(offerCreate.Role);
            offer.GoodCategoryId = await _goodCategoryService
                .GetGoodCategoryByNameAsync(offerCreate.GoodCategory);

            var point = await _pointService.CreateAsync(offerCreate.Point);

            ExceptionMethods.PointNullCheck(point);

            offer.OfferPointId = point.Id;

            await _offerRepository.AddAsync(offer);

            point.OfferId = offer.Id;

            await _pointRepository.SaveChangesAsync();
        }

        public async Task<OfferInfoDTO> GetOfferByIdAsync(int offerId, string userId)
        {
            var offer = await _offerRepository.GetBySpecAsync(
                new OfferSpecification.GetById(offerId, userId));

            ExceptionMethods.OfferNullCheck(offer);

            var offerInfo = _mapper.Map<OfferInfoDTO>(offer);

            return offerInfo;
        }

        public async Task<PaginatedList<OfferPreviewDTO>> GetUsersOffersAsync(
            string userId, PaginationFilterDTO paginationFilter)
        {
            var offerListCount = await _offerRepository
                .CountAsync(new OfferSpecification.GetByUserId(userId, paginationFilter));

            int totalPages = PaginatedList<OfferPreviewDTO>
                .GetTotalPages(paginationFilter, offerListCount);

            if (totalPages == 0)
            {
                return null;
            }

            var offerList = await _offerRepository
                .ListAsync(
                new OfferSpecification.GetByUserId(userId, paginationFilter));

            return PaginatedList<OfferPreviewDTO>.Evaluate(
                _mapper.Map<List<OfferPreviewDTO>>(offerList),
                paginationFilter.PageNumber,
                offerListCount,
                totalPages);
        }

        public async Task<List<PointOfferCreateTripDTO>> GetNearRouteAsync(int routeId)
        {
            var route = await _tripRepository.GetByIdAsync(routeId);

            ExceptionMethods.TripNullCheck(route);

            var maxRouteDeviationMeters = route.MaxRouteDeviationKm * 1000;

            var offers = await _offerRepository
                .ListAsync(new OfferSpecification.GetOffersNearRoute(
                    route.RouteGeographyData,
                    maxRouteDeviationMeters,
                    route.DepartureDate
                ));

            var points = new List<PointOfferCreateTripDTO>();

            offers.ForEach(item =>
                points.Add(_mapper.Map<PointOfferCreateTripDTO>(item.Point)));

            return points;
        }

        public async Task DeleteAsync(OfferIdDTO offerIdDTO, string userId)
        {
            var offer = await _offerRepository
                .GetBySpecAsync(new OfferSpecification
                    .GetOpenByIdAndUserIdWithoutTrip(offerIdDTO.OfferId, userId));

            ExceptionMethods.OfferNullCheck(offer);

            await _offerRepository.DeleteAsync(offer);
            await _pointRepository.DeleteAsync(offer.Point);
        }

        public async Task ConfirmGoodsTransferAsync(
            ConfirmGoodsTransferDTO сonfirmGoodsTransferDTO,
            string userId)
        {
            if (сonfirmGoodsTransferDTO.TripRole.ToUpper() == TripRoles.Driver)
            {
                var offer = await _offerRepository
                .GetBySpecAsync(new OfferSpecification
                        .GetByIdWithActiveTrip(сonfirmGoodsTransferDTO.OfferId, userId));

                ExceptionMethods.OfferNullCheck(offer);

                offer.GoodTransferConfirmedByDriver = сonfirmGoodsTransferDTO.IsConfirmed;
                offer.IsAnsweredByDriver = true;

                await _offerRepository.SaveChangesAsync();
                await EndTripAsync(userId);
            }
            else if (сonfirmGoodsTransferDTO.TripRole.ToUpper() == TripRoles.Sender
                     ||
                     сonfirmGoodsTransferDTO.TripRole.ToUpper() == TripRoles.Recipient)
            {
                var offer = await _offerRepository
                    .GetBySpecAsync(new OfferSpecification
                        .GetByIdWithTrip(сonfirmGoodsTransferDTO.OfferId, userId));

                ExceptionMethods.OfferNullCheck(offer);

                offer.GoodTransferConfirmedByCreator = сonfirmGoodsTransferDTO.IsConfirmed;
                offer.IsAnsweredByCreator = true;

                await _offerRepository.SaveChangesAsync();
            }
            else
            {
                throw new HttpException(
                        ErrorMessages.ConfirmGoodsDeliveryWrongRoleName
                        +
                        сonfirmGoodsTransferDTO.TripRole,
                        HttpStatusCode.Forbidden);
            }
        }

        private async Task EndTripAsync(string tripCreatorId)
        {
            var trip = await _tripRepository
                .GetBySpecAsync(new TripSpecification
                    .GetActiveByUserIdWithOffers(tripCreatorId));

            ExceptionMethods.TripNullCheck(trip);

            foreach (var offer in trip.Offers)
            {
                if (!offer.IsAnsweredByDriver)
                {
                    return;
                }
            }

            foreach (var offer in trip.Offers)
            {
                offer.IsClosed = true;
            }

            trip.IsActive = false;
            trip.IsEnded = true;
            trip.EndDate = DateTimeOffset.UtcNow;

            await _tripRepository.SaveChangesAsync();
        }

        public async Task<PaginatedList<OfferPreviewForConfirmDTO>> GetOffersToConfirmAsync(
            string userId, PaginationFilterDTO paginationFilter)
        {
            var offerListCount = await _offerRepository
                .CountAsync(new OfferSpecification.GetWithTripByUserId(userId, paginationFilter));

            var totalPages = PaginatedList<OfferPreviewDTO>
                .GetTotalPages(paginationFilter, offerListCount);

            if (totalPages == 0)
            {
                return null;
            }

            var offerList = await _offerRepository
                .ListAsync(
                    new OfferSpecification.GetWithTripByUserId(userId, paginationFilter));

            return PaginatedList<OfferPreviewForConfirmDTO>.Evaluate(
                _mapper.Map<List<OfferPreviewForConfirmDTO>>(offerList),
                paginationFilter.PageNumber,
                offerListCount,
                totalPages);
        }

        public async Task UnlinkFromTripAsync(int tripId)
        {
            var offers = await _offerRepository.ListAsync(
                new OfferSpecification.GetByTripId(tripId));

            if (offers.Count == 0)
            {
                return;
            }

            foreach (var offer in offers)
            {
                offer.RelatedTripId = null;
            }

            await _pointService.ResetTripPointOrdersAsync(tripId);
            await _offerRepository.UpdateRangeAsync(offers);
        }

        public async Task<List<OfferPreviewForInviteDTO>>
            GetDriverConfirmGoodsDeliveryAsync(int tripId, string userId)
        {
            var trip = await _tripRepository.GetBySpecAsync(
                new TripSpecification.GetActiveByUserIdAndId(tripId, userId));

            if (trip == null)
            {
                return null;
            }

            var offers = await _offerRepository.ListAsync(
                new OfferSpecification.GetToConfirmByTripAndUserIds(tripId, userId));

            var theLastAnswered = offers.LastOrDefault(o => o.IsAnsweredByDriver);

            var toAnswer = offers.Where(o => !o.IsAnsweredByDriver).Take(2);

            var result = new List<Offer>();

            if (theLastAnswered != null)
            {
                result.Add(theLastAnswered);
            }

            if (toAnswer.Count() != 0)
            {
                result.AddRange(toAnswer);
            }

            return _mapper.Map<List<OfferPreviewForInviteDTO>>(result);
        }
    }
}
