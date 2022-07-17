using System;
using System.Collections.Generic;

namespace Core.DTO.TripDTO
{
    public class RoutePreviewDTO
    {
        public int Id { get; set; }
        public DateTimeOffset DepartureDate { get; set; }
        public string Description { get; set; }
        public float LoadCapacity { get; set; }
        public int MaxRouteDeviationKm { get; set; }
        public float Distance { get; set; }
        public TripCarInfoDTO Car { get; set; }
        public List<PointPreviewDTO> Points { get; set; }
    }
}
