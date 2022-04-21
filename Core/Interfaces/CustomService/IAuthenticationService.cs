using Core.DTO.UserDTO;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface IAuthenticationService
    {
        Task<UserAutorizationDTO> RegisterAsync(UserRegistrationDTO data);
    }
}
