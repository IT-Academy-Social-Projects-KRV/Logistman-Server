using Core.Helpers;
using FluentValidation;

namespace Core.Validation
{
    public class PaginationFilterValidation : AbstractValidator<PaginationFilter>
    {
        public PaginationFilterValidation()
        {
            RuleFor(pf => pf.PageNumber)
                .NotNull()
                .GreaterThan(0).WithMessage("'{PropertyName}' should be greater than 0");

            RuleFor(pf => pf.PageSize)
                .NotNull()
                .GreaterThan(0).WithMessage("'{PropertyName}' should be greater than 0");
        }
    }
}
