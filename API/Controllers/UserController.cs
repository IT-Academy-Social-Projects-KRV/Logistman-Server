using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Core.DTO.UserDTO;
using Microsoft.AspNetCore.Authorization;
using Core.Constants;

namespace API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(
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

        [HttpPost("edit-info")]
        public async Task<ActionResult> UserEditProfileInfo(UserEditProfileInfoDTO userEditProfileInfo)
        {
            var userId = _userService.GetCurrentUserNameIdentifier(User);
            await _userService.UserEditProfileInfoAsync(userEditProfileInfo, userId);
            return Ok();
        }

        [HttpGet("user-full-name")]
        public async Task<ActionResult<UserFullNameDTO>> GetUserFullName()
        {
            var userId = _userService.GetCurrentUserNameIdentifier(User);

            return Ok(await _userService.GetUserFullNameAsync(userId));
        }

        [HttpGet]
        [Authorize(Policy = "ElevatedRights")]
        public async Task<ActionResult> GetAllUsersAsync()
        {
            return Ok(await _userService.GetAllUsersAsync());
        }
    }
}
