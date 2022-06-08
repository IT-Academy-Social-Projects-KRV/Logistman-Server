using Core.DTO.EmailDTO;
using Core.Entities.UserEntity;
using Core.Exceptions;
using Core.Helpers;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Core.Resources;
using Core.Specifications;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Core.Services
{
    public class EmailService : IEmailService
    {
        private readonly ITemplateHelper _templateHelper;
        private readonly UserManager<User> _userManager;
        private readonly AppSettings _appSettings;
        private readonly IRepository<User> _userRepository;

        public EmailService(
            ITemplateHelper templateHelper,
            UserManager<User> userManager,
            IOptions<AppSettings> appSettings,
            IRepository<User> userRepository)
        {
            _templateHelper = templateHelper;
            _userManager = userManager;
            _appSettings = appSettings.Value;
            _userRepository = userRepository;
        }

        public async Task SendConfirmationEmailAsync(User user, string callbackUrl)
        {
            user.ConfirmationEmailToken = await _userManager
                .GenerateEmailConfirmationTokenAsync(user);
            user.ConfirmationEmailTokenExpirationDate = DateTimeOffset.UtcNow + TimeSpan.FromDays(1);

            await _userManager.UpdateAsync(user);

            if (!callbackUrl.Contains("swagger"))
            {
                var message = await _templateHelper
            .GetTemplateHtmlAsStringAsync<ConfirmationEmailDTO>(
            "ConfirmationEmail",
            new ConfirmationEmailDTO
            {
                Name = user.Name,
                Surname = user.Surname,
                Link = callbackUrl + "confirm-email/" +
                       user.ConfirmationEmailToken + "/"
            });

                await SendEmailAsync(user.Email, "Confirm your account", message);
            }
        }

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var client = new SendGridClient(_appSettings.SendGridKey);
            var from = new EmailAddress(
                _appSettings.SendGridEmail, 
                _appSettings.SendGridSenderName);
            var to = new EmailAddress(email, email);
            var plainTextContent = "";
            var msg = MailHelper
                .CreateSingleEmail(from, to, subject, plainTextContent, message);

            var result = await client.SendEmailAsync(msg);

            if (!result.IsSuccessStatusCode)
            {
                throw new HttpException(
                    ErrorMessages.FailedSendEmail,
                    HttpStatusCode.InternalServerError);
            }
        }

        public async Task ConfirmEmailAsync(EmailConfirmationTokenRequestDTO request)
        {
            var user = await _userRepository.GetBySpecAsync(
                new UserSpecification.GetByConfirmationToken(request.Token));

            ExceptionMethods.UserNullCheck(user);

            if (user.ConfirmationEmailTokenExpirationDate > DateTimeOffset.UtcNow)
            {
                var confirm = await _userManager
                    .ConfirmEmailAsync(user, request.Token);

                if (!confirm.Succeeded)
                {
                    throw new HttpException(
                        ErrorMessages.FailedSendEmail, 
                        HttpStatusCode.BadRequest);
                }

                user.ConfirmationEmailToken = null;
                user.ConfirmationEmailTokenExpirationDate = null;

                await _userManager.UpdateAsync(user);
            }
            else
            {
                throw new HttpException(
                    ErrorMessages.FailedSendEmail, 
                    HttpStatusCode.BadRequest);
            }
        }
    }
}
