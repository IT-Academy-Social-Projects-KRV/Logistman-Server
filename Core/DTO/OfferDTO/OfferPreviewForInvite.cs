namespace Core.DTO.OfferDTO
{
    public class OfferPreviewForInvite
    {
        public bool GoodTransferConfirmedByCreator { get; set; }
        public bool GoodTransferConfirmedByDriver { get; set; }
        public bool IsAnsweredByCreator { get; set; }
        public bool IsAnsweredByDriver { get; set; }
        public string CreatorRoleName { get; set; }
        public string GoodCategoryName { get; set; }
        public PointPreviewDTO PointInfo { get; set; }
    }
}
