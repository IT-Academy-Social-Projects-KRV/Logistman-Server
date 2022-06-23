using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Core.Entities.OfferEntity;
using Core.Entities.TripEntity;
using Core.Exceptions;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Core.Resources;
using Core.Specifications;

namespace Core.Validation.ValidationService
{
    public class TripValidationService : ITripValidationService
    {
        private readonly IRepository<Offer> _offerRepository;
        private readonly IRepository<Trip> _tripRepository;

        public TripValidationService(
            IRepository<Offer> offerRepository, 
            IRepository<Trip> tripRepository)
        {
            _offerRepository = offerRepository;
            _tripRepository = tripRepository;
        }

        public async Task ValidOffersCheckAsync(
            List<int> offerIds,
            int tripId,
            DateTimeOffset startTrip,
            DateTimeOffset expirationTrip)
        {
            foreach (var id in offerIds)
            {
                if (!await _offerRepository
                        .AnyAsync(new OfferSpecification
                            .GetById(id, tripId, startTrip, expirationTrip)))
                {
                    throw new HttpException(
                        ErrorMessages.OfferNotValid + $" Id: {id}",
                        HttpStatusCode.BadRequest);
                }
            }
        }

        public async Task ValidateTripAsync(int tripId, float totalWeight)
        {
            var isValid = await _tripRepository.AnyAsync(
                new TripSpecification.GetById(tripId, totalWeight));

            if (!isValid)
            {
                throw new HttpException(
                    ErrorMessages.TripNotValid,
                    HttpStatusCode.BadRequest);
            }
        }

        public async Task ValidateTripDateAsync(
            DateTimeOffset startDate, 
            DateTimeOffset expirationDate, 
            string creatorId)
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
    }
}
