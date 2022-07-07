using Core.DTO;
using Core.DTO.OfferDTO;
using Core.Helpers;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface IOfferService
    {
        Task CreateOfferAsync(OfferCreateDTO offerCreate, string userId);
        Task<OfferInfoDTO> GetOfferByIdAsync(int offerId, string userId);
        Task<PaginatedList<OfferPreviewDTO>> GetUsersOffersAsync(string userId, PaginationFilterDTO paginationFilter);
        Task<PaginatedList<PointOfferCreateTripDTO>> GetNearRouteAsync(PaginationFilterDTO paginationFilter, int tripId);
    }
}
