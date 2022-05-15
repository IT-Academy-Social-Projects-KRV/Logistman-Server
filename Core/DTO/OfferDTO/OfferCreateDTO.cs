using System;
using Core.DTO.PointDTO;

namespace Core.DTO.OfferDTO
{
    public class OfferCreateDTO
    {
        public string Description { get; set; }
        public float GoodsWeight { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset ExpirationDate { get; set; }
        public string GoodCategory { get; set; }
        public string Role { get; set; }
        public CreatePointDTO Point { get; set; }
    }
}
