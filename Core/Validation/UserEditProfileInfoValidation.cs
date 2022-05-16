using Core.DTO.UserDTO;
using FluentValidation;

namespace Core.Validation
{
    public class UserEditProfileInfoValidation : AbstractValidator<UserEditProfileInfoDTO>
    {
        public UserEditProfileInfoValidation()
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

        }        
    }
}
