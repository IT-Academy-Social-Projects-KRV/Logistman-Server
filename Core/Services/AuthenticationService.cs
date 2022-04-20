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

namespace Core.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        public AuthenticationService(UserManager<User> userManager,IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task RegisterAsync(UserRegistrationDTO userData)
        {
            var result = await _userManager.CreateAsync(_mapper.Map<User>(userData), userData.Password);

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

        public async Task LoginAsync(UserLoginDTO data)
        {
            var user = await _userManager.FindByEmailAsync(data.Email);
            if (user == null || !await _userManager.CheckPasswordAsync(user, data.Password))
            {
                throw new HttpException(HttpStatusCode.Unauthorized, ErrorMessages.IncorrectLoginOrPassword);
            }
        }
    }
}
