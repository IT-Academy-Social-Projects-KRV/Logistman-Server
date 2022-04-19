using Core.Entities.OfferEntity;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Core.Entities.RoleEntity
{
    public class Role : IdentityRole
    {
        public ICollection<Offer> Offers { get; set; }
    }
}
