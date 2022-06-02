using AutoMapper;
using Core.Constants;
using Core.DTO;
using Core.Entities.UserEntity;
using Core.Exceptions;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Core.Resources;
using Core.Specifications;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
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
            var user = await _userRepository.GetByIdAsync(userId);

            ExceptionMethods.UserNullCheck(user);

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
            var updateUser = await _userRepository.GetByIdAsync(userId);
            ExceptionMethods.UserNullCheck(updateUser);

            updateUser.Name = userEditProfileInfo.Name;
            updateUser.Surname = userEditProfileInfo.Surname;
            if (!userEditProfileInfo.Email.Equals(updateUser.Email))
            {
                if (await _userRepository.AnyAsync(new UserSpecification.GetByEmail(userEditProfileInfo.Email)))
                {
                    throw new HttpException(ErrorMessages.EmailAlreadyExists, HttpStatusCode.BadRequest);
                }

                updateUser.Email = userEditProfileInfo.Email;
                updateUser.UserName = userEditProfileInfo.Email;
                updateUser.NormalizedEmail = userEditProfileInfo.Email.ToUpper();
                updateUser.NormalizedUserName = userEditProfileInfo.Email.ToUpper();

                updateUser.EmailConfirmed = false;
            }
            await _userRepository.UpdateAsync(updateUser);
        }

        public async Task<UserFullNameDTO> GetUserFullNameAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);

            ExceptionMethods.UserNullCheck(user);

            return _mapper.Map<UserFullNameDTO>(user);
        }

        public async Task<List<UserDTO>> GetAllUsersAsync()
        {
            var usersList = await _userManager.GetUsersInRoleAsync(IdentityRoleNames.User.ToString());

            if (!usersList.Any())
            {
                return null;
            }

            return _mapper.Map<List<UserDTO>>(usersList);
        }
    }
}
