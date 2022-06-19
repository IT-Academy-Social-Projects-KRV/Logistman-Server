using System;
using System.Collections.Generic;

namespace Core.DTO.TripDTO
{
    public class RouteDTO
    {
        public int Id { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset ExpirationDate { get; set; }
        public string Description { get; set; }
        public float LoadCapacity { get; set; }
        public int MaxRouteDeviationKm { get; set; }
        public float Distance { get; set; }
        public UserFullNameDTO User { get; set; }
        public TripCarInfoDTO Car { get; set; }
        public List<PointDTO> Points { get; set; }
    }
}
