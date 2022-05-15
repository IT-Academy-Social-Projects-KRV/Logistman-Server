using Core.DTO.TripDTO;
using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TripController : ControllerBase
    {
        private readonly ITripService _tripService;
        private readonly IUserService _userService;

        public TripController(
            ITripService tripService,
            IUserService userService)
        {
            _tripService = tripService;
            _userService = userService;
        }

        [HttpPost("create")]
        public async Task<ActionResult> CreateTripAsync([FromBody] CreateTripDTO createTripDTO)
        {
            var userId = _userService.GetCurrentUserNameIdentifier(User);
            await _tripService.CreateTripAsync(createTripDTO, userId);

            return Ok();
        }
    }
}
