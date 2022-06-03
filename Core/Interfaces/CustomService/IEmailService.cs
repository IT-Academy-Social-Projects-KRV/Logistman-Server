using System.Threading.Tasks;
using Core.DTO.EmailDTO;
using Core.Entities.UserEntity;

namespace Core.Interfaces.CustomService
{
    public interface IEmailService
    {
        Task SendConfirmationEmailAsync(User user);
        Task SendEmailAsync(string email, string subject, string message);
        Task ConfirmEmailAsync(EmailConfirmationRequestDTO request);
    }
}
