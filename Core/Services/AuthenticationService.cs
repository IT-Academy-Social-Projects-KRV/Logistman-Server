using AutoMapper;
using Core.DTO.UserDTO;
using Core.Entities.UserEntity;
using Core.Exceptions;
using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Identity;
using System.Net;
using System.Threading.Tasks;
using Core.Resources;
using Core.Interfaces;
using Core.Entities.RefreshTokenEntity;
using Microsoft.Extensions.Options;
using Core.Helpers;
using Core.Specifications;

namespace Core.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly IJwtService _jwtService;
        private readonly IRoleService _roleService;
        private readonly IUserService _userService;
        private readonly IRepository<RefreshToken> _refreshTokenRepository;
        private readonly IOptions<RolesOptions> _rolesOptions;

        public AuthenticationService(
            UserManager<User> userManager,
            IMapper mapper,
            IJwtService jwtService,
            IRoleService roleService,
            IUserService userService,
            IRepository<RefreshToken> refreshTokenRepository,
            IOptions<RolesOptions> rolesOptions)
        {
            _userManager = userManager;
            _mapper = mapper;
            _jwtService = jwtService;
            _roleService = roleService;
            _userService = userService;
            _refreshTokenRepository = refreshTokenRepository;
            _rolesOptions = rolesOptions;
        }

        public async Task RegisterAsync(UserRegistrationDTO userData)
        {
            var user = _mapper.Map<User>(userData);
            var createUserResult = await _userManager.CreateAsync(user, userData.Password);

            ExceptionMethods.CheckIdentityResult(createUserResult);

            var roleName = _rolesOptions.Value.User;
            var userRole = await _roleService.GetIdentityRoleByNameAsync(roleName);
            var addToRoleResult = await _userManager.AddToRoleAsync(user, userRole.Name);

            ExceptionMethods.CheckIdentityResult(addToRoleResult);
        }

        public async Task<UserAutorizationDTO> LoginAsync(UserLoginDTO data)
        {
            var user = await _userManager.FindByEmailAsync(data.Email);

            if (user == null || !await _userManager.CheckPasswordAsync(user, data.Password))
            {
                throw new HttpException(ErrorMessages.IncorrectLoginOrPassword, HttpStatusCode.Unauthorized);
            }

            var userRole = await _userService.GetUserRoleAsync(user);

            return await GenerateUserTokens(user, userRole);
        }

        public async Task LogoutAsync(UserLogoutDTO userLogoutDTO)
        {
            var refreshToken = await _refreshTokenRepository
                .GetBySpecAsync(new GetRefreshTokenByToken(userLogoutDTO.RefreshToken));

            ExceptionMethods.RefreshTokenNullCheck(refreshToken);

            await _refreshTokenRepository.DeleteAsync(refreshToken);
            await _refreshTokenRepository.SaveChangesAsync();
        }

        private async Task<UserAutorizationDTO> GenerateUserTokens(User user, string userRole)
        {
            var claims = _jwtService.SetClaims(user, userRole);
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

            await _refreshTokenRepository.AddAsync(refreshTokenEntity);
            await _refreshTokenRepository.SaveChangesAsync();

            return refreshTokenEntity;
        }

        public async Task<UserAutorizationDTO> RefreshTokenAsync(UserAutorizationDTO userTokensDTO)
        {
            var refreshToken = await _refreshTokenRepository
                .GetBySpecAsync(new GetRefreshTokenByToken(userTokensDTO.RefreshToken));

            ExceptionMethods.RefreshTokenNullCheck(refreshToken);

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
    }
}
