using System.Collections.Generic;
using System.Threading.Tasks;
using Core.DTO.CarCategoryDTO;

namespace Core.Interfaces.CustomService
{
    public interface ICarCategoryService
    {
        Task<List<CarCategoryDTO>> GetAllCarCategoriesAsync();
    }
}
