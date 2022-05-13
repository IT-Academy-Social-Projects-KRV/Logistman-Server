using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface IRoleService
    {
        Task<IdentityRole> GetIdentityRoleByNameAsync(string roleName);
        Task<int> GetRoleByNameAsync(string name);
    }
}
