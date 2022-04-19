﻿using Core.DTO;
using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Http;
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
            return Ok("Successfully created new user!");
        }

        [HttpPost("login")]
        public async Task<ActionResult<AuthenticationResultDTO>> Login([FromBody] UserLoginDTO data)
        {
            return await _authenticationService.LoginAsync(data.Email, data.Password);
        }
    }
}
