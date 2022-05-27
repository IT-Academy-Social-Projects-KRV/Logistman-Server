using Core.Entities.OfferEntity;
using System.Collections.Generic;

namespace Core.Entities.RoleEntity
{
    public class OfferRole
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Offer> Offers { get; set; }
    }
}
