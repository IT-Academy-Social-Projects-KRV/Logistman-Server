using System;
using System.Collections.Generic;
using Core.Entities.CarCategoryEntity;
using Core.Entities.TripEntity;
using Core.Entities.UserEntity;

namespace Core.Entities.CarEntity
{
    public class Car
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public string Model { get; set; }
        public string RegistrationNumber { get; set; }
        public string TechnicalPassport { get; set; }
        public float LoadCapacity { get; set; }
        public string Color { get; set; }
        public string Vin { get; set; }
        public DateTimeOffset CreationDate { get; set; }
        public int CategoryId { get; set; }
        public CarCategory Category { get; set; }
        public bool IsVerified { get; set; }
        public ICollection<Trip> Trips { get; set; }
    }
}
