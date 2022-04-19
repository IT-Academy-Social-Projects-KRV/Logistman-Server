﻿using Core.DTO;
using Core.Entities.UserEntity;
using Core.Exceptions;
using Core.Helpers;
using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<User> _userManager;
        private readonly IOptions<JwtOptions> _jwtOptions;

        public AuthenticationService(UserManager<User> userManager, 
            IOptions<JwtOptions> jwtOptions)
        {
            _userManager = userManager;
            _jwtOptions = jwtOptions;
        }

        public string GenerateToken(string email)
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Email, email)
            };

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOptions.Value.Key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                    issuer: _jwtOptions.Value.Issuer,
                    claims: claims,
                    expires: DateTime.UtcNow.AddHours(_jwtOptions.Value.LifeTime),
                    signingCredentials: credentials
                    );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<AuthenticationResultDTO> LoginAsync(string email, string password)
        {
            var user = await _userManager.FindByEmailAsync(email);

            if (user == null || !await _userManager.CheckPasswordAsync(user, password))
            {
                throw new HttpException("Invalid login or password.", HttpStatusCode.BadRequest);
            }

            return new AuthenticationResultDTO
            {
                Token = GenerateToken(email)
            };
        }

        public async Task RegisterAsync(UserRegistrationDTO userData)
        {
            var user = new User()
            {
                UserName = userData.Email,
                Email = userData.Email,
                Name = userData.Name,
                Surname = userData.Surname
            };
            var result = await _userManager.CreateAsync(user, userData.Password);

            if (!result.Succeeded)
            {
                StringBuilder messageBuilder = new StringBuilder();

                foreach (var error in result.Errors)
                {
                    messageBuilder.AppendLine(error.Description);
                }

                throw new HttpException(messageBuilder.ToString(), HttpStatusCode.BadRequest);
            }
        }
    }
}
