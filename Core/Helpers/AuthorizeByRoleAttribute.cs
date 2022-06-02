using Core.Constants;
using Microsoft.AspNetCore.Authorization;
using System;

namespace Core.Helpers
{
    public class AuthorizeByRoleAttribute : AuthorizeAttribute
    {
        public AuthorizeByRoleAttribute(params IdentityRoleNames[] roles)
        {
            Roles = String.Join(",", roles);
        }
    }
}
