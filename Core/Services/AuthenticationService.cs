using AutoMapper;
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
        protected readonly IRepository<RefreshToken> _refreshTokenRepository;

        public AuthenticationService(
            UserManager<User> userManager,
            IMapper mapper,
            IJwtService jwtService,
            IRepository<RefreshToken> refreshTokenRepository)
        {
            _userManager = userManager;
            _mapper = mapper;
            _jwtService = jwtService;
            _refreshTokenRepository = refreshTokenRepository;
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

                throw new HttpException(HttpStatusCode.BadRequest, messageBuilder.ToString());
            }
        }

        public async Task<UserAutorizationDTO> LoginAsync(UserLoginDTO data)
        {
            var user = await _userManager.FindByEmailAsync(data.Email);

            if (user == null || !await _userManager.CheckPasswordAsync(user, data.Password))
            {
                throw new HttpException(HttpStatusCode.Unauthorized, ErrorMessages.IncorrectLoginOrPassword);
            }

            return await GenerateUserTokens(user);
        }

        private async Task<UserAutorizationDTO> GenerateUserTokens(User user)
        {
            var claims = _jwtService.SetClaims(user);
            var token = _jwtService.CreateToken(claims);
            var refreshToken = await CreateRefreshToken();

            var tokens = new UserAutorizationDTO()
            {
                Token = token,
                RefreshToken = refreshToken
            };

            return tokens;
        }

        private async Task<string> CreateRefreshToken()
        {
            var refeshTokenEntity = _jwtService.GenerateRefreshToken();

            await _refreshTokenRepository.UpdateAsync(refeshTokenEntity);
            await _refreshTokenRepository.SaveChangesAsync();

            return refeshTokenEntity.Token;
        }

        public async Task<UserAutorizationDTO> RefreshTokenAsync(UserAutorizationDTO userTokensDTO)
        {
            var userFromDB = getUserByRefreshToken(userTokensDTO.RefreshToken);
            var refeshTokenFromDb = userFromDB.RefreshTokens.FirstOrDefault();

            var claims = _jwtService.GetClaimsFromExpiredToken(userTokensDTO.Token);
            var newToken = _jwtService.CreateToken(claims);
            var newRefreshToken = await CreateRefreshToken();

            refeshTokenFromDb.Token = newRefreshToken;
            await _refreshTokenRepository.UpdateAsync(refeshTokenFromDb);
            await _refreshTokenRepository.SaveChangesAsync();

            var tokens = new UserAutorizationDTO()
            {
                Token = newToken,
                RefreshToken = newRefreshToken
            };

            return tokens;
        }

        private User getUserByRefreshToken(string token)
        {
            var user = _refreshTokenRepository.Query().Where(t => t.Token == token).FirstOrDefault().User;

            if (user == null)
                throw new HttpException(HttpStatusCode.NotFound, ErrorMessages.InvalidToken);

            return user;
        }
    }
}
