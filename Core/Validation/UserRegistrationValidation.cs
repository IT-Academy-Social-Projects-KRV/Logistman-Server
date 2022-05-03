using System.Threading;
using System.Threading.Tasks;
using Core.DTO.UserDTO;
using Core.Entities.UserEntity;
using FluentValidation;
using Microsoft.AspNetCore.Identity;

namespace Core.Validation
{
    public class UserRegistrationValidation : AbstractValidator<UserRegistrationDTO>
    {
        protected readonly UserManager<User> _userManager;

        public UserRegistrationValidation(UserManager<User> userManager)
        {
            _userManager = userManager;

            RuleFor(user => user.Name)
                .NotEmpty().WithMessage("'{PropertyName}' must not be empty!")
                .Length(2, 50).WithMessage("'{PropertyName}' must be between 2 and 50 letters!")
                .Matches(@"^[A-Z][a-z]+$").WithMessage("The first letter in '{PropertyName}' must be uppercase, the others lowercase! And only in Latin letters!");

            RuleFor(user => user.Surname)
                .NotEmpty().WithMessage("'{PropertyName}' must not be empty!")
                .Length(2, 50).WithMessage("'{PropertyName}' must be between 2 and 50 letters!")
                .Matches(@"^[A-Z][a-z]+$").WithMessage("The first letter in '{PropertyName}' must be uppercase, the others lowercase! And only in Latin letters!");

            RuleFor(user => user.Email)
                .NotEmpty().WithMessage("'{PropertyName}' must not be empty!")
                .EmailAddress().WithMessage("'{PropertyValue}' - is not an email address!")
                .MustAsync(IsUniqueUserEmail).WithMessage("A user with this email ('{PropertyValue}') is already registered!");

            RuleFor(user => user.Password)
                .NotEmpty().WithMessage("'{PropertyName}' must not be empty!")
                .Length(8, 50).WithMessage("'{PropertyName}' must be between 8 and 50 letters!")
                .Matches("[A-Z]").WithMessage("'{PropertyName}' must contain one or more uppercase letters!")
                .Matches("[a-z]").WithMessage("'{PropertyName}' must contain one or more lowercase letters!")
                .Matches(@"\d").WithMessage("'{PropertyName}' must contain one or more digits!")
                .Matches(@"[][""!@$%^&*(){}:;<>,.?/+_=|'~\\-]").WithMessage("'{PropertyName}' must contain one or more special characters!")
                .Matches("^[^£# “”]*$").WithMessage("'{PropertyName}' must not contain the following characters £ # “” or spaces!");
        }

        private async Task<bool> IsUniqueUserEmail(string email, CancellationToken cancellationToken)
        {
            var userEntity = await _userManager.FindByEmailAsync(email);
            return userEntity == null;
        }
    }
}
