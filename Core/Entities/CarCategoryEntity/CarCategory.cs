using System.Collections.Generic;
using Core.Entities.CarEntity;

namespace Core.Entities.CarCategoryEntity
{
    public class CarCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
