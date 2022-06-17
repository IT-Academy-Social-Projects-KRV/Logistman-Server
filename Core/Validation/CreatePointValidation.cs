using Core.DTO;
using FluentValidation;

namespace Core.Validation
{
    public class CreatePointValidation : AbstractValidator<PointDTO>
    {
        public CreatePointValidation()
        {
            RuleFor(point => point.Latitude)
                .NotNull()
                .InclusiveBetween(-90, 90)
                .WithMessage("'{PropertyName}' must be between -90 & 90!");

            RuleFor(point => point.Longitude)
                .NotNull()
                .InclusiveBetween(-180, 180)
                .WithMessage("'{PropertyName}' must be between -180 & 180!");

            RuleFor(point => point.Address)
                .Length(0, 100)
                .WithMessage("'{PropertyName}' must not exceed 100 characters!");

            RuleFor(point => point.Settlement)
                .Length(0, 100)
                .WithMessage("'{PropertyName}' must not exceed 100 characters!");

            RuleFor(point => point.Region)
                .Length(0, 100)
                .WithMessage("'{PropertyName}' must not exceed 100 characters!");

            RuleFor(point => point.Country)
                .Length(0, 100)
                .WithMessage("'{PropertyName}' must not exceed 100 characters!");

            RuleFor(point => point.Postcode)
                .Length(0, 20)
                .WithMessage("'{PropertyName}' must not exceed 20 characters!");

            RuleFor(point => point.Order)
                .NotEmpty()
                .GreaterThanOrEqualTo(1)
                .WithMessage("'{PropertyName}' must be greater than or equal to 1!");
        }
    }
}
