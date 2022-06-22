using System.Collections.Generic;
using Core.DTO.TripDTO;

namespace Core.DTO.OfferDTO
{
    public class OffersForTripDTO
    {
        public int TripId { get; set; }
        public List<PointsTripDTO> PointsTrip { get; set; }
        public List<int> OffersId { get; set; }
    }
}
