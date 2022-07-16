using Core.DTO.OfferDTO;
using System.Collections.Generic;

namespace Core.DTO.InviteDTO
{
    public class InvitePreviewDTO
    {
        public int Id { get; set; }
        public PointPreviewDTO PointFromInfo { get; set; }
        public PointPreviewDTO PointToInfo { get; set; }
        public bool IsAnswered { get; set; }
        public bool IsAccepted { get; set; }
        public float TotalGoodsWeight { get; set; }
        public float TotalDistance { get; set; }
        public int TotalOffersCount { get; set; }
        public List<OfferPreviewInTripInviteDTO> OffersInfo { get; set; }
    }
}
