using Ardalis.Specification;
using Core.Entities.RefreshTokenEntity;

namespace Core.Specifications
{
    public class GetRefreshTokenByToken 
        :  Specification<RefreshToken>, 
        ISingleResultSpecification<RefreshToken>
    {
        public GetRefreshTokenByToken(string refreshToken)
        {
            Query.Where(r => r.Token == refreshToken);
        }
    }
}
