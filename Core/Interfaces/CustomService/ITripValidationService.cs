using Core.DTO.OfferDTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface ITripValidationService
    {
        Task ValidateOffersCheckAsync(
            List<OfferIdDTO> offersIds,
            int tripId,
            DateTimeOffset tripExpirationDate);
        Task ValidateTripAsync(int tripId, float totalWeight);
        Task ValidateTripDateAsync(
            DateTimeOffset tripStartDate,
            DateTimeOffset tripExpirationDate,
            string creatorId);
    }
}
