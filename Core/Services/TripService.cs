using AutoMapper;
using Core.Constants;
using Core.DTO;
using Core.DTO.TripDTO;
using Core.Entities.OfferEntity;
using Core.Entities.PointEntity;
using Core.Entities.TripEntity;
using Core.Exceptions;
using Core.Helpers;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Core.Resources;
using Core.Specifications;
using NetTopologySuite;
using NetTopologySuite.Geometries;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Core.Services
{
    public class TripService : ITripService
    {
        private readonly IRepository<Trip> _tripRepository;
        private readonly IRepository<PointData> _pointDataRepository;
        private readonly ICarService _carService;
        private readonly IPointService _pointService;
        private readonly IMapper _mapper;
        private readonly IRepository<Offer> _offerRepository;
        private readonly IInviteService _inviteService;
        private readonly ITripValidationService _tripValidationService;

        public TripService(
            IRepository<Trip> tripRepository,
            IRepository<PointData> pointDataRepository,
            ICarService carService,
            IPointService pointService,
            IMapper mapper,
            IRepository<Offer> offerRepository,
            IInviteService inviteService,
            ITripValidationService tripValidationService)
        {
            _tripRepository = tripRepository;
            _pointDataRepository = pointDataRepository;
            _carService = carService;
            _pointService = pointService;
            _mapper = mapper;
            _offerRepository = offerRepository;
            _inviteService = inviteService;
            _tripValidationService = tripValidationService;
        }

        public async Task<bool> CheckIsTripExistsById(int tripId)
        {
            return await _tripRepository.AnyAsync(new TripSpecification.GetById(tripId));
        }

        public async Task CreateTripAsync(CreateTripDTO createTripDTO, string creatorId)
        {
            await _tripValidationService.ValidateTripDateAsync(
                createTripDTO.StartDate,
                createTripDTO.ExpirationDate,
                creatorId);

            var sortedPoints = _pointService.SortByOrder(createTripDTO.Points);

            var isCarVerified = await _carService
                .CheckIsUserVerifiedByIdsAsync(createTripDTO.TransportationCarId, creatorId);

            if (!isCarVerified)
            {
                throw new HttpException(ErrorMessages.CarIsNotVerified, HttpStatusCode.BadRequest);
            }

            var trip = _mapper.Map<Trip>(createTripDTO);

            trip.IsActive = false;
            trip.IsEnded = false;
            trip.TripCreatorId = creatorId;

            var tripFromDb = await _tripRepository.AddAsync(trip);

            ExceptionMethods.TripNullCheck(tripFromDb);

            await _pointService.SetTripIdToListAsync(sortedPoints, tripFromDb.Id);
        }

        public async Task<LineString> GetRouteGeographyDataAsync(int routeId)
        {
            var routePoints = await _pointDataRepository
                .ListAsync(new PointDataSpecification.GetByRouteId(routeId));

            var listOfRouteCoordinates = new List<Coordinate>();

            routePoints
                .ForEach(x => listOfRouteCoordinates
                .Add(new Coordinate(x.Location.X, x.Location.Y)));

            var geometryFactory = NtsGeometryServices.Instance
                .CreateGeometryFactory(GeodeticSystem.WGS84);

            return geometryFactory.CreateLineString(listOfRouteCoordinates.ToArray());
        }

        public async Task<PaginatedList<RouteDTO>> GetAllRoutesAsync(PaginationFilterDTO paginationFilter)
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

        public async Task ManageOffersTripAsync(ManageTripDTO manageTrip)
        {
            var sortedPoints = _pointService.SortByOrder(manageTrip.PointsTrip);

            var trip = await _tripRepository
                .GetBySpecAsync(new TripSpecification
                    .GetById(manageTrip.TripId));

            ExceptionMethods.TripNullCheck(trip);

            manageTrip.OffersId = manageTrip.OffersId.Distinct().ToList();

            await _tripValidationService.ValidOffersCheckAsync(
                manageTrip.OffersId,
                manageTrip.TripId,
                trip.StartDate,
                trip.ExpirationDate);

            await _tripValidationService.ValidateTripAsync(manageTrip.TripId, manageTrip.TotalWeight);

            var points = new Collection<PointData>();

            foreach (var pointTrip in sortedPoints)
            {
                var pointData = await _pointDataRepository.GetByIdAsync(pointTrip.PointId);

                ExceptionMethods.PointNullCheck(pointData);

                points.Add(pointData);

                pointData.Order = pointTrip.Order;
            }

            var offers = await _offerRepository
                .ListAsync(new OfferSpecification
                    .GetOfferByIds(manageTrip.OffersId));

            trip.Offers = offers;

            trip.Points = points;

            trip.Distance = manageTrip.Distance;
            await _tripRepository.UpdateAsync(trip);

            await _inviteService.ManageTripInvitesAsync(trip, offers);
        }
    }
}
