using System;
using System.Collections.Generic;

namespace Core.DTO.TripDTO
{
    public class TripInfoForConfirmDTO
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTimeOffset DepartureDate { get; set; }
        public string Description { get; set; }
        public float LoadCapacity { get; set; }
        public float Distance { get; set; }
        public List<PointTripInfoDTO> Points { get; set; }
    }
}
