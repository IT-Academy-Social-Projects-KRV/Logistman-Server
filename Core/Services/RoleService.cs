using Microsoft.AspNetCore.Identity;
using Core.Entities.RoleEntity;
using Core.Exceptions;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using System.Linq;
using Core.Specifications;
<<<<<<< HEAD
using System.Threading.Tasks;
=======
>>>>>>> 8a83ac67acfb270be6b52f5d2140f970db84dace

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
<<<<<<< HEAD
            var role = (await _roleRepository
                .FindWithSpecificationAsync(new GetRoleByName(roleName)))
=======
            var role = _roleRepository
                .FindWithSpecification(new GetRoleByName(roleName))
>>>>>>> 8a83ac67acfb270be6b52f5d2140f970db84dace
                .First();

            ExceptionMethods.RoleNullCheck(role);
            return role.Id;
        }

        public async Task<IdentityRole> GetIdentityRoleByNameAsync(string roleName)
        {
<<<<<<< HEAD
            var role = (await _identityRoleRepository
                .FindWithSpecificationAsync(new GetIdentityRoleByUserRoleName(roleName)))
=======
            var role = _identityRoleRepository
                .FindWithSpecification(new GetIdentityRoleByUserRoleName(roleName))
>>>>>>> 8a83ac67acfb270be6b52f5d2140f970db84dace
                .First();

            ExceptionMethods.IdentityRoleNullCheck(role);

            return role;
        }
    }
}
