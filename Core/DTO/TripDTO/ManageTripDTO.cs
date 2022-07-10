using System.Collections.Generic;

namespace Core.DTO.TripDTO
{
    public class ManageTripDTO
    {
        public int TripId { get; set; }
        public float Distance { get; set; }
        public float TotalWeight { get; set; }
        public List<PointTripDTO> PointsTrip { get; set; }
    }
}
