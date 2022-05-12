using Microsoft.AspNetCore.Identity;
using Core.Entities.RoleEntity;
using Core.Exceptions;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using System.Linq;
using Core.Specifications;

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

        public int GetRoleByName(string roleName)
        {
            var role = _roleRepository
                .FindWithSpecification(new GetRoleByName(roleName))
                .First();

            ExceptionMethods.RoleNullCheck(role);
            return role.Id;
        }

        public IdentityRole GetIdentityRoleByName(string roleName)
        {
            var role = _identityRoleRepository
                .FindWithSpecification(new GetIdentityRoleByUserRoleName(roleName))
                .First();

            ExceptionMethods.IdentityRoleNullCheck(role);

            return role;
        }
    }
}
