using Core.Entities.TripEntity;
using Core.Entities.UserEntity;
using System;

namespace Core.Entities.RatingEntity
{
    public class Rating
    {
        public int Id { get; set; }
        public int Mark { get; set; }
        public string Description { get; set; }
        public DateTimeOffset Date { get; set; }
        public int TripId { get; set; }
        public Trip Trip { get; set; }
        public string RatedUserId { get; set; }
        public User RatedUser { get; set; }
        public string EstimatorUserId { get; set; }
        public User EstimatorUser { get; set; }
    }
}
