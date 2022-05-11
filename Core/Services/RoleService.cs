using Microsoft.AspNetCore.Identity;
using Core.Entities.RoleEntity;
using Core.Exceptions;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using System.Linq;

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
            var role = _roleRepository.Query().FirstOrDefault(role => role.Name == roleName.ToUpper());
            ExceptionMethods.RoleNullCheck(role);
            return role.Id;
        }

        public IdentityRole GetIdentityRoleByName(string roleName)
        {
            var role = _identityRoleRepository.Query().FirstOrDefault(r => r.Name == roleName);

            ExceptionMethods.IdentityRoleNullCheck(role);

            return role;
        }
    }
}
