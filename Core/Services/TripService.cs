using AutoMapper;
using Core.Constants;
using Core.DTO.TripDTO;
using Core.Entities.PointEntity;
using Core.Entities.TripEntity;
using Core.Exceptions;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Core.Resources;
using Core.Specifications;
using NetTopologySuite;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
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

        public TripService(
            IRepository<Trip> tripRepository,
            IRepository<PointData> pointDataRepository,
            ICarService carService,
            IPointService pointService,
            IMapper mapper)
        {
            _tripRepository = tripRepository;
            _pointDataRepository = pointDataRepository;
            _carService = carService;
            _pointService = pointService;
            _mapper = mapper;
        }

        public async Task<bool> CheckIsTripExistsById(int tripId)
        {
            return await _tripRepository.AnyAsync(new TripSpecification.GetById(tripId));
        }

        public async Task CreateTripAsync(CreateTripDTO createTripDTO, string creatorId)
        {
            await ValidateTripDateAsync(createTripDTO.StartDate, createTripDTO.ExpirationDate, creatorId);

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

        private async Task ValidateTripDateAsync(DateTimeOffset startDate, DateTimeOffset expirationDate, string creatorId)
        {
            var isTimeSpaceBusy = await _tripRepository.AnyAsync(
                new TripSpecification.GetByTimeSpace(startDate, expirationDate, creatorId));

            if (isTimeSpaceBusy)
            {
                throw new HttpException(
                            ErrorMessages.TripIsAlreadyExistsInTheTimeSpace,
                            HttpStatusCode.BadRequest);
            }
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
    }
}
