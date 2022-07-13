namespace Core.DTO.OfferDTO
{
    public class ConfirmGoodsTransferDTO
    {
        public OfferIdDTO OfferIdDTO { get; set; }
        public string TripRole { get; set; }
        public bool IsConfirmed { get; set; }
    }
}
