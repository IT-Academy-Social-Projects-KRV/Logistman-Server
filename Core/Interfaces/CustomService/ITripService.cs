using Core.DTO;
using Core.DTO.TripDTO;
using Core.Helpers;
using System.Threading.Tasks;
using Core.DTO.OfferDTO;
using NetTopologySuite.Geometries;

namespace Core.Interfaces.CustomService
{
    public interface ITripService
    {
        Task<bool> CheckIsTripExistsById(int tripId);
        Task CreateTripAsync(CreateTripDTO createTripDTO, string creatorId);
        Task<PaginatedList<RouteDTO>> GetAllRoutesAsync(PaginationFilterDTO paginationFilter);
        Task<LineString> GetRouteGeographyDataAsync(int routeId);
        Task ManageOffersTripAsync(OffersForTripDTO offersForTrip);
    }
}
