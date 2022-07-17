using Core.DTO.OfferDTO;
using System.Collections.Generic;

namespace Core.DTO.TripDTO
{
    public class TripOffersConfirmDTO
    {
        public int Id { get; set; }
        public IList<OfferConfirmDTO> Offers { get; set; }
    }
}
