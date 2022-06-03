using Core.DTO.OfferDTO;
using System.Threading.Tasks;
using Core.DTO;
using Core.Helpers;

namespace Core.Interfaces.CustomService
{
    public interface IOfferService
    {
        Task CreateOfferAsync(OfferCreateDTO offerCreate, string userId);
        Task<OfferInfoDTO> GetOfferByIdAsync(int offerId, string userId);
        Task<PaginatedList<OfferPreviewDTO>> GetUsersOffersAsync(string userId, PaginationFilterDTO paginationFilter);
    }
}
