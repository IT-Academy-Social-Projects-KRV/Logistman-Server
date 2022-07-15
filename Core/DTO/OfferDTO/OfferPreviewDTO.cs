using System;

namespace Core.DTO.OfferDTO
{
    public class OfferPreviewDTO
    {
        public int Id { get; set; }
        public string CreatorRoleName { get; set; }
        public DateTimeOffset CreationDate { get; set; }
        public string GoodCategoryName { get; set; }
        public string Description { get; set; }
        public bool IsClosed { get; set; }
        public float GoodsWeight { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public string Address { get; set; }
        public string Settlement { get; set; }
        public string Region { get; set; }
        public int? RelatedTripId { get; set; }
    }
}
