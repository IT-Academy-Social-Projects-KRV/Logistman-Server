using Core.DTO.OfferDTO;
using FluentValidation;

namespace Core.Validation
{
    public class TripCreatingValidation : AbstractValidator<OffersForTripDTO>
    {
        public TripCreatingValidation()
        {
            RuleFor(x => x.TripId)
                .NotEmpty()
                .GreaterThan(0);

            RuleFor(x => x.OffersIdList)
                .NotEmpty();
        }
    }
}
