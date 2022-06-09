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
        public async Task<ActionResult> GetUserVerifiedAsync([FromQuery] PaginationFilterDTO paginationFilter)
        {
            var userId = _userService.GetCurrentUserNameIdentifier(User);
            var verifiedCars = await _carService.GetVerifiedByUserIdAsync(userId, paginationFilter);

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
        public async Task<OkResult> VerifyCarAsync(string vin)
        {
            await _carService.VerifyAsync(vin);
            return Ok();
        }
        
        [HttpPost("unverify")]
        [AuthorizeByRole(IdentityRoleNames.Logist)]
        public async Task<OkResult> UnverifyCarAsync(string vin)
        {
            await _carService.UnverifyAsync(vin);
            return Ok();
        }

        [HttpPost("delete")]
        [AuthorizeByRole(IdentityRoleNames.Logist)]
        public async Task<OkResult> DeleteCarAsync(string vin)
        {
            await _carService.DeleteAsync(vin);
            return Ok();
        }
    }
}
