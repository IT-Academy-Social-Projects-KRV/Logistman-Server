using System;
using System.Collections.Generic;

namespace Core.DTO.UserDTO
{
    public class UserFullInfoDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public float? Rating { get; set; }
        public bool HasCar { get; set; }
        public DateTimeOffset RegistrationDate { get; set; } = DateTimeOffset.UtcNow;
        public ICollection<CarDTO> Cars { get; set; }
    }
}
