using Core.DTO;
using FluentValidation;

namespace Core.Validation
{
    public class CreatePointValidation : AbstractValidator<PointDTO>
    {
        public CreatePointValidation()
        {
            RuleFor(point => point.Latitude)
                .NotEmpty()
                .InclusiveBetween(-90, 90)
                .WithMessage("'{PropertyName}' must be between -90 & 90!");

            RuleFor(point => point.Longitude)
                .NotEmpty()
                .InclusiveBetween(-180, 180)
                .WithMessage("'{PropertyName}' must be between -180 & 180!");

            RuleFor(point => point.Address)
                .NotEmpty()
                .Length(1, 100)
                .WithMessage("'{PropertyName}' must not exceed 100 characters!");

            RuleFor(point => point.Settlement)
                .NotEmpty()
                .Length(1, 100)
                .WithMessage("'{PropertyName}' must not exceed 100 characters!");

            RuleFor(point => point.Region)
                .NotEmpty()
                .Length(1, 100)
                .WithMessage("'{PropertyName}' must not exceed 100 characters!");

            RuleFor(point => point.Order)
                .NotEmpty()
                .GreaterThanOrEqualTo(0)
                .WithMessage("'{PropertyName}' must be greater than or equal to 0!");
        }
    }
}
