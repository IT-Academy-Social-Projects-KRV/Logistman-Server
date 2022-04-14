using System.Collections.Generic;

namespace Core.Entities
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<OfferTag> OfferTags { get; set; }
    }
}