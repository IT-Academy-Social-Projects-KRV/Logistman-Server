using System;

namespace Core.DTO.TripDTO
{
    public class TripPreviewDTO
    {
        public UserFullNameDTO CreatorFullName { get; set; }
        public string Description { get; set; }
        public DateTimeOffset ExpirationDate { get; set; }
    }
}
