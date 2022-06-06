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
        private readonly Links _links;
        private readonly IRepository<User> _userRepository;
        public EmailService(
            ITemplateHelper templateHelper,
            UserManager<User> userManager,
            IOptions<AppSettings> appSettings,
            IOptions<Links> links,
            IRepository<User> userRepository)
        {
            _templateHelper = templateHelper;
            _userManager = userManager;
            _appSettings = appSettings.Value;
            _userRepository = userRepository;
            _links = links.Value;
        }

        public async Task SendConfirmationEmailAsync(User user)
        {
            user.ConfirmEmailToken = await _userManager
                .GenerateEmailConfirmationTokenAsync(user);
            user.ConfirmEmailTokenExpirationDate = DateTimeOffset.UtcNow + TimeSpan.FromDays(7);

            await _userManager.UpdateAsync(user);

            var message = await _templateHelper
                .GetTemplateHtmlAsStringAsync<ConfirmationEmailDTO>(
                "ConfirmationEmail",
                new ConfirmationEmailDTO
                {
                    Name = user.Name,
                    Surname = user.Surname,
                    Link = _links.EmailConfirmationCallbackUrl + "/" +
                           user.ConfirmEmailToken + "/" 
                });

            await SendEmailAsync(user.Email, "Confirm your account", message);
        }

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var client = new SendGridClient(_appSettings.SendGridKey);
            var from = new EmailAddress(_appSettings.SendGridEmail, _appSettings.SendGridSenderName);
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
                new UserSpecification.GetByConfirmToken(request.Token));

            ExceptionMethods.UserNullCheck(user);

            if (user.ConfirmEmailTokenExpirationDate > DateTimeOffset.UtcNow)
            {
                var confirm = await _userManager.ConfirmEmailAsync(user, request.Token);

                if (!confirm.Succeeded)
                {
                    new HttpException(ErrorMessages.FailedSendEmail, HttpStatusCode.BadRequest);
                }

                user.ConfirmEmailToken = null;
                user.ConfirmEmailTokenExpirationDate = null;

                await _userManager.UpdateAsync(user);
            }
            else
            {
                new HttpException(ErrorMessages.FailedSendEmail, HttpStatusCode.BadRequest);
            }
        }
    }
}
