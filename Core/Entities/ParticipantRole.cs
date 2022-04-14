using System.Collections.Generic;

namespace Core.Entities
{
    public class ParticipantRole 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Point> Points { get; set; }
        public ICollection<Offer> Offers { get; set; }
    }
}