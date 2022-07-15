using System.Threading.Tasks;
using Core.Constants;
using Core.DTO;
using Core.Helpers;
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
        [AuthorizeByRole(IdentityRoleNames.User)]
        public async Task<ActionResult> CreateCarAsync([FromBody] CreateCarDTO carDTO)
        {
            var userId = _userService.GetCurrentUserNameIdentifier(User);
            return Ok(await _carService.AddCarAsync(carDTO, userId));
        }

        [HttpGet]
        [AuthorizeByRole(IdentityRoleNames.User)]
        public async Task<ActionResult> GetAllUserCarsAsync([FromQuery] PaginationFilterDTO paginationFilter)
        {
            var userId = _userService.GetCurrentUserNameIdentifier(User);
            var userCars = await _carService.GetAllUserCarsAsync(userId, paginationFilter);
            return Ok(userCars);
        }

        [HttpGet("user-verified")]
        [AuthorizeByRole(IdentityRoleNames.User)]
        public async Task<ActionResult> GetUserVerifiedAsync()
        {
            var userId = _userService.GetCurrentUserNameIdentifier(User);
            var verifiedCars = await _carService.GetVerifiedByUserIdAsync(userId);

            return Ok(verifiedCars);
        }

        [HttpGet("user-cars")]
        [AuthorizeByRole(IdentityRoleNames.Logist)]
        public async Task<ActionResult> GetAllUserCars([FromQuery] PaginationFilterDTO paginationFilter, string email)
        {
            var userId = await _userService.GetUserIdByEmailAsync(email);
            var userCars = await _carService.GetAllUserCarsAsync(userId, paginationFilter);
            return Ok(userCars);
        }

        [HttpPost("verify")]
        [AuthorizeByRole(IdentityRoleNames.Logist)]
        public async Task<OkResult> VerifyCarAsync(VinDTO vinDTO)
        {
            await _carService.VerifyAsync(vinDTO);
            return Ok();
        }

        [HttpPost("unverify")]
        [AuthorizeByRole(IdentityRoleNames.Logist)]
        public async Task<OkResult> UnverifyCarAsync(VinDTO vinDTO)
        {
            await _carService.UnverifyAsync(vinDTO);
            return Ok();
        }

        [HttpDelete("delete")]
        [AuthorizeByRole(IdentityRoleNames.User)]
        public async Task<IActionResult> DeleteCarAsync([FromQuery] CarIdDTO carIdDTO)
        {
            var userId = _userService.GetCurrentUserNameIdentifier(User);
            await _carService.DeleteCarAsync(userId, carIdDTO.CarId);

            return Ok();
        }
    }
}
