using AutoMapper;
using Core.Constants;
using Core.DTO;
using Core.DTO.NotificationDTO;
using Core.DTO.TripDTO;
using Core.Entities.InviteEntity;
using Core.Entities.OfferEntity;
using Core.Entities.PointEntity;
using Core.Entities.TripEntity;
using Core.Exceptions;
using Core.Helpers;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Core.Resources;
using Core.Specifications;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Core.Services
{
    public class TripService : ITripService
    {
        private readonly IRepository<Trip> _tripRepository;
        private readonly IRepository<PointData> _pointDataRepository;
        private readonly IRepository<Invite> _inviteRepository;
        private readonly ICarService _carService;
        private readonly IPointService _pointService;
        private readonly IMapper _mapper;
        private readonly IRepository<Offer> _offerRepository;
        private readonly IInviteService _inviteService;
        private readonly ITripValidationService _tripValidationService;
        private readonly INotificationService _notificationService;

        public TripService(
            IRepository<Trip> tripRepository,
            IRepository<PointData> pointDataRepository,
            IRepository<Invite> inviteRepository,
            ICarService carService,
            IPointService pointService,
            IMapper mapper,
            IRepository<Offer> offerRepository,
            IInviteService inviteService,
            ITripValidationService tripValidationService,
            INotificationService notificationService)
        {
            _tripRepository = tripRepository;
            _pointDataRepository = pointDataRepository;
            _inviteRepository = inviteRepository;
            _carService = carService;
            _pointService = pointService;
            _mapper = mapper;
            _offerRepository = offerRepository;
            _inviteService = inviteService;
            _tripValidationService = tripValidationService;
            _notificationService = notificationService;
        }

        public async Task CreateTripAsync(CreateTripDTO createTripDTO, string creatorId)
        {
            await _tripValidationService.ValidateTripDateAsync(
                createTripDTO.DepartureDate,
                creatorId);

            var sortedPoints = _pointService.SortByOrder(createTripDTO.Points);

            createTripDTO.Points = DeleteNullPointsFromRoute(sortedPoints);

            var isCarVerified = await _carService
                .CheckIsUserVerifiedByIdsAsync(createTripDTO.TransportationCarId, creatorId);

            if (!isCarVerified)
            {
                throw new HttpException(ErrorMessages.CarIsNotVerified, HttpStatusCode.BadRequest);
            }

            var trip = _mapper.Map<Trip>(createTripDTO);

            trip.TripCreatorId = creatorId;
            trip.CreationDate = DateTimeOffset.UtcNow;
            trip.RouteGeographyData = SetRouteGeographyData(sortedPoints);

            await _tripRepository.AddAsync(trip);
        }

        private List<PointDTO> DeleteNullPointsFromRoute(List<PointDTO> fullSortedListOfPoints)
        {
            List<PointDTO> sortedListOfPointsWithoutNullPoints = new List<PointDTO>();

            foreach (var point in fullSortedListOfPoints)
            {
                if (point.IsStopover)
                {
                    sortedListOfPointsWithoutNullPoints.Add(point);
                }
            }

            for (int i = 0; i < sortedListOfPointsWithoutNullPoints.Count(); i++)
            {
                sortedListOfPointsWithoutNullPoints[i].Order = i + 1;
            }

            return sortedListOfPointsWithoutNullPoints;
        }

        private LineString SetRouteGeographyData(List<PointDTO> sortedRoutePoints)
        {
            var listOfRouteCoordinates = new List<Coordinate>();

            sortedRoutePoints
                .ForEach(x => listOfRouteCoordinates
                .Add(new Coordinate(x.Longitude, x.Latitude)));

            return NtsGeometryFactories.geometryFactoryWGS84.CreateLineString(listOfRouteCoordinates.ToArray());
        }

        public async Task<PaginatedList<RouteDTO>> GetAllRoutesAsync(
            PaginationFilterDTO paginationFilter)
        {
            var routesCount = await _tripRepository
                .CountAsync(new TripSpecification.GetRoutes(paginationFilter));

            int totalPages = PaginatedList<RouteDTO>.GetTotalPages(paginationFilter, routesCount);

            if (totalPages == 0)
            {
                return null;
            }

            var routes = await _tripRepository
                .ListAsync(new TripSpecification.GetRoutes(paginationFilter));

            foreach (var route in routes)
            {
                route.Points = route.Points.OrderBy(p => p.Order).ToList();
            }

            return PaginatedList<RouteDTO>.Evaluate(
                _mapper.Map<List<RouteDTO>>(routes), paginationFilter.PageNumber, routesCount, totalPages);
        }

        public async Task<PaginatedList<RoutePreviewDTO>> GetUserRoutesAsync(
            PaginationFilterDTO paginationFilter, string tripCreatorId)
        {
            var routesCount = await _tripRepository
                .CountAsync(new TripSpecification.GetRoutesByCreatorId(paginationFilter, tripCreatorId));

            int totalPages = PaginatedList<RoutePreviewDTO>
                .GetTotalPages(paginationFilter, routesCount);

            if (totalPages == 0)
            {
                return null;
            }

            var routes = await _tripRepository
                .ListAsync(new TripSpecification.GetRoutesByCreatorId(paginationFilter, tripCreatorId));

            foreach (var route in routes)
            {
                route.Points = route.Points.OrderBy(p => p.Order).ToList();
            }

            return PaginatedList<RoutePreviewDTO>.Evaluate(
                _mapper.Map<List<RoutePreviewDTO>>(routes), paginationFilter.PageNumber, routesCount, totalPages);
        }

        public async Task ManageOffersTripAsync(ManageTripDTO manageTrip)
        {
            var trip = await _tripRepository
                .GetBySpecAsync(new TripSpecification
                    .GetValidTripById(manageTrip.TripId, manageTrip.TotalWeight));

            ExceptionMethods.TripNullCheck(trip);

            foreach (var point in trip.Points)
            {
                if (point.OfferId != null)
                {
                    point.Order = 0;
                }
            }

            var sortedPoints = _pointService.SortByOrder(manageTrip.PointsTrip);

            _tripValidationService.ValidatePointsInTrip(trip, sortedPoints);

            await _tripValidationService.ValidateOffersCheckAsync(
                manageTrip.PointsTrip,
                manageTrip.TripId,
                trip.DepartureDate);

            var points = new List<PointData>();

            foreach (var point in sortedPoints)
            {
                var pointData = await _pointDataRepository.GetByIdAsync(point.Id);

                ExceptionMethods.PointNullCheck(pointData);

                pointData.Order = point.Order;
                points.Add(pointData);
            }

            var offersIds = new List<int>();

            foreach (var point in sortedPoints)
            {
                if (point.OfferId != null)
                {
                    offersIds.Add((int)point.OfferId);
                }
            }

            var offers = await _offerRepository
                .ListAsync(new OfferSpecification
                    .GetOfferByIds(offersIds));

            trip.Offers = offers;
            trip.Points = points;
            trip.Distance = manageTrip.Distance;

            await _pointDataRepository.SaveChangesAsync();
            await _tripRepository.UpdateAsync(trip);
            await _inviteService.CreateAsync(trip.Id, trip.TripCreatorId);
            await _notificationService.ManageTripNotificationsAsync(
                        trip,
                        _mapper.Map<List<BriefNotificationDTO>>(offers));
        }

        public async Task DeleteExpiredRoutesAsync()
        {
            var trips = await _tripRepository.ListAsync(new TripSpecification.GetExpiredRoutes());
            var points = new List<PointData>();

            foreach (var trip in trips)
            {
                points.AddRange(trip.Points);
            }

            await _pointDataRepository.DeleteRangeAsync(points);
            await _tripRepository.DeleteRangeAsync(trips);
        }

        public async Task DeleteRouteAsync(string userId, int tripId)
        {
            var route = await _tripRepository.GetBySpecAsync(
                new TripSpecification.GetRouteByUserIdAndId(userId, tripId));

            ExceptionMethods.TripNullCheck(route);

            if (await _inviteRepository.AnyAsync(
                new InviteSpecification.GetSingleByTripId(route.Id)))
            {
                throw new HttpException(
                        ErrorMessages.RouteHasInvites,
                        HttpStatusCode.BadRequest
                    );
            }

            var points = await _pointDataRepository.ListAsync(
                new PointDataSpecification.GetByTripId(tripId));

            await _pointDataRepository.DeleteRangeAsync(points);
            await _tripRepository.DeleteAsync(route);
        }

        public async Task<TripInfoDTO> GetTripByIdAsync(int tripId)
        {
            var trip = await _tripRepository
                .GetBySpecAsync(new TripSpecification.GetById(tripId));

            ExceptionMethods.TripNullCheck(trip);

            return _mapper.Map<TripInfoDTO>(trip);
        }

        public async Task<TripInfoForConfirmDTO> GetInfoForTripConfirmAsync(string userId)
        {
            var trip = await _tripRepository
                .GetBySpecAsync(new TripSpecification.GetTripForConfirmOffers(userId));

            ExceptionMethods.TripNullCheck(trip);

            var tripInfo = _mapper.Map<TripInfoForConfirmDTO>(trip);
            var sortPoints = tripInfo.Points.OrderBy(p => p.Order);

            tripInfo.Points = new List<PointTripInfoDTO>()
            {
                sortPoints.First(),
                sortPoints.Last()
            };

            return tripInfo;
        }
    }
}
