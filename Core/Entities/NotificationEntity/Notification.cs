using Core.Entities.OfferEntity;
using Core.Entities.TripEntity;
using Core.Entities.UserEntity;

namespace Core.Entities.NotificationEntity
{
    public class Notification
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public int OfferId { get; set; }
        public Offer Offer { get; set; }
        public int TripId { get; set; }
        public Trip Trip { get; set; }
    }
}
