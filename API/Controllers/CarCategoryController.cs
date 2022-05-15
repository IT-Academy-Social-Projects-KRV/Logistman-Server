using System.Threading.Tasks;
using Core.DTO.CarCategoryDTO;
using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CarCategoryController : ControllerBase
    {
        private readonly ICarCategoryService _carCategoryService;
        public CarCategoryController(ICarCategoryService carCategoryService)
        {
            _carCategoryService = carCategoryService;
        }

        [HttpGet("categories")]
        public async Task<CarCategoriesListDTO> GetAllCarCategories()
        { 
            return await _carCategoryService.GetAllCarCategoriesAsync();
        }
    }
}
