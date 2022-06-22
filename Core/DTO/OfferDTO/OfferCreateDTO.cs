using System;

namespace Core.DTO.OfferDTO
{
    public class OfferCreateDTO
    {
        public string Description { get; set; }
        public float GoodsWeight { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public string GoodCategory { get; set; }
        public string Role { get; set; }
        public PointDTO Point { get; set; }
    }
}
