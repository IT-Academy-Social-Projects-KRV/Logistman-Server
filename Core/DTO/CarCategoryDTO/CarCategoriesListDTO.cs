using System.Linq;

namespace Core.DTO.CarCategoryDTO
{
    public class CarCategoriesListDTO
    {
        public IQueryable<CarCategoryDTO> CarCategories { get; set; }
    }
}
