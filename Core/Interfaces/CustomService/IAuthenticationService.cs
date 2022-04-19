using Core.DTO;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface IAuthenticationService
    {
        Task RegisterAsync(UserRegistrationDTO data);
        Task<AuthenticationResultDTO> LoginAsync(string email, string password);
        Task<AuthenticationResultDTO> RefreshTokenAsync(AuthenticationResultDTO userTokensDTO);
        Task LogoutAsync(AuthenticationResultDTO userTokensDTO);
        Task SentResetPasswordTokenAsync(string userEmail);
        //Task ResetPasswordAsync(AuthorChangePasswordDTO userChangePasswordDTO);

    }
}
