using System.Collections.Generic;
using Core.DTO.TripDTO;

namespace Core.DTO.OfferDTO
{
    public class OffersForTripDTO
    {
        public int TripId { get; set; }
        public List<PointsTrip> PointsTripList { get; set; }
        public List<int> OffersIdList { get; set; }
    }
}
