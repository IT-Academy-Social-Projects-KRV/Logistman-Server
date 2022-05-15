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

        public TripService(
            IRepository<Trip> tripRepository,
            ICarService carService)
        {
            _tripRepository = tripRepository;
            _carService = carService;
        }

        public bool CheckIsTripExistsById(int tripId)
        {
            return _tripRepository.Query()
                                  .SingleOrDefault(p => p.Id == tripId) != null;
        }

        public async Task CreateTripAsync(CreateTripDTO createTripDTO, string creatorId)
        {
            var isCarExists =_carService.CheckIsCarExistsById(createTripDTO.TransportationCarId);

            if (!isCarExists)
            {
                throw new HttpException(ErrorMessages.CarNotFound, HttpStatusCode.NotFound);
            }

            var trip = new Trip
            {
                IsActive = false,
                IsEnded = false,
                StartDate = createTripDTO.StartDate,
                ExpirationDate = createTripDTO.ExpirationDate,
                Description = createTripDTO.Description,
                LoadCapacity = createTripDTO.LoadCapacity,
                MaxRouteDeviationKm = createTripDTO.MaxRouteDeviationKm,
                TripCreatorId = creatorId,
                TransportationCarId = createTripDTO.TransportationCarId
            };

            await _tripRepository.InsertAsync(trip);
            await _tripRepository.SaveChangesAsync();
        }
    }
}
