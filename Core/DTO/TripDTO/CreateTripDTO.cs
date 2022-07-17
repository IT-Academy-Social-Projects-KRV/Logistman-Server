using System;
using System.Collections.Generic;

namespace Core.DTO.TripDTO
{
    public class CreateTripDTO
    {
        public DateTimeOffset DepartureDate { get; set; }
        public string Description { get; set; }
        public float LoadCapacity { get; set; }
        public int MaxRouteDeviationKm { get; set; }
        public int TransportationCarId { get; set; }
        public float Distance { get; set; }
        public List<PointDTO> Points { get; set; }
    }
}
