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
        public RoleService(IRepository<Role> roleRepository)
        {
            _roleRepository = roleRepository;
        }
        public int GetRoleByName(string name)
        {
            var role = _roleRepository.Query().FirstOrDefault(role => role.Name == name.ToUpper());
            ExceptionMethods.RoleNullCheck(role);
            return role.Id;
        }
    }
}
