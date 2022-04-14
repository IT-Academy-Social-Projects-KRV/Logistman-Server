using System;

namespace Core.Entities
{
    public class Report
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Closed { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int TripId { get; set; }
        public Trip Trip { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}