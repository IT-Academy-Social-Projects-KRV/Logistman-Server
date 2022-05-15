using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Core.DTO.UserDTO;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers
{
    [Authorize]
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

        [HttpGet("user-info")]
        public async Task<ActionResult> GetUserInfo()
        {
            var userId = _userService.GetCurrentUserNameIdentifier(User);
            var userInfo = await _userService.GetUserProfileInfoAsync(userId);
            return Ok(userInfo);
        }

        [HttpPost("edit/info")]
        public async Task<UserEditProfileInfoDTO> UserEditProfileInfo(UserEditProfileInfoDTO userEditProfileInfo)
        {
            var userId = _userService.GetCurrentUserNameIdentifier(User);
            return await _userService.UserEditProfileInfo(userEditProfileInfo, userId);
        }
    }
}
