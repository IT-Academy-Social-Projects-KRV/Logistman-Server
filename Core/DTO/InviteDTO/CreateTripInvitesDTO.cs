using System.Collections.Generic;

namespace Core.DTO.InviteDTO
{
    public class CreateTripInvitesDTO
    {
        public int TripId { get; set; }
        public List<int> OffersId { get; set; }
    }
}
