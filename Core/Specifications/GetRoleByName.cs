using Ardalis.Specification;
using Core.Entities.RoleEntity;

namespace Core.Specifications
{
    public class GetRoleByName : Specification<Role>, ISingleResultSpecification<Role>
    {
        public GetRoleByName(string roleName)
        {
            Query.Where(r => r.Name == roleName.ToUpper());
        }
    }
}
