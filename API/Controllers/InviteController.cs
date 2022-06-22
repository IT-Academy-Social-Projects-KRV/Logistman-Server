using Core.Constants;
using Core.DTO.InviteDTO;
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
    public class InvitesController : ControllerBase
    {
        private readonly IInviteService _inviteService;

        public InvitesController(IInviteService inviteService)
        {
            _inviteService = inviteService;
        }

        [HttpPost("create-list")]
        [AuthorizeByRole(IdentityRoleNames.Logist)]
        public async Task<ActionResult> CreateTripInvitesAsync(
            [FromBody] CreateTripInvitesDTO createTripInvitesDTO)
        {
            await _inviteService.CreateTripInvitesAsync(createTripInvitesDTO);
            return Ok();
        }
    }
}
