using System.Collections;
using System.Linq;

namespace Core.DTO.GoodCategoryDTO
{
    public class GoodCategoryListDTO
    {
        public IQueryable<GoodCategoryDTO> GoodCategories { get; set; }
    }
}
