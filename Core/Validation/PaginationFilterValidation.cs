using Core.DTO;
using FluentValidation;

namespace Core.Validation
{
    public class PaginationFilterValidation : AbstractValidator<PaginationFilterDTO>
    {
        public PaginationFilterValidation()
        {
            RuleFor(pf => pf.PageNumber)
                .NotEmpty()
                .GreaterThan(0);

            RuleFor(pf => pf.PageSize)
                .NotEmpty()
                .GreaterThan(0);
        }
    }
}
