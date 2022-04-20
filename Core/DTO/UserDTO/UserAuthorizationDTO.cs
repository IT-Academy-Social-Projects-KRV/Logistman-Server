namespace Core.DTO
{
    public class UserAuthorizationDTO
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public string Provider { get; set; }
    }
}
