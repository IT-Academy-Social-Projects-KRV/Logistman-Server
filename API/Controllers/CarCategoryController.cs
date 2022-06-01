using System.Threading.Tasks;
using Core.Constants;
using Core.Helpers;
using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CarCategoriesController : ControllerBase
    {
        private readonly ICarCategoryService _carCategoryService;
        public CarCategoriesController(ICarCategoryService carCategoryService)
        {
            _carCategoryService = carCategoryService;
        }

        [HttpGet]
        [AuthorizeByRole(IdentityRoleNames.User)]
        public async Task<IActionResult> GetAllCarCategories()
        { 
            return Ok(await _carCategoryService.GetAllCarCategoriesAsync());
        }
    }
}
