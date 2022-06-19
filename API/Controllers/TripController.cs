using Core.Constants;
using Core.DTO;
using Core.DTO.TripDTO;
using Core.Helpers;
using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Core.DTO.OfferDTO;

namespace API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TripsController : ControllerBase
    {
        private readonly ITripService _tripService;
        private readonly IUserService _userService;

        public TripsController(
            ITripService tripService,
            IUserService userService)
        {
            _tripService = tripService;
            _userService = userService;
        }

        [HttpPost("create")]
        [AuthorizeByRole(IdentityRoleNames.User)]
        public async Task<ActionResult> CreateTripAsync([FromBody] CreateTripDTO createTripDTO)
        {
            var userId = _userService.GetCurrentUserNameIdentifier(User);
            await _tripService.CreateTripAsync(createTripDTO, userId);

            return Ok();
        }

        [HttpGet("routes")]
        [AuthorizeByRole(IdentityRoleNames.Logist)]
        public async Task<IActionResult> GetAllRoutesAsync([FromQuery] PaginationFilterDTO paginationFilter)
        {
            return Ok(await _tripService.GetAllRoutesAsync(paginationFilter));
        }

        [HttpPost("add-offers")]
        [AuthorizeByRole(IdentityRoleNames.Logist)]
        public async Task<ActionResult> AddOffersToTripAsync([FromBody] OffersForTripDTO offersForTrip)
        {
            await _tripService.AddOffersToTripAsync(offersForTrip);
            return Ok();
        }

        [HttpPost("manage-offers")]
        [AuthorizeByRole(IdentityRoleNames.Logist)]
        public async Task<ActionResult> ManageOffersTripAsync([FromBody] OffersForTripDTO offersForTrip)
        {
            await _tripService.ManageOffersTripAsync(offersForTrip);
            return Ok();
        }
    }
}
