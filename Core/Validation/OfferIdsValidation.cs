using System.Collections.Generic;
using System.Linq;
using FluentValidation;

namespace Core.Validation
{
    public class OfferIdsValidation : AbstractValidator<List<int>>
    {
        public OfferIdsValidation()
        {
            RuleFor(id => id)
                .Must(list => !list.Any(id => id < 0))
                .WithMessage("Offer Id must be greater than 0!");
        }
    }
}
