using Core.DTO;
using Core.Entities.TripEntity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface ITripValidationService
    {
        Task ValidateOffersCheckAsync(
            List<PointTripDTO> offersIds,
            int tripId,
            DateTimeOffset tripExpirationDate);
        Task ValidateTripDateAsync(
            DateTimeOffset tripStartDate,
            DateTimeOffset tripExpirationDate,
            string creatorId);
        void ValidatePointsInTrip(Trip trip, List<PointTripDTO> points);
    }
}
