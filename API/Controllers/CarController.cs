using System.Threading.Tasks;
using Core.DTO.CarDTO;
using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;
        private readonly IUserService _userService;

        public CarController(ICarService carService, IUserService userService)
        {
            _carService = carService;
            _userService = userService;
        }
        
        [HttpPost("add")]
        public async Task<ActionResult> CreateCarAsync([FromBody] CreateCarDTO carDTO)
        {
            var userId = _userService.GetCurrentUserNameIdentifier(User);
            return Ok(await _carService.AddCarAsync(carDTO, userId));
        }
    }
}