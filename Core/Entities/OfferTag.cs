namespace Core.Entities
{
    public class OfferTag
    {
        public int Id { get; set; }
        public int OfferId { get; set; }
        public Offer Offer { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}