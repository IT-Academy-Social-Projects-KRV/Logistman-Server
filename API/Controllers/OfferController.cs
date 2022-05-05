using Core.DTO.OfferDTO;
using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        private readonly IOfferService _offerService;
        public OfferController(IOfferService offerService)
        {
            _offerService = offerService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] OfferCreateDTO offer)
        {
            await _offerService.CreateOffer(offer);
            return Ok(offer);
        }
    }
}
