using Ardalis.Specification;
using Core.DTO;
using Microsoft.AspNetCore.Identity;
using System.Linq;

namespace Core.Specifications
{
    public static class IdentityUserRoleSpecification
    {
        internal class GetUserRoleByRoleId : Specification<IdentityUserRole<string>>
        {
            public GetUserRoleByRoleId(string roleId, PaginationFilterDTO paginationFilter)
            {
                Query
                    .Where(r => r.RoleId == roleId)
                    .Skip((paginationFilter.PageNumber - 1) * paginationFilter.PageSize)
                    .Take(paginationFilter.PageSize);
            }
        }
    }
}
