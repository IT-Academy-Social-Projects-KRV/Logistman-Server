using Ardalis.Specification;
using Core.Entities.UserEntity;
using System.Collections.Generic;

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

        internal class GetAllUsers : Specification<User>
        {
            public GetAllUsers(IList<User> usersList)
            {
                Query.Where(u => usersList.Contains(u));
            }
        }
    }
}
