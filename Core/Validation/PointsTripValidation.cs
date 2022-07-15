using System.Collections.Generic;
using System.Linq;
using Core.DTO;
using FluentValidation;

namespace Core.Validation
{
    public class PointsTripValidation : AbstractValidator<PointTripDTO>
    {
        public PointsTripValidation()
        {
            RuleFor(point => point.Id)
                .GreaterThan(0);
            RuleFor(point => point.Order)
                .GreaterThan(0);
        }
    }
}
