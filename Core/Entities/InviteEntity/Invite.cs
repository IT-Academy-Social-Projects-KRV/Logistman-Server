using Core.Entities.OfferEntity;
using Core.Entities.TripEntity;
using Core.Entities.UserEntity;

namespace Core.Entities.InviteEntity
{
    public class Invite
    {
        public int Id { get; set; }
        public bool IsAccepted { get; set; }
        public bool IsAnswered { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public int? OfferId { get; set; }
        public Offer Offer { get; set; }
        public int TripId { get; set; }
        public Trip Trip { get; set; }
    }
}
