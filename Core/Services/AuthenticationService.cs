using AutoMapper;
using Core.DTO.UserDTO;
using Core.Entities.UserEntity;
using Core.Exceptions;
using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Identity;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        protected readonly IJwtService _jwtService;
        public AuthenticationService(
            UserManager<User> userManager,
            IMapper mapper,
            IJwtService jwtService)
        {
            _userManager = userManager;
            _mapper = mapper;
            _jwtService = jwtService;
        }

        public async Task<UserAutorizationDTO> RegisterAsync(UserRegistrationDTO userData)
        {
            var user = _mapper.Map<User>(userData);
            var result = await _userManager.CreateAsync(user, userData.Password);

            if (!result.Succeeded)
            {
                StringBuilder messageBuilder = new StringBuilder();

                foreach (var error in result.Errors)
                {
                    messageBuilder.AppendLine(error.Description);
                }

                throw new HttpException(HttpStatusCode.BadRequest, messageBuilder.ToString());
            }
            return await Task.Run(()=> GenerateUserTokens(user));
        }

        private UserAutorizationDTO GenerateUserTokens(User user)
        {
            var claims = _jwtService.SetClaims(user);

            var token = _jwtService.CreateToken(claims);

            var tokens = new UserAutorizationDTO()
            {
                Token = token
            };

            return tokens;
        }
    }
}
