using System;
using System.Collections.Generic;

namespace Core.DTO.TripDTO
{
    public class TripInfoDTO
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string RegistrationNumber { get; set; }
        public UserFullNameDTO FullName { get; set; }
        public DateTimeOffset DepartureDate { get; set; }
        public string Description { get; set; }
        public float LoadCapacity { get; set; }
        public float Distance { get; set; }
        public IList<PointOfferCreateTripDTO> Points { get; set; }
    }
}
