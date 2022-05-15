using Core.DTO.PointDTO;
using System;

namespace Core.DTO.OfferDTO
{
    public class OfferInfoDTO
    {
        public int Id { get; set; }
        public DateTimeOffset CreationDate { get; set; }
        public string Description { get; set; }
        public bool IsClosed { get; set; }
        public float GoodsWeight { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset ExpirationDate { get; set; }
        public string GoodCategory { get; set; }
        public string Role { get; set; }
        public int? RelatedTripId { get; set; }
        public PointInfoDTO Point { get; set; }
    }
}
