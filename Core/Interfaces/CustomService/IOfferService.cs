using Core.DTO.OfferDTO;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface IOfferService
    {
        Task<OfferCreateDTO> CreateOfferAsync(OfferCreateDTO offerCreate, string userId);
    }
}
