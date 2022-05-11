using Core.DTO.GoodCategoryDTO;
using System.Threading.Tasks;
using Core.Entities.GoodCategoryEntity;

namespace Core.Interfaces.CustomService
{
    public interface IGoodCategoryService
    {
        Task<GoodCategoryListDTO> GetAllGoodCategoryAsync();
        int GetGoodCategoryByName(string name);
    }
}
