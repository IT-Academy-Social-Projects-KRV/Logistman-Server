using Core.DTO.PointDTO;
using FluentValidation;

namespace Core.Validation
{
    public class PointCreateValidation : AbstractValidator<PointInfoDTO>
    {
        public PointCreateValidation()
        {
            RuleFor(point => point.Latitude)
                .NotEmpty();

            RuleFor(point => point.Longitude)
                .NotEmpty();

            RuleFor(point => point.Address)
                .NotEmpty()
                .MaximumLength(100);

            RuleFor(point => point.Settlement)
                .NotEmpty()
                .MaximumLength(100);

            RuleFor(point => point.Region)
                .NotEmpty()
                .MaximumLength(100);

            RuleFor(point => point.Order)
                .GreaterThan(-1);
        }
    }
}
