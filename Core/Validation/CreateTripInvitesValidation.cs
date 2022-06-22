using Core.DTO.InviteDTO;
using FluentValidation;

namespace Core.Validation
{
    public class CreateTripInvitesValidation : AbstractValidator<CreateTripInvitesDTO>
    {
        public CreateTripInvitesValidation()
        {
            RuleFor(i => i.TripId)
                .GreaterThan(0);

            RuleForEach(i => i.OffersId)
                .GreaterThan(0);
        }
    }
}
