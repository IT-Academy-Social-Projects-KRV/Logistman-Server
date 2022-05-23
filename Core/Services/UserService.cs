using AutoMapper;
using Core.DTO.UserDTO;
using Core.Entities.UserEntity;
using Core.Exceptions;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Core.Resources;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Core.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;

        public UserService(
            IRepository<User> userRepository,
            IMapper mapper,
            UserManager<User> userManager)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _userManager = userManager;
        }

        public string GetCurrentUserNameIdentifier(ClaimsPrincipal currentUser)
        {
            return currentUser.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public async Task<UserProfileInfoDTO> GetUserProfileInfoAsync(string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                throw new HttpException(ErrorMessages.UserIdNotFound, System.Net.HttpStatusCode.NotFound);
            }

            var user = await _userRepository.GetByIdAsync(userId);

            return _mapper.Map<UserProfileInfoDTO>(user);
        }

        public async Task<string> GetUserRoleAsync(User user)
        {
            var userRoles = await _userManager.GetRolesAsync(user);

            if (userRoles == null)
            {
                throw new HttpException(ErrorMessages.RoleNotFound, HttpStatusCode.NotFound);
            }

            return userRoles.First(); // we get only the first role, because the user will have only one
        }

        public async Task UserEditProfileInfoAsync(UserEditProfileInfoDTO userEditProfileInfo, string userId)
        {
            var updateUser = await _userManager.FindByIdAsync(userId);
            ExceptionMethods.UserNullCheck(updateUser);

            updateUser.Name = userEditProfileInfo.Name;
            updateUser.Surname = userEditProfileInfo.Surname;
            if (!userEditProfileInfo.Email.Equals(updateUser.Email))
            {
                if (_userManager.FindByEmailAsync(userEditProfileInfo.Email) == null)
                {
                    throw new HttpException(ErrorMessages.EmailAlreadyExists, HttpStatusCode.BadRequest);
                }
                await _userManager.SetEmailAsync(updateUser, userEditProfileInfo.Email);
                await _userManager.SetUserNameAsync(updateUser, userEditProfileInfo.Email);
                updateUser.EmailConfirmed = false;
            }
            await _userManager.UpdateAsync(updateUser);
        }
    }
}
