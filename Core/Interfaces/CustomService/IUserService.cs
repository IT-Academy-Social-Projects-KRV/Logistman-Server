using Core.DTO.UserDTO;
using Core.Entities.UserEntity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface IUserService
    {
        Task<UserProfileInfoDTO> GetUserProfileInfoAsync(string userId);
        string GetCurrentUserNameIdentifier(ClaimsPrincipal currentUser);
        Task<string> GetUserRoleAsync(User user);
        Task<UserEditProfileInfoDTO> UserEditProfileInfo(UserEditProfileInfoDTO userEditProfileInfo);
    }
}
