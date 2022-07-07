using AutoMapper;
using Core.DTO;
using Core.DTO.OfferDTO;
using Core.Entities.OfferEntity;
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
using System.Net;
using System.Threading.Tasks;

namespace Core.Services
{
    public class OfferService : IOfferService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Offer> _offerRepository;
        private readonly IRepository<Trip> _tripRepository;
        private readonly UserManager<User> _userManager;
        private readonly IGoodCategoryService _goodCategoryService;
        private readonly IOfferRoleService _offerRoleService;
        private readonly IPointService _pointService;
        private readonly ITripService _tripService;

        public OfferService(
            IMapper mapper,
            IRepository<Offer> offerRepository,
            IRepository<Trip> tripRepository,
            UserManager<User> userManager,
            IGoodCategoryService goodCategoryService,
            IOfferRoleService offerRoleService,
            IPointService pointService,
            ITripService tripService)
        {
            _pointService = pointService;
            _offerRoleService = offerRoleService;
            _mapper = mapper;
            _offerRepository = offerRepository;
            _tripRepository = tripRepository;
            _userManager = userManager;
            _goodCategoryService = goodCategoryService;
            _tripService = tripService;
        }

        public async Task CreateOfferAsync(OfferCreateDTO offerCreate, string userId)
        {
            if (offerCreate.Point.TripId != null)
            {
                var isTripExists = await _tripService.CheckIsTripExistsById((int)offerCreate.Point.TripId);

                if (!isTripExists)
                {
                    throw new HttpException(ErrorMessages.TripNotFound, HttpStatusCode.NotFound);
                }
            }

            ExceptionMethods.UserNullCheck(await _userManager.FindByIdAsync(userId));

            var offer = _mapper.Map<Offer>(offerCreate);
            offer.OfferCreatorId = userId;
            offer.CreationDate = DateTimeOffset.UtcNow;
            offer.IsClosed = false;
            offer.CreatorRoleId = await _offerRoleService.GetRoleByNameAsync(offerCreate.Role);
            offer.GoodCategoryId = await _goodCategoryService
                .GetGoodCategoryByNameAsync(offerCreate.GoodCategory);
            offer.OfferPointId = await _pointService.CreateAsync(offerCreate.Point);

            await _offerRepository.AddAsync(offer);
        }

        public async Task<OfferInfoDTO> GetOfferByIdAsync(int offerId, string userId)
        {
            var offer = await _offerRepository.GetBySpecAsync(new OfferSpecification.GetById(offerId, userId));

            ExceptionMethods.OfferNullCheck(offer);

            var offerInfo = _mapper.Map<OfferInfoDTO>(offer);

            return offerInfo;
        }

        public async Task<PaginatedList<OfferPreviewDTO>> GetUsersOffersAsync(string userId, PaginationFilterDTO paginationFilter)
        {
            var offerListCount = await _offerRepository
                .CountAsync(new OfferSpecification.GetByUserId(userId, paginationFilter));

            int totalPages = PaginatedList<OfferPreviewDTO>.GetTotalPages(paginationFilter, offerListCount);

            if (totalPages == 0)
            {
                return null;
            }

            var offerList = await _offerRepository
                .ListAsync(
                new OfferSpecification.GetByUserId(userId, paginationFilter));

            return PaginatedList<OfferPreviewDTO>.Evaluate(
                _mapper.Map<List<OfferPreviewDTO>>(offerList), paginationFilter.PageNumber, offerListCount, totalPages);
        }

        public async Task<PaginatedList<PointOfferCreateTripDTO>> GetNearRouteAsync(
            PaginationFilterDTO paginationFilter, int routeId)
        {
            var route = await _tripRepository.GetByIdAsync(routeId);

            ExceptionMethods.TripNullCheck(route);

            var maxRouteDeviationMeters = route.MaxRouteDeviationKm * 1000;
            var geoRoute = await _tripService.GetRouteGeographyDataAsync(routeId);

            var offerListCount = await _offerRepository
                .CountAsync(new OfferSpecification.GetOffersNearRoute(
                    geoRoute,
                    maxRouteDeviationMeters,
                    route.ExpirationDate,
                    paginationFilter
                ));

            int totalPages = PaginatedList<PointOfferCreateTripDTO>.GetTotalPages(paginationFilter, offerListCount);

            if (totalPages == 0)
            {
                return null;
            }

            var offerList = await _offerRepository
                .ListAsync(new OfferSpecification.GetOffersNearRoute(
                    geoRoute,
                    maxRouteDeviationMeters,
                    route.ExpirationDate,
                    paginationFilter
                ));

            return PaginatedList<PointOfferCreateTripDTO>.Evaluate(
                _mapper.Map<List<PointOfferCreateTripDTO>>(offerList), paginationFilter.PageNumber, offerListCount, totalPages);
        }
    }
}
