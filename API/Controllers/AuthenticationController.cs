using Core.DTO.UserDTO;
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

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
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
    }
}
