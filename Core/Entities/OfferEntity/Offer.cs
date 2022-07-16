using Core.Entities.GoodCategoryEntity;
using Core.Entities.NotificationEntity;
using Core.Entities.PointEntity;
using Core.Entities.RoleEntity;
using Core.Entities.TripEntity;
using Core.Entities.UserEntity;
using System;

namespace Core.Entities.OfferEntity
{
    public class Offer
    {
        public int Id { get; set; }
        public DateTimeOffset CreationDate { get; set; }
        public string Description { get; set; }
        public bool IsClosed { get; set; }
        public float GoodsWeight { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public int GoodCategoryId { get; set; }
        public GoodCategory GoodCategory { get; set; }
        public int OfferPointId { get; set; }
        public PointData Point { get; set; }
        public int? RelatedTripId { get; set; }
        public Trip Trip { get; set; }
        public string OfferCreatorId { get; set; }
        public User User { get; set; }
        public int CreatorRoleId { get; set; }
        public OfferRole OfferRole { get; set; }
        public int? NotificationId { get; set; }
        public Notification Notification { get; set; }
    }
}
