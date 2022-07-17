using Core.DTO;
using FluentValidation;

namespace Core.Validation
{
    public class UserLoginValidation : AbstractValidator<UserLoginDTO>
    {
        public UserLoginValidation()
        {
            RuleFor(user => user.Email)
                .NotEmpty().WithMessage("'{PropertyName}' must not be empty!")
                .EmailAddress().WithMessage("'{PropertyValue}' - is not an email address!");

            RuleFor(user => user.Password)
                .NotEmpty().WithMessage("'{PropertyName}' must not be empty!");
        }
    }
}
