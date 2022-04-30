using Core.DTO.UserDTO;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface IUserService
    {
        Task<UserProfileInfoDTO> GetUserProfileInfoAsync(HttpRequest request);
    }
}
