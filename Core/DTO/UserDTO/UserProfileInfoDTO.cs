namespace Core.DTO.UserDTO
{
    public class UserProfileInfoDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsPhoneNumber { get; set; }
    }
}
