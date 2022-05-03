using Core.DTO.UserDTO;
using FluentValidation;

namespace Core.Validation
{
    public class UserRegistrationValidation : AbstractValidator<UserRegistrationDTO>
    {
        public UserRegistrationValidation()
        {
            RuleFor(user => user.Name)
                .NotEmpty().WithMessage("'{PropertyName}' must not be empty!")
                .Length(2, 50).WithMessage("'{PropertyName}' must be between 2 and 50 letters!")
                .Matches(@"^[A-Z][a-z]+$").WithMessage("The first letter in '{PropertyName}'" +
                " must be uppercase, the others lowercase! And only in Latin letters!");

            RuleFor(user => user.Surname)
                .NotEmpty().WithMessage("'{PropertyName}' must not be empty!")
                .Length(2, 50).WithMessage("'{PropertyName}' must be between 2 and 50 letters!")
                .Matches(@"^[A-Z][a-z]+$").WithMessage("The first letter in '{PropertyName}'" +
                " must be uppercase, the others lowercase! And only in Latin letters!");

            RuleFor(user => user.Email)
                .NotEmpty().WithMessage("'{PropertyName}' must not be empty!")
                .EmailAddress().WithMessage("'{PropertyValue}' - is not an email address!");

            RuleFor(user => user.Password)
                .NotEmpty().WithMessage("'{PropertyName}' must not be empty!")
                .Length(8, 50).WithMessage("'{PropertyName}' must be between 8 and 50 letters!")
                .Matches("^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@$%^&*(){}:;<>,.?+_=|'~\\-])" +
                "[A-Za-z0-9!@$%^&*(){}:;<>,.?+_=|'~\\-]*$").WithMessage("Password must contain" +
                " one or more uppercase and lowercase letters, one or more digits" +
                " and special characters!");
        }
    }
}
