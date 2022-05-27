using System.Collections.Generic;
using System.Threading.Tasks;
using Core.DTO;

namespace Core.Interfaces.CustomService
{
    public interface ICarCategoryService
    {
        Task<List<CarCategoryDTO>> GetAllCarCategoriesAsync();
    }
}
