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
        public string Country { get; set; }
        public bool IsStopover { get; set; }
        public string Postcode { get; set; }
        public int Order { get; set; }
        public int? TripId { get; set; }
    }
}
