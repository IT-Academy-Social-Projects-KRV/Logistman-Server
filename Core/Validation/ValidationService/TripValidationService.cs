using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Core.DTO.OfferDTO;
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

        public async Task ValidateOffersCheckAsync(
            List<OfferIdDTO> offerIds,
            int tripId,
            DateTimeOffset expirationTrip)
        {
            foreach (var offerIdDTO in offerIds)
            {
                if (!await _offerRepository
                        .AnyAsync(new OfferSpecification
                            .GetById(offerIdDTO.OfferId, tripId, expirationTrip)))
                {
                    throw new HttpException(
                        ErrorMessages.OfferNotValid + $" Id: {offerIdDTO.OfferId}",
                        HttpStatusCode.BadRequest);
                }
            }
        }

        public async Task ValidateTripAsync(int tripId, float totalWeight)
        {
            var isValid = await _tripRepository.AnyAsync(
                new TripSpecification.GetValidTripById(tripId, totalWeight));

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
