using Core.DTO.OfferDTO;
using System;
using System.Collections.Generic;

namespace Core.DTO.UserDTO
{
    public class UserFullInfoDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public float? Rating { get; set; }
        public bool HasCar { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public DateTimeOffset RegistrationDate { get; set; } = DateTimeOffset.UtcNow;
        public List<CarDTO> Cars { get; set; }
        public List<OfferPreviewDTO> Offers { get; set; }
    }
}
