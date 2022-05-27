using System.Threading.Tasks;
using Core.DTO.CarDTO;
using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;
        private readonly IUserService _userService;

        public CarsController(ICarService carService, IUserService userService)
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

        [HttpGet]
        public ActionResult GetAllUserCars()
        {
            var userId = _userService.GetCurrentUserNameIdentifier(User);
            var userCars = _carService.GetAllUserCars(userId);
            return Ok(userCars);
        }
    }
}
