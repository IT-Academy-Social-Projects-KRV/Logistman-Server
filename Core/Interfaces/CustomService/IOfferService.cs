using System.Threading.Tasks;
using Core.DTO.OfferDTO;
using Core.Entities.OfferEntity;

namespace Core.Interfaces.CustomService
{
    public interface IOfferService
    {
        Task CreateOffer(OfferCreateDTO offerCreate);
    }
}
