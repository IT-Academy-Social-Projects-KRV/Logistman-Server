using Ardalis.Specification;
using Core.Entities.UserEntity;

namespace Core.Specifications
{
    public static class UserSpecification
    {
        internal class GetByEmail : Specification<User>, ISingleResultSpecification<User>
        {
            public GetByEmail(string email)
            {
                Query.Where(u => u.Email == email);
            }
        }
        internal class GetByConfirmationToken : Specification<User>, ISingleResultSpecification<User>
        {
            public GetByConfirmationToken(string token)
            {
                Query.Where(u => u.ConfirmationEmailToken == token);
            }
        }
    }
}
