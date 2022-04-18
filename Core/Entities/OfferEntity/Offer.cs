using Core.Entities.GoodCategoryEntity;
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
        public DateTimeOffset ExpirationDate { get; set; }
        public int GoodCategoryId { get; set; }
        public GoodCategory GoodCategory { get; set; }
        public int OfferPointId { get; set; }
        public Point Point { get; set; }
        public int? RelatedTripId { get; set; }
        public Trip Trip { get; set; }
        public string OfferCreatorId { get; set; }
        public User User { get; set; }
        public string CreatorRoleId { get; set; }
        public Role Role { get; set; }
    }
}
