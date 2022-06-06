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
using System;
using System.Net;
using System.Threading.Tasks;
using Core.Specifications;
using Microsoft.EntityFrameworkCore;

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
        public async Task SendConfirmationEmailAsync(User user)
        {
            user.ConfirmEmailToken = await _userManager
                .GenerateEmailConfirmationTokenAsync(user);
            user.ConfirmEmailTokenExpirationDate = DateTimeOffset.Now + TimeSpan.FromDays(7);

            var message = await _templateHelper
                .GetTemplateHtmlAsStringAsync<ConfirmationEmailDTO>(
                "ConfirmationEmail",
                new ConfirmationEmailDTO
                {
                    Name = user.Name,
                    Surname = user.Surname,
                    Link = StringConstants.EmailConfirmationCallbackUrl + "/" +
                           user.ConfirmEmailToken /*+ "/" + user.Email*/
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
                    ErrorMessages.EmailNotConfirm, 
                    HttpStatusCode.InternalServerError);
            }
        }
        public async Task ConfirmEmailAsync(EmailConfirmationRequestDTO request)
        {
            var user = await _userRepository.GetBySpecAsync(new UserSpecification.GetByConfirmToken(request.Token));

            ExceptionMethods.UserNullCheck(user);

            if (user.ConfirmEmailTokenExpirationDate > DateTimeOffset.Now)
            {
                await _userManager.ConfirmEmailAsync(user, request.Token);
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
