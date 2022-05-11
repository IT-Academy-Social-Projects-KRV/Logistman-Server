using Core.Exceptions;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Identity;
using System.Linq;

namespace Core.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRepository<IdentityRole> _identityRoleRepository;

        public RoleService(IRepository<IdentityRole> identityRoleRepository)
        {
            _identityRoleRepository = identityRoleRepository;
        }

        public IdentityRole GetIdentityRoleByName(string roleName)
        {
            var role = _identityRoleRepository.Query().FirstOrDefault(r => r.Name == roleName);

            ExceptionMethods.IdentityRoleNullCheck(role);

            return role;
        }
    }
}
