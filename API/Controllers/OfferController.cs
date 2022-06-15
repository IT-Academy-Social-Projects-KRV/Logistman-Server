using Core.DTO.OfferDTO;
using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Core.Helpers;
using Core.Constants;
using Core.DTO;

namespace API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OffersController : ControllerBase
    {
        private readonly IOfferService _offerService;
        private readonly IUserService _userService;
        public OffersController(
            IOfferService offerService, 
            IUserService userService)
        {
            _offerService = offerService;
            _userService = userService;
        }

        [HttpPost("create")]
        [AuthorizeByRole(IdentityRoleNames.User)]
        public async Task<IActionResult> Create([FromBody] OfferCreateDTO offer)
        {
            var userId = _userService.GetCurrentUserNameIdentifier(User);
            await _offerService.CreateOfferAsync(offer, userId);

            return Ok();
        }

        [HttpGet("user-offer")]
        [AuthorizeByRole(IdentityRoleNames.User)]
        public async Task<IActionResult> GetOfferInfo(int offerId)
        {
            var userId = _userService.GetCurrentUserNameIdentifier(User);

            var offerDTO = await _offerService.GetOfferByIdAsync(offerId, userId);

            return Ok(offerDTO);
        }

        [HttpGet]
        [AuthorizeByRole(IdentityRoleNames.User)]
        public async Task<IActionResult> GetUserOffersAsync([FromQuery] PaginationFilterDTO paginationFilter)
        {
            var userId = _userService.GetCurrentUserNameIdentifier(User);
            return Ok(await _offerService.GetUsersOffersAsync(userId, paginationFilter));
        }

        [HttpGet("offers-near-route")]
        [AuthorizeByRole(IdentityRoleNames.User)]
        public async Task<IActionResult> GetOffersNearRouteAsync(int routeId)
        {
            return Ok(await _offerService.GetOffersNearRouteAsync(routeId));
        }
    }
}
