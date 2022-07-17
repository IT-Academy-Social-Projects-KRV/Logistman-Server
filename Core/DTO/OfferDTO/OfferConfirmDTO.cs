namespace Core.DTO.OfferDTO
{
    public class OfferConfirmDTO
    {
        public int Id { get; set; }
        public UserFullNameDTO UserFullName { get; set; }
        public string StartDate { get; set; }
        public string Description { get; set; }
        public float? GoodsWeight { get; set; }
        public string GoodCategoryName { get; set; }
        public string CreatorRoleName { get; set; }
        public PointOfferConfirmDTO PointInfo { get; set; }
    }
}
