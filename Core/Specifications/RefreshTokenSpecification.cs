using Ardalis.Specification;
using Core.Entities.RefreshTokenEntity;

namespace Core.Specifications
{
    public static class RefreshTokenSpecification
    {
        internal class GetByToken
        : Specification<RefreshToken>, ISingleResultSpecification<RefreshToken>
        {
            public GetByToken(string refreshToken)
            {
                Query.Where(r => r.Token == refreshToken);
            }
        }
    }
}
