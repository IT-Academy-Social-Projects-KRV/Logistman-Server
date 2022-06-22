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

            RuleFor(i => i.OffersId.Count)
                .GreaterThan(0);
        }
    }
}
