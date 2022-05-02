﻿using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(
            IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("user-info")]
        public async Task<ActionResult> GetUserInfo()
        {
            var userInfo = await _userService.GetUserProfileInfoAsync(User);
            return Ok(userInfo);
        }
    }
}
