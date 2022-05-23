using AutoMapper;
using Core.DTO.TripDTO;
using Core.Entities.TripEntity;
using Core.Exceptions;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Core.Resources;
using Core.Specifications;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Core.Services
{
    public class TripService : ITripService
    {
        private readonly IRepository<Trip> _tripRepository;
        private readonly ICarService _carService;
        private readonly IMapper _mapper;

        public TripService(
            IRepository<Trip> tripRepository,
            ICarService carService,
            IMapper mapper)
        {
            _tripRepository = tripRepository;
            _carService = carService;
            _mapper = mapper;
        }

        public async Task<bool> CheckIsTripExistsById(int tripId)
        {
            return await _tripRepository.AnyAsync(new TripSpecification.GetById(tripId));
        }

        public async Task CreateTripAsync(CreateTripDTO createTripDTO, string creatorId)
        {
            await ValidateTripDate(createTripDTO.StartDate, createTripDTO.ExpirationDate, creatorId);

            var isCarValid = await _carService
                                .CheckIsCarBelongsToUserByIds(createTripDTO.TransportationCarId, creatorId);

            if (!isCarValid)
            {
                throw new HttpException(ErrorMessages.CarNotFound, HttpStatusCode.NotFound);
            }

            var isCarVerified = await _carService.CheckIsCarVerifiedById(createTripDTO.TransportationCarId);

            if (!isCarVerified)
            {
                throw new HttpException(ErrorMessages.CarIsNotVerified, HttpStatusCode.BadRequest);
            }

            var trip = _mapper.Map<Trip>(createTripDTO);

            trip.IsActive = false;
            trip.IsEnded = false;
            trip.TripCreatorId = creatorId;

            await _tripRepository.AddAsync(trip);
        }

        private async Task ValidateTripDate(DateTimeOffset startDate, DateTimeOffset expirationDate, string creatorId)
        {
            var isTimeSpaceBusy = await _tripRepository.AnyAsync(new TripSpecification.GetByTimeSpace(startDate, expirationDate, creatorId));

            if (isTimeSpaceBusy)
            {
                throw new HttpException(
                            ErrorMessages.TripIsAlreadyExistsInTheTimeSpace,
                            HttpStatusCode.BadRequest);
            }
        }
    }
}
