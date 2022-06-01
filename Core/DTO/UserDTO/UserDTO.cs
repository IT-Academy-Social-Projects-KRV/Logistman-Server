using System;

namespace Core.DTO
{
    public class UserDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public float? Rating { get; set; }
        public bool HasCar { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public DateTimeOffset RegistrationDate { get; set; }
    }
}
