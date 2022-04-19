using System.Collections.Generic;
using Core.Entities.OfferEntity;
using Core.Entities.TripEntity;

namespace Core.Entities.PointEntity
{
    public class Point
    {
        public int Id { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string Address { get; set; }
        public string Settlement { get; set; }
        public string Region { get; set; }
        public int Order { get; set; }
        public ICollection<Offer> Offers { get; set; }
        public ICollection<Trip> Trips { get; set; }
    }
}
