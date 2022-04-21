using Core.Entities.UserEntity;

namespace Core.Entities.RefreshTokenEntity
{
    public class RefreshToken
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
