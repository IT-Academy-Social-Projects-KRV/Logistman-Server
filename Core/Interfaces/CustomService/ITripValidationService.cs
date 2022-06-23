using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface ITripValidationService
    {
        Task ValidOffersCheckAsync(
            List<int> offerIds,
            int tripId,
            DateTimeOffset startTrip,
            DateTimeOffset expirationTrip);

        Task ValidateTripAsync(int tripId, float totalWeight);

        Task ValidateTripDateAsync(
            DateTimeOffset startDate,
            DateTimeOffset expirationDate,
            string creatorId);
    }
}
