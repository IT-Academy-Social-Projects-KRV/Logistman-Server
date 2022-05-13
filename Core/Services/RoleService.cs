using Microsoft.AspNetCore.Identity;
using Core.Entities.RoleEntity;
using Core.Exceptions;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using System.Linq;
using Core.Specifications;
using System.Threading.Tasks;

namespace Core.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRepository<Role> _roleRepository;
        private readonly IRepository<IdentityRole> _identityRoleRepository;

        public RoleService(
            IRepository<Role> roleRepository,
            IRepository<IdentityRole> identityRoleRepository)
        {
            _roleRepository = roleRepository;
            _identityRoleRepository = identityRoleRepository;
        }

        public async Task<int> GetRoleByNameAsync(string roleName)
        {
            var role = (await _roleRepository
                .FindWithSpecificationAsync(new GetRoleByName(roleName)))
                .First();

            ExceptionMethods.RoleNullCheck(role);
            return role.Id;
        }

        public async Task<IdentityRole> GetIdentityRoleByNameAsync(string roleName)
        {
            var role = (await _identityRoleRepository
                .FindWithSpecificationAsync(new GetIdentityRoleByUserRoleName(roleName)))
                .First();

            ExceptionMethods.IdentityRoleNullCheck(role);

            return role;
        }
    }
}
