﻿using Core.DTO.OfferDTO;
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
        public OfferController(
            IOfferService offerService, 
            IUserService userService)
        {
            _offerService = offerService;
            _userService = userService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] OfferCreateDTO offer)
        {
            var userId = _userService.GetCurrentUserNameIdentifier(User);
            return Ok(await _offerService.CreateOfferAsync(offer, userId));
        }

        [HttpGet("offer-info")]
        public async Task<IActionResult> GetOfferInfo(int offerId)
        {
            var userId = _userService.GetCurrentUserNameIdentifier(User);

            var offerDTO = await _offerService.GetConcreteOfferAsync(offerId, userId);

            return Ok(offerDTO);
        }
    }
}
