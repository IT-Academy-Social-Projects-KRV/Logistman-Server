using Core.DTO.UserDTO;
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
                .NotEmpty().WithMessage("'{PropertyName}' must not be empty!")
                .Length(8, 50).WithMessage("'{PropertyName}' must be between 8 and 50 letters!")
                .Matches("[A-Z]").WithMessage("'{PropertyName}' must contain one or more uppercase letters!")
                .Matches("[a-z]").WithMessage("'{PropertyName}' must contain one or more lowercase letters!")
                .Matches(@"\d").WithMessage("'{PropertyName}' must contain one or more digits!")
                .Matches(@"[][""!@$%^&*(){}:;<>,.?/+_=|'~\\-]").WithMessage("'{PropertyName}' must contain one or more special characters!")
                .Matches("^[^£# “”]*$").WithMessage("'{PropertyName}' must not contain the following characters £ # “” or spaces!");
        }
    }
}
