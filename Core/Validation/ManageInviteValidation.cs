using Core.DTO.InviteDTO;
using FluentValidation;

namespace Core.Validation
{
    public class ManageInviteValidation : AbstractValidator<ManageInviteDTO>
    {
        public ManageInviteValidation()
        {
            RuleFor(i => i.InviteId)
                .GreaterThan(0);
        }
    }
}
