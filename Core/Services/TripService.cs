using AutoMapper;
using Core.DTO.TripDTO;
using Core.Entities.TripEntity;
using Core.Exceptions;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Core.Resources;
using Core.Specifications;
using System;
using System.Net;
using System.Threading.Tasks;
using Core.DTO.OfferDTO;
using Core.Entities.OfferEntity;

namespace Core.Services
{
    public class TripService : ITripService
    {
        private readonly IRepository<Trip> _tripRepository;
        private readonly ICarService _carService;
        private readonly IPointService _pointService;
        private readonly IMapper _mapper;
        private readonly IRepository<Offer> _offerRepository;

        public TripService(
            IRepository<Trip> tripRepository,
            ICarService carService,
            IPointService pointService,
            IMapper mapper,
            IRepository<Offer> offerRepository)
        {
            _tripRepository = tripRepository;
            _carService = carService;
            _pointService = pointService;
            _mapper = mapper;
            _offerRepository = offerRepository;
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

        public async Task AddOffersToTripAsync(OffersForTripDTO offersForTrip)
        {
            var trip = await _tripRepository.GetByIdAsync(offersForTrip.TripId);

            ExceptionMethods.TripNullCheck(trip);

            foreach (var offerId in offersForTrip.OffersIdList)
            {
               var offer = await _offerRepository.GetByIdAsync(offerId);

               ExceptionMethods.OfferNullCheck(offer);

               trip.IsActive = true;
               offer.RelatedTripId = offersForTrip.TripId;

               await _offerRepository.UpdateAsync(offer);
               await _tripRepository.UpdateAsync(trip);
            }
        }

        public async Task ManageOffersTripAsync(OffersForTripDTO offersForTrip)
        {
            var trip = await _tripRepository.GetByIdAsync(offersForTrip.TripId);

            ExceptionMethods.TripNullCheck(trip);

            var offers = await _offerRepository
                .ListAsync(new OfferSpecification
                    .GetByTripId(offersForTrip.TripId));

            if (offers.Count == 0)
            {
                trip.IsActive = false;
                await _tripRepository.UpdateAsync(trip);
                return;
            }

            offersForTrip
                .OffersIdList
                .ForEach(offerId => offers
                    .RemoveAll(x => x.Id == offerId));

            foreach (var offer in offers)
            {
                ExceptionMethods.OfferNullCheck(offer);

                offer.Trip = null;
                await _offerRepository.UpdateAsync(offer);
            }
        }
    }
}
