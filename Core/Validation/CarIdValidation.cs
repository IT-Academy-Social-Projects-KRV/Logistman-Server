using Core.DTO;
using FluentValidation;

namespace Core.Validation
{
    public class CarIdValidation : AbstractValidator<CarIdDTO>
    {
        public CarIdValidation()
        {
            RuleFor(c => c.CarId)
                .GreaterThan(0);
        }
    }
}
