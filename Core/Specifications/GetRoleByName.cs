using Core.Entities.RoleEntity;

namespace Core.Specifications
{
    public class GetRoleByName : BaseSpecification<Role>
    {
        public GetRoleByName(string roleName) : base(r => r.Name == roleName.ToUpper())
        {

        }
    }
}
