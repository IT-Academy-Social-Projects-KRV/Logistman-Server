using AutoMapper;
using Core.DTO;
using Core.DTO.TripDTO;
using Core.Entities.TripEntity;
using Core.Exceptions;
using Core.Helpers;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Core.Resources;
using Core.Specifications;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Core.Services
{
    public class TripService : ITripService
    {
        private readonly IRepository<Trip> _tripRepository;
        private readonly ICarService _carService;
        private readonly IPointService _pointService;
        private readonly IMapper _mapper;

        public TripService(
            IRepository<Trip> tripRepository,
            ICarService carService,
            IPointService pointService,
            IMapper mapper)
        {
            _tripRepository = tripRepository;
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

        public async Task<PaginatedList<RouteDTO>> GetAllRoutesAsync(PaginationFilterDTO paginationFilter)
        {
            var routes = await _tripRepository
                .ListAsync(new TripSpecification.GetRoutes(paginationFilter));

            var routesCount = await _tripRepository
                .CountAsync(new TripSpecification.GetRoutes(paginationFilter));

            return PaginatedList<RouteDTO>.Evaluate(
                _mapper.Map<List<RouteDTO>>(routes), paginationFilter, routesCount);
        }
    }
}
