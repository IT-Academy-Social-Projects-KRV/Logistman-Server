using NetTopologySuite.Geometries;

namespace Core.DTO
{
    public class PointDTO
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Address { get; set; }
        public string Settlement { get; set; }
        public string Region { get; set; }
        public int Order { get; set; }
        public int? TripId { get; set; }
    }
}
