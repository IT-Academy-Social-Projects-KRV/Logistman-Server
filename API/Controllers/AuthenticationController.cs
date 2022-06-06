using Core.DTO;
using Core.DTO.EmailDTO;
using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IEmailService _emailService;

        public AuthenticationController(
            IAuthenticationService authenticationService,
            IEmailService emailService)
        {
            _authenticationService = authenticationService;
            _emailService = emailService;
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register([FromBody] UserRegistrationDTO data)
        {
            await _authenticationService.RegisterAsync(data);
            return Ok();
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] UserLoginDTO data)
        {
            var tokens = await _authenticationService.LoginAsync(data);
            return Ok(tokens);
        }

        [HttpPost("refresh-token")]
        public async Task<IActionResult> RefreshTokenAsync([FromBody] UserAutorizationDTO userTokensDTO)
        {
            var tokens = await _authenticationService.RefreshTokenAsync(userTokensDTO);
            return Ok(tokens);
        }

        [HttpPost("logout")]
        public async Task<IActionResult> LogoutAsync([FromBody] UserLogoutDTO userLogoutDTO)
        {
            await _authenticationService.LogoutAsync(userLogoutDTO);
            return Ok();
        }

        [HttpPost("confirm-email")]
        public async Task<IActionResult> ConfirmEmailAsync(EmailConfirmationRequestDTO request)
        {
            await _emailService.ConfirmEmailAsync(request);
            return Ok();
        }
    }
}
