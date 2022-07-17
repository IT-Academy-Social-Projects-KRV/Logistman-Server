using Core.DTO.OfferDTO;
using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Core.Helpers;
using Core.Constants;
using Core.DTO;
using Core.DTO.TripDTO;

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

        [HttpGet("near-route")]
        [AuthorizeByRole(IdentityRoleNames.Logist)]
        public async Task<IActionResult> GetNearRouteAsync([FromQuery] TripIdDTO tripIdDTO)
        {
            return Ok(await _offerService.GetNearRouteAsync(tripIdDTO.TripId));
        }

        [HttpDelete("delete")]
        [AuthorizeByRole(IdentityRoleNames.User)]
        public async Task<IActionResult> DeleteAsync([FromQuery] OfferIdDTO offerIdDTO)
        {
            var userId = _userService.GetCurrentUserNameIdentifier(User);

            await _offerService.DeleteAsync(offerIdDTO, userId);

            return Ok();
        }

        [HttpPost("confirm-goods-transfer")]
        [AuthorizeByRole(IdentityRoleNames.User)]
        public async Task<IActionResult> ConfirmGoodsTransferAsync(
            [FromBody] ConfirmGoodsTransferDTO confirmGoodsTransferDTO)
        {
            var userId = _userService.GetCurrentUserNameIdentifier(User);

            await _offerService.ConfirmGoodsTransferAsync(confirmGoodsTransferDTO, userId);

            return Ok();
        }
    }
}
