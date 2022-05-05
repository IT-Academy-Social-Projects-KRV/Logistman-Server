using System;

namespace Core.DTO.CarDTO
{
    public class CarDTO
    {
        public string Model { get; set; }
        public string RegistrationNumber { get; set; }
        public string TechnicalPassport { get; set; }
        public float LoadCapacity { get; set; }
        public string Color { get; set; }
        public string Vin { get; set; }
        public string Category { get; set; }
        public bool IsVerified { get; set; }
        public DateTimeOffset CreationDate { get; set; }
    }
}
