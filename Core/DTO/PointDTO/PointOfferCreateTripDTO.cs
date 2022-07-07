namespace Core.DTO
{
    public class PointOfferCreateTripDTO
    {
        public int PointId { get; set; }
        public int? OfferId { get; set; }
        public int? RelatedTripId { get; set; }
        public string CreationDate { get; set; }
        public string Description { get; set; }
        public float? GoodsWeight { get; set; }
        public string GoodCategoryName { get; set; }
        public string CreatorRoleName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Address { get; set; }
        public string Settlement { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }
        public int Order { get; set; }
    }
}
