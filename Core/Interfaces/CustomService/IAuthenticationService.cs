using Core.DTO.UserDTO;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface IAuthenticationService
    {
        Task RegisterAsync(UserRegistrationDTO data);
        Task LoginAsync(UserLoginDTO data);
    }
}
