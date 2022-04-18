using System;
using System.Collections.Generic;
using Core.Entities.CarCategoryEntity;
using Core.Entities.TripEntity;

namespace Core.Entities.CarEntity
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string RegistrationNumber { get; set; }
        public string TechnicalPassport { get; set; }
        public float LoadCapacity { get; set; }
        public string Color { get; set; }
        public string Vin { get; set; }
        public DateTimeOffset CreationDate { get; set; }
        public int CategoryId { get; set; }
        public CarCategory Category { get; set; }
        public ICollection<Trip> Trips { get; set; }
    }
}
