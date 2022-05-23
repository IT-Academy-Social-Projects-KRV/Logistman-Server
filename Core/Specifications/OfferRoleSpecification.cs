using Ardalis.Specification;
using Core.Entities.RoleEntity;

namespace Core.Specifications
{
    public static class OfferRoleSpecification
    {
        internal class GetByName : Specification<OfferRole>, ISingleResultSpecification<OfferRole>
        {
            public GetByName(string roleName)
            {
                Query.Where(r => r.Name == roleName.ToUpper());
            }
        }
    }
}
