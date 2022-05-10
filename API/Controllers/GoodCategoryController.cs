using Core.DTO.GoodCategoryDTO;
using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class GoodCategoryController : ControllerBase
    {
        public readonly IGoodCategoryService _goodCategoryService;
        public GoodCategoryController(IGoodCategoryService goodCategoryService)
        {
            _goodCategoryService = goodCategoryService;
        }

        [HttpGet("get/all")]
        public async Task<GoodCategoryListDTO> GetAllGoodCategory()
        { 
            return await _goodCategoryService.GetAllGoodCategoryAsync();
        }
    }
}
