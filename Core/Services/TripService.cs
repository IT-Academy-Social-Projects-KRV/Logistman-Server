using AutoMapper;
using Core.DTO.TripDTO;
using Core.Entities.TripEntity;
using Core.Exceptions;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Core.Resources;
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

        public bool CheckIsTripExistsById(int tripId)
        {
            return _tripRepository.Query()
                                  .Any(p => p.Id == tripId);
        }

        public async Task CreateTripAsync(CreateTripDTO createTripDTO, string creatorId)
        {
            ValidateTripDate(createTripDTO.StartDate, createTripDTO.ExpirationDate);

            var isCarValid = _carService
                                .CheckIsCarBelongsToUserByIds(createTripDTO.TransportationCarId, creatorId);

            if (!isCarValid)
            {
                throw new HttpException(ErrorMessages.CarNotFound, HttpStatusCode.NotFound);
            }

            var trip = _mapper.Map<Trip>(createTripDTO);

            trip.IsActive = false;
            trip.IsEnded = false;
            trip.TripCreatorId = creatorId;

            await _tripRepository.InsertAsync(trip);
            await _tripRepository.SaveChangesAsync();
        }

        private void ValidateTripDate(DateTimeOffset startDate, DateTimeOffset expirationDate)
        {
            var isTimeSpaceBusy = _tripRepository.Query()
                                                  .Any(t => !t.IsEnded &&
                                                       (t.StartDate >= startDate && t.StartDate < expirationDate) ||
                                                       (t.ExpirationDate > startDate && t.ExpirationDate < expirationDate));

            if (isTimeSpaceBusy)
            {
                throw new HttpException(
                            ErrorMessages.TripIsAlreadyExistsInTheTimeSpace,
                            HttpStatusCode.BadRequest);
            }
        }
    }
}
