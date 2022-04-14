using System.Collections.Generic;

namespace Core.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RegistrationDate { get; set; }
        public string TechnicalPassport { get; set; }
        public float LoadCapacity { get; set; }
        public float Volume { get; set; }
        public string Color { get; set; }
        public string Vin { get; set; }
        public string Category { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public virtual ICollection<Offer> Offers { get; set; }
    }
}
