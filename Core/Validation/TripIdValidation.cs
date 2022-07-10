using Core.DTO.TripDTO;
using FluentValidation;

namespace Core.Validation
{
    public class TripIdValidation : AbstractValidator<TripIdDTO>
    {
        public TripIdValidation()
        {
            RuleFor(t => t.TripId)
                .GreaterThan(0);
        }
    }
}
