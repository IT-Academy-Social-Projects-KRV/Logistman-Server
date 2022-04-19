using Core.DTO;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface IAuthenticationService
    {
        Task RegisterAsync(UserRegistrationDTO data);
        Task<AuthenticationResultDTO> LoginAsync(string email, string password);

    }
}
