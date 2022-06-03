using Core.DTO.EmailDTO;
using FluentValidation;

namespace Core.Validation
{
    public class EmailConfirmationRequestValidation : AbstractValidator<EmailConfirmationRequestDTO>
    {
        public EmailConfirmationRequestValidation()
        {
            RuleFor(x => x.Token)
                .NotEmpty()
                .NotNull()
                .WithMessage("Token is null !");
            RuleFor(x => x.Email)
                .EmailAddress()
                .WithMessage("Invalid email!");
        }
    }
}
