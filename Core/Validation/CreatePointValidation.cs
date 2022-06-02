using Core.DTO;
using FluentValidation;

namespace Core.Validation
{
    public class CreatePointValidation : AbstractValidator<PointDTO>
    {
        public CreatePointValidation()
        {
            RuleFor(point => point.Latitude)
                .GreaterThanOrEqualTo(0)
                .WithMessage("'{PropertyName}' must be greater than or equal to 0!");

            RuleFor(point => point.Longitude)
                .GreaterThanOrEqualTo(0)
                .WithMessage("'{PropertyName}' must be greater than or equal to 0!");

            RuleFor(point => point.Address)
                .Length(1, 100)
                .WithMessage("'{PropertyName}' must not exceed 100 characters!");

            RuleFor(point => point.Settlement)
                .Length(1, 100)
                .WithMessage("'{PropertyName}' must not exceed 100 characters!");

            RuleFor(point => point.Region)
                .Length(1, 100)
                .WithMessage("'{PropertyName}' must not exceed 100 characters!");

            RuleFor(point => point.Order)
                .GreaterThanOrEqualTo(0)
                .WithMessage("'{PropertyName}' must be greater than or equal to 0!");
        }
    }
}
