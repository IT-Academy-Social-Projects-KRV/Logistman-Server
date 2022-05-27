using Core.DTO.UserDTO;
using FluentValidation;

namespace Core.Validation
{
    public class UserAuthenficationValidation : AbstractValidator<UserAutorizationDTO>
    {
        public UserAuthenficationValidation()
        {
            RuleFor(userAuth => userAuth.RefreshToken)
                .NotEmpty().WithMessage("{PropertyName} must not be empty!");

            RuleFor(userAuth => userAuth.AccessToken)
                .NotEmpty().WithMessage("{PropertyName} must not be empty!");
        }
    }
}
