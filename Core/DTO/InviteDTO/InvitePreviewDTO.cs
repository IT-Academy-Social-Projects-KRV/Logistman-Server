using Core.DTO.OfferDTO;
using Core.DTO.TripDTO;

namespace Core.DTO.InviteDTO
{
    public class InvitePreviewDTO
    {
        public int Id { get; set; }
        public bool IsAnswered { get; set; }
        public OfferPreviewForInviteDTO OfferInfo { get; set; }
        public TripPreviewForInviteDTO TripInfo { get; set; }
    }
}
