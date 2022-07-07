using Core.DTO.TripDTO;
using FluentValidation;

namespace Core.Validation
{
    public class ManageTripValidation : AbstractValidator<ManageTripDTO>
    {
        public ManageTripValidation()
        {
            RuleFor(trip => trip.Distance)
                .NotEmpty()
                .GreaterThan(0);

            RuleFor(trip => trip.TotalWeight)
                .NotEmpty()
                .GreaterThan(0);

            RuleFor(trip => trip.OffersId)
                .NotEmpty()
                .SetValidator(new OfferIdsValidation());

            RuleFor(trip => trip.PointsTrip)
                .NotEmpty()
                .SetValidator(new PointsTripValidation());

            RuleFor(trip => trip.TripId)
                .NotEmpty()
                .GreaterThan(0);
        }
    }
}
