using Microsoft.AspNetCore.Identity;
using Core.Entities.RoleEntity;
using Core.Exceptions;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Core.Specifications;
using System.Threading.Tasks;

namespace Core.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRepository<OfferRole> _roleRepository;
        private readonly RoleManager<IdentityRole> _identityRoleManager;

        public RoleService(
            IRepository<OfferRole> roleRepository,
            RoleManager<IdentityRole> identityRoleManger)
        {
            _roleRepository = roleRepository;
            _identityRoleManager = identityRoleManger;
        }

        public async Task<int> GetRoleByNameAsync(string roleName)
        {
            var role = await _roleRepository
                .GetBySpecAsync(new OfferRoleSpecification.GetByName(roleName));

            ExceptionMethods.RoleNullCheck(role);
            return role.Id;
        }

        public async Task<IdentityRole> GetIdentityRoleByNameAsync(string roleName)
        {
            var role = await _identityRoleManager.FindByNameAsync(roleName);

            ExceptionMethods.IdentityRoleNullCheck(role);

            return role;
        }
    }
}
