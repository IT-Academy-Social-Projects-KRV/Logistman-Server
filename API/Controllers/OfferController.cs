using Core.DTO.OfferDTO;
using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        private readonly IOfferService _offerService;
        private readonly IUserService _userService;
        private readonly IPointService _pointService;
        public OfferController(
            IOfferService offerService, 
            IUserService userService,
            IPointService pointService)
        {
            _offerService = offerService;
            _userService = userService;
            _pointService = pointService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] OfferCreateDTO offer)
        {
            var userId = _userService.GetCurrentUserNameIdentifier(User);
            return Ok(await _offerService.CreateOffer(offer, userId));
        }
    }
}
