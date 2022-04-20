using Core.DTO;
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
        public AuthenticationService(UserManager<User> userManager)
        {
            _userManager = userManager;
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
