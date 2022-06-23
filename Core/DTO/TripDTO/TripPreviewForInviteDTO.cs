using System;

namespace Core.DTO.TripDTO
{
    public class TripPreviewForInviteDTO
    {
        public string CreatorFullName { get; set; }
        public string Description { get; set; }
        public DateTimeOffset ExpirationDate { get; set; }
    }
}
