using Core.DTO.GoodCategoryDTO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface IGoodCategoryService
    {
        Task<GoodCategoryListDTO> GetAllGoodCategory();
    }
}
