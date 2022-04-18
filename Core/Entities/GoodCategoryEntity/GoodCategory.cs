using System.Collections.Generic;
using Core.Entities.OfferEntity;

namespace Core.Entities.GoodCategoryEntity
{
    public class GoodCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Offer> Offers { get; set; }
    }
}
