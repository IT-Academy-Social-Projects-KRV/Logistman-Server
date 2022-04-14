using System.Collections.Generic;

namespace Core.Entities
{
    public class Route
    {
        public int Id { get; set; }
        public ICollection<Point> Points { get; set; }
        public ICollection<Offer> Offers { get; set; }
        public ICollection<Trip> Trips { get; set; }
    }
}