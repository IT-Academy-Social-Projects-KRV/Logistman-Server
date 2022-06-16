using System;

namespace Core.DTO.OfferDTO
{
    public class OfferTripDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public float GoodsWeight { get; set; }
        public DateTimeOffset ExpirationDate { get; set; }
        public string GoodCategoryName { get; set; }
        public string CreatorRoleName { get; set; }
        public int RelatedTripId { get; set; }
        public PointDTO Point { get; set; }
    }
}
