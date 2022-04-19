using AutoMapper;
using Core.DTO;
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
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<User> _userManager;
        private readonly IOptions<JwtOptions> _jwtOptions;
        private readonly IMapper _mapper;

        public AuthenticationService(UserManager<User> userManager, 
            IOptions<JwtOptions> jwtOptions, IMapper mapper)
        {
            _userManager = userManager;
            _jwtOptions = jwtOptions;
            _mapper = mapper;
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
                throw new HttpException("Invalid login or password.", System.Net.HttpStatusCode.BadRequest);
            }

            // generate token
            return new AuthenticationResultDTO
            {
                Token = GenerateToken(email)
            };
        }

        public Task LogoutAsync(AuthenticationResultDTO userTokensDTO)
        {
            throw new NotImplementedException();
        }

        public Task<AuthenticationResultDTO> RefreshTokenAsync(AuthenticationResultDTO userTokensDTO)
        {
            throw new NotImplementedException();
        }

        public async Task RegisterAsync(UserRegistrationDTO data)
        {
            var user = new User()
            {
                UserName = data.Email,
                Email = data.Email,
                Name = data.Name,
                Surname = data.Surname
            };
            var result = await _userManager.CreateAsync(user, data.Password);

            if (!result.Succeeded)
            {
                StringBuilder messageBuilder = new StringBuilder();

                foreach (var error in result.Errors)
                {
                    messageBuilder.AppendLine(error.Description);
                }

                throw new HttpException(messageBuilder.ToString(), System.Net.HttpStatusCode.BadRequest);
            }
        }

        public Task SentResetPasswordTokenAsync(string userEmail)
        {
            throw new NotImplementedException();
        }
    }
}
