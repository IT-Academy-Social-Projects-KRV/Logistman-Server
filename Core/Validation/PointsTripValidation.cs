using System.Collections.Generic;
using System.Linq;
using Core.DTO;
using FluentValidation;

namespace Core.Validation
{
    public class PointsTripValidation : AbstractValidator<List<PointsTripDTO>>
    {
        public PointsTripValidation()
        {
            RuleFor(points => points)
                .Must(points => !points.Any(point => point.Order < 0))
                .WithMessage("Order must be greater than 0!")
                .Must(points => !points.Any(point => point.PointId < 0))
                .WithMessage("Point Id must be greater than 0!");
        }
    }
}
