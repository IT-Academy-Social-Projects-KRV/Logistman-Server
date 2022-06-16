using Core.DTO.TripDTO;
using NetTopologySuite.Geometries;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface ITripService
    {
        Task<bool> CheckIsTripExistsById(int tripId);
        Task CreateTripAsync(CreateTripDTO createTripDTO, string creatorId);
        Task<LineString> GetRouteGeographyData(int routeId);
    }
}
