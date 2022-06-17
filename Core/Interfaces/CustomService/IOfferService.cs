using Core.DTO.OfferDTO;
using System.Threading.Tasks;
using Core.DTO;
using Core.Helpers;
using Core.Entities.OfferEntity;
using System.Collections.Generic;

namespace Core.Interfaces.CustomService
{
    public interface IOfferService
    {
        Task CreateOfferAsync(OfferCreateDTO offerCreate, string userId);
        Task<OfferInfoDTO> GetOfferByIdAsync(int offerId, string userId);
        Task<PaginatedList<OfferPreviewDTO>> GetUsersOffersAsync(string userId, PaginationFilterDTO paginationFilter);
        Task<PaginatedList<OfferPreviewDTO>> GetOffersNearRouteAsync(PaginationFilterDTO paginationFilter, int tripId);
    }
}
