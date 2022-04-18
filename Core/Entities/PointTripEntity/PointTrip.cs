using Core.Entities.PointEntity;
using Core.Entities.TripEntity;

namespace Core.Entities.PointTripEntity
{
    public class PointTrip
    {
        public int Id { get; set; }
        public int TripId { get; set; }
        public Trip Trip { get; set; }
        public int PointId { get; set; }
        public Point Point { get; set; }
    }
}
