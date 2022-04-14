using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class UserTrip
    {
        public int Id { get; set; }
        public int TripId { get; set; }
        public Trip Trip { get; set; }
        public int OfferId { get; set; }
        public Offer Offer { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public bool Confirmed { get; set; }
    }
}