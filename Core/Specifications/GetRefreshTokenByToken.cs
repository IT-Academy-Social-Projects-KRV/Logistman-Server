using Core.Entities.RefreshTokenEntity;

namespace Core.Specifications
{
    public class GetRefreshTokenByToken: BaseSpecification<RefreshToken>
    {
        public GetRefreshTokenByToken(string refreshToken) : base(r => r.Token == refreshToken)
        {

        }
    }
}
