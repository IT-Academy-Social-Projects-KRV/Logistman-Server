using Core.Constants;
using Core.DTO;
using Core.Helpers;
using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly INotificationService _notificationService;
        private readonly IUserService _userService;

        public NotificationsController(
            INotificationService notificationService,
            IUserService userService)
        {
            _notificationService = notificationService;
            _userService = userService;
        }

        [HttpGet("by-user")]
        [AuthorizeByRole(IdentityRoleNames.User)]
        public async Task<IActionResult> GetAllByUserAsync(
            [FromQuery] PaginationFilterDTO paginationFilter)
        {
            var userId = _userService.GetCurrentUserNameIdentifier(User);
            var notifications =
                await _notificationService.GetByUserIdAsync(userId, paginationFilter);

            return Ok(notifications);
        }
    }
}
