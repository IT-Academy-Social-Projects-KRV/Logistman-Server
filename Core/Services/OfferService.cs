using AutoMapper;
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
using Core.Specifications;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
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
        private readonly ITripService _tripService;

        public OfferService(
            IMapper mapper,
            IRepository<Offer> offerRepository,
            IRepository<Trip> tripRepository,
            IRepository<PointData> pointRepository,
            UserManager<User> userManager,
            IGoodCategoryService goodCategoryService,
            IOfferRoleService offerRoleService,
            IPointService pointService,
            ITripService tripService)
        {
            _pointService = pointService;
            _offerRoleService = offerRoleService;
            _pointRepository = pointRepository;
            _mapper = mapper;
            _offerRepository = offerRepository;
            _tripRepository = tripRepository;
            _userManager = userManager;
            _goodCategoryService = goodCategoryService;
            _tripService = tripService;
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
    }
}
