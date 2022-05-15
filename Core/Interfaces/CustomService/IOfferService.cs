using Core.DTO.OfferDTO;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface IOfferService
    {
        Task CreateOfferAsync(OfferCreateDTO offerCreate, string userId);
    }
}
