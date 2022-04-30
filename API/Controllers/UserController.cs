using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(
            IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("get-user-info")]
        public async Task<ActionResult> GetUserInfo()
        {
            var userInfo = await _userService.GetUserProfileInfoAsync(Request);
            return Ok(userInfo);
        }
    }
}
