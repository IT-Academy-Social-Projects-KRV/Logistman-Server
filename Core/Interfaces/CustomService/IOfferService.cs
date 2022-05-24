using System.Collections.Generic;
using Core.DTO.OfferDTO;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface IOfferService
    {
        Task CreateOfferAsync(OfferCreateDTO offerCreate, string userId);
        Task<OfferInfoDTO> GetOfferByIdAsync(int offerId, string userId);
        List<OfferPreviewDTO> GetUsersOffers(string userId);
    }
}
