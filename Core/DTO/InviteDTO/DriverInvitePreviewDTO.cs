using System.Collections.Generic;
using Core.DTO.OfferDTO;

namespace Core.DTO.InviteDTO
{
    public class DriverInvitePreviewDTO
    {
        public int Id { get; set; }
        public IList<OfferPreviewForInviteDTO> OfferInfo { get; set; }
    }
}
