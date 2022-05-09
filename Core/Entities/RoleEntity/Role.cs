using Core.Entities.OfferEntity;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Core.Entities.RoleEntity
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Offer> Offers { get; set; }
    }
}
