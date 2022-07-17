using System;

namespace Core.DTO.OfferDTO
{
    public class OfferConfirmGoodsDeliveryDTO
    {
        public int OfferId { get; set; }
        public UserFullNameDTO UserFullName { get; set; }
        public string CreatorRoleName { get; set; }
        public string Address { get; set; }
        public string Settlement { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public string Region { get; set; }
        public string GoodCategoryName { get; set; }
        public string Description { get; set; }
        public float GoodsWeight { get; set; }
    }
}
