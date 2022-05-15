using Core.DTO.TripDTO;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface ITripService
    {
        bool CheckIsTripExistsById(int tripId);
        Task CreateTripAsync(CreateTripDTO createTripDTO, string creatorId);
    }
}
