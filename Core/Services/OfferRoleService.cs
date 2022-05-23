using Core.Entities.RoleEntity;
using Core.Exceptions;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Core.Specifications;
using System.Threading.Tasks;

namespace Core.Services
{
    public class OfferRoleService : IOfferRoleService
    {
        private readonly IRepository<OfferRole> _roleRepository;

        public OfferRoleService(
            IRepository<OfferRole> roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task<int> GetRoleByNameAsync(string roleName)
        {
            var role = await _roleRepository
                .GetBySpecAsync(new OfferRoleSpecification.GetByName(roleName));

            ExceptionMethods.RoleNullCheck(role);
            return role.Id;
        }
    }
}
