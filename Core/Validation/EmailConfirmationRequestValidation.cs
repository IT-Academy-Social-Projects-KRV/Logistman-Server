using Core.DTO.EmailDTO;
using FluentValidation;

namespace Core.Validation
{
    public class EmailConfirmationRequestValidation : AbstractValidator<EmailConfirmationTokenRequestDTO>
    {
        public EmailConfirmationRequestValidation()
        {
            RuleFor(x => x.Token)
                .NotEmpty()
                .NotNull()
                .WithMessage("Token is null !");
        }
    }
}
