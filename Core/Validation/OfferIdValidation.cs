using Core.DTO.OfferDTO;
using FluentValidation;

namespace Core.Validation
{
    public class OfferIdValidation : AbstractValidator<OfferIdDTO>
    {
        public OfferIdValidation()
        {
            RuleFor(o => o.OfferId)
                .GreaterThan(0);
        }
    }
}
