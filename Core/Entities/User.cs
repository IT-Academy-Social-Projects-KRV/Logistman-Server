using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public class User : IdentityUser
    {
        public override string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public float Rating { get; set; }
        public bool IsHasCar { get; set; }
        public DateTime RegistrationDate { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
        public virtual ICollection<UserTrip> UserTrips { get; set; }
        public virtual ICollection<Offer> Offers { get; set; }
    }
}
