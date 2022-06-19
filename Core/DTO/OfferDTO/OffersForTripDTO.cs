using System.Collections.Generic;

namespace Core.DTO.OfferDTO
{
    public class OffersForTripDTO
    {
        public int TripId { get; set; }
        public List<int> OffersIdList { get; set; }
    }
}
