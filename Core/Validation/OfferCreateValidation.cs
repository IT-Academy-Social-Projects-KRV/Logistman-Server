using Core.DTO.OfferDTO;
using FluentValidation;

namespace Core.Validation
{
    public class OfferCreateValidation : AbstractValidator<OfferCreateDTO>
    {
        public OfferCreateValidation()
        {
            RuleFor(offer => offer.GoodsWeight)
                .GreaterThan(0);
            RuleFor(offer => offer.Point)
                .NotNull();
            RuleFor(offer => offer.Point.Latitude)
                .NotEmpty();

            RuleFor(offer => offer.Point.Longitude)
                .NotEmpty();

            RuleFor(offer => offer.Point.Address)
                .NotEmpty()
                .MaximumLength(100);

            RuleFor(offer => offer.Point.Settlement)
                .NotEmpty()
                .MaximumLength(100);

            RuleFor(offer => offer.Point.Region)
                .NotEmpty()
                .MaximumLength(100);

            RuleFor(offer => offer.Point.Order)
                .GreaterThan(-1);
        }
    }
}
