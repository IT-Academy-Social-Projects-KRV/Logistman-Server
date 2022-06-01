using Core.Constants;
using Core.DTO;
using Core.Helpers;
using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class GoodCategoriesController : ControllerBase
    {
        public readonly IGoodCategoryService _goodCategoryService;
        public GoodCategoriesController(IGoodCategoryService goodCategoryService)
        {
            _goodCategoryService = goodCategoryService;
        }

        [HttpGet]
        [AuthorizeByRole(IdentityRoleNames.User)]
        public async Task<List<GoodCategoryDTO>> GetAllGoodCategory()
        { 
            return await _goodCategoryService.GetAllGoodCategoryAsync();
        }
    }
}
