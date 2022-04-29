﻿using AutoMapper;
using Core.DTO.UserDTO;
using Core.Entities.UserEntity;
using Core.Exceptions;
using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Identity;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Core.Resources;
using Core.Interfaces;
using Core.Entities.RefreshTokenEntity;
using System.Linq;

namespace Core.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly IJwtService _jwtService;
        private readonly IRepository<RefreshToken> _refreshTokenRepository;
        private readonly IRepository<User> _userRepository;

        public AuthenticationService(
            UserManager<User> userManager,
            IMapper mapper,
            IJwtService jwtService,
            IRepository<RefreshToken> refreshTokenRepository,
            IRepository<User> userRepository)
        {
            _userManager = userManager;
            _mapper = mapper;
            _jwtService = jwtService;
            _refreshTokenRepository = refreshTokenRepository;
            _userRepository = userRepository;
        }

        public async Task RegisterAsync(UserRegistrationDTO userData)
        {
            var user = _mapper.Map<User>(userData);
            var result = await _userManager.CreateAsync(user, userData.Password);

            if (!result.Succeeded)
            {
                var messageBuilder = new StringBuilder();

                foreach (var error in result.Errors)
                {
                    messageBuilder.AppendLine(error.Description);
                }

                throw new HttpException(messageBuilder.ToString(), HttpStatusCode.BadRequest);
            }
        }

        public async Task<UserAutorizationDTO> LoginAsync(UserLoginDTO data)
        {
            var user = await _userManager.FindByEmailAsync(data.Email);

            if (user == null || !await _userManager.CheckPasswordAsync(user, data.Password))
            {
                throw new HttpException(ErrorMessages.IncorrectLoginOrPassword, HttpStatusCode.Unauthorized);
            }

            return await GenerateUserTokens(user);
        }

        public async Task LogoutAsync(UserLogoutDTO userLogoutDTO)
        {
            var refreshToken = _refreshTokenRepository.Query().SingleOrDefault(t => t.Token == userLogoutDTO.RefreshToken);

            if (refreshToken == null)
            {
                throw new HttpException(ErrorMessages.InvalidToken, HttpStatusCode.NotFound);
            }

            await _refreshTokenRepository.DeleteAsync(refreshToken);
            await _refreshTokenRepository.SaveChangesAsync();
        }

        private async Task<UserAutorizationDTO> GenerateUserTokens(User user)
        {
            var claims = _jwtService.SetClaims(user);
            var token = _jwtService.CreateToken(claims);
            var refreshToken = await CreateRefreshToken(user.Id);
            user.RefreshTokens.Add(refreshToken);

            var tokens = new UserAutorizationDTO()
            {
                Token = token,
                RefreshToken = refreshToken.Token
            };

            return tokens;
        }

        private async Task<RefreshToken> CreateRefreshToken(string userId)
        {
            var refeshToken = _jwtService.GenerateRefreshToken();

            var refreshTokenEntity = new RefreshToken
            {
                Token = refeshToken,
                UserId = userId
            };

            await _refreshTokenRepository.InsertAsync(refreshTokenEntity);
            await _refreshTokenRepository.SaveChangesAsync();

            return refreshTokenEntity;
        }

        public async Task<UserAutorizationDTO> RefreshTokenAsync(UserAutorizationDTO userTokensDTO)
        {
            var refreshToken = GetRefreshToken(userTokensDTO.RefreshToken);
            var claims = _jwtService.GetClaimsFromExpiredToken(userTokensDTO.Token);
            var newToken = _jwtService.CreateToken(claims);
            var newRefreshToken = _jwtService.GenerateRefreshToken();

            refreshToken.Token = newRefreshToken;

            await _refreshTokenRepository.UpdateAsync(refreshToken);
            await _refreshTokenRepository.SaveChangesAsync();

            var tokens = new UserAutorizationDTO()
            {
                Token = newToken,
                RefreshToken = refreshToken.Token
            };

            return tokens;
        }

        private RefreshToken GetRefreshToken(string token)
        {
            var refreshToken = _refreshTokenRepository
                .Query()
                .Where(t => t.Token == token)
                .FirstOrDefault();

            ExceptionMethods.RefreshTokenNullCheck(refreshToken);

            return refreshToken;
        }
    }
}
