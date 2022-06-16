using Core.DTO.TripDTO;
using System.Threading.Tasks;
using Core.DTO.OfferDTO;

namespace Core.Interfaces.CustomService
{
    public interface ITripService
    {
        Task<bool> CheckIsTripExistsById(int tripId);
        Task CreateTripAsync(CreateTripDTO createTripDTO, string creatorId);
        Task AddOffersToTripAsync(OffersForTripDTO offersForTrip);
    }
}
