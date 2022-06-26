using Core.DTO;
using Core.Entities.UserEntity;
using Core.Helpers;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface IUserService
    {
        Task<UserProfileInfoDTO> GetUserProfileInfoAsync(string userId);
        string GetCurrentUserNameIdentifier(ClaimsPrincipal currentUser);
        Task<string> GetUserRoleAsync(User user);
        Task UserEditProfileInfoAsync(UserEditProfileInfoDTO userEditProfileInfo, string userId, string callbackUrl);
        Task<UserFullNameDTO> GetUserFullNameAsync(string userId);
        Task<string> GetUserIdByEmailAsync(string email);
        Task<PaginatedList<UserDTO>> GetAllUsersAsync(PaginationFilterDTO paginationFilter);
        Task DeleteUserAsync(string userId);
    }
}
