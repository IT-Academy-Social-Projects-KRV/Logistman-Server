using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public class Offer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public bool Closed { get; set; }
        public float Weight { get; set; }
        public float Volume { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int RouteId { get; set; }
        public Route Route { get; set; }
        public int ParticipantRoleId { get; set; }
        public ParticipantRole ParticipantRole { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public virtual ICollection<UserTrip> UserTrips { get; set; }
        public virtual ICollection<OfferTag> OfferTags { get; set; }
    }
}