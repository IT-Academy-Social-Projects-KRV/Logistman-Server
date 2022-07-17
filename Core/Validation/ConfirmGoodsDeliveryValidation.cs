using Core.DTO.OfferDTO;
using FluentValidation;

namespace Core.Validation
{
    public class ConfirmGoodsDeliveryValidation : AbstractValidator<ConfirmGoodsTransferDTO>
    {
        public ConfirmGoodsDeliveryValidation()
        {
            RuleFor(confirmGoodsTransfer => confirmGoodsTransfer.TripRole)
                .NotEmpty();
            RuleFor(confirmGoodsTransfer => confirmGoodsTransfer.OfferId)
                .GreaterThan(0);
        }
    }
}
