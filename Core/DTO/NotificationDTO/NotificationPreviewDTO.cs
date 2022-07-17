using Core.DTO.OfferDTO;
using Core.DTO.TripDTO;

namespace Core.DTO.NotificationDTO
{
    public class NotificationPreviewDTO
    {
        public OfferPreviewForNotificationDTO OfferInfo { get; set; }
        public TripPreviewDTO TripInfo { get; set; }
    }
}
