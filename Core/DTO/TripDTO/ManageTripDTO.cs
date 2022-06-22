using System.Collections.Generic;

namespace Core.DTO.TripDTO
{
    public class ManageTripDTO
    {
        public int TripId { get; set; }
        public List<PointsTripDTO> PointsTrip { get; set; }
        public List<int> OffersId { get; set; }
    }
}
