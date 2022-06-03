using System.Net;
using System.Threading.Tasks;
using Core.Constants;
using Core.DTO.EmailDTO;
using Core.Entities.UserEntity;
using Core.Exceptions;
using Core.Helpers;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Core.Resources;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Core.Services
{
    public class EmailService : IEmailService
    {
        private readonly ITemplateHelper _templateHelper;
        private readonly UserManager<User> _userManager;
        private readonly AppSettings _appSettings;
        public EmailService(
            ITemplateHelper templateHelper,
            UserManager<User> userManager,
            IOptions<AppSettings> appSettings)
        {
            _templateHelper = templateHelper;
            _userManager = userManager;
            _appSettings = appSettings.Value;
        }
        public async Task SendConfirmationEmailAsync(User user)
        {
            var confirmationToken = await _userManager.GenerateEmailConfirmationTokenAsync(user);

            var message = await _templateHelper.GetTemplateHtmlAsStringAsync<ConfirmationEmailDTO>(
                "ConfirmationEmail",
                new ConfirmationEmailDTO
                {
                    Name = user.Name,
                    Surname = user.Surname,
                    Link = StringConstants.EmailConfirmationCallbackUrl + "/" + confirmationToken + "/" + user.Email
                });

            await SendEmailAsync(user.Email, "Confirm your account", message);
        }
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var client = new SendGridClient(_appSettings.SendGridKey);
            var from = new EmailAddress(_appSettings.SendGridEmail, _appSettings.SendGridSenderName);
            var to = new EmailAddress(email, email);
            var plainTextContent = "";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, message);

            var result = await client.SendEmailAsync(msg);

            if (!result.IsSuccessStatusCode)
            {
                throw new HttpException(ErrorMessages.TripNotFound, HttpStatusCode.InternalServerError);
            }
        }
        public async Task ConfirmEmailAsync(EmailConfirmationRequestDTO request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);

            await _userManager.ConfirmEmailAsync(user, request.Token);
        }
    }
}
