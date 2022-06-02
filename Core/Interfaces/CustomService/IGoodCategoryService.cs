using Core.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface IGoodCategoryService
    {
        Task<List<GoodCategoryDTO>> GetAllGoodCategoryAsync();
        Task<int> GetGoodCategoryByNameAsync(string name);
    }
}
