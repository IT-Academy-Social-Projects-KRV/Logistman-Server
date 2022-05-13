using Microsoft.AspNetCore.Identity;

namespace Core.Specifications
{
    public class GetIdentityRoleByUserRoleName : BaseSpecification<IdentityRole>
    {
        public GetIdentityRoleByUserRoleName(string roleName) : base(r => r.Name == roleName)
        {

        }
    }
}
