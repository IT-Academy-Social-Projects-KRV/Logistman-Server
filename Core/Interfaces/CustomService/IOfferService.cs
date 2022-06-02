using System.Collections.Generic;
using Core.DTO.OfferDTO;
using System.Threading.Tasks;
using Core.Helpers;

namespace Core.Interfaces.CustomService
{
    public interface IOfferService
    {
        Task CreateOfferAsync(OfferCreateDTO offerCreate, string userId);
        Task<OfferInfoDTO> GetOfferByIdAsync(int offerId, string userId);
        Task<PaginatedList<OfferPreviewDTO>> GetUsersOffers(string userId, int pageNumber, int pageSize);
    }
}
