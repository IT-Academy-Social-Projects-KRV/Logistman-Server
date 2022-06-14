using System.Collections.Generic;
using Core.Entities.OfferEntity;
using Core.Entities.TripEntity;
using NetTopologySuite.Geometries;

namespace Core.Entities.PointEntity
{
    public class PointData
    {
        public int Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public Point Location { get; set; }
        public string Address { get; set; }
        public string Settlement { get; set; }
        public string Region { get; set; }
        public int Order { get; set; }
        public int? TripId { get; set; }
        public Trip Trip { get; set; }
        public ICollection<Offer> Offers { get; set; }
    }
}
