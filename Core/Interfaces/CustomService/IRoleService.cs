using Microsoft.AspNetCore.Identity;

namespace Core.Interfaces.CustomService
{
    public interface IRoleService
    {
        IdentityRole GetIdentityRoleByName(string roleName);
        int GetRoleByName(string name);
    }
}
