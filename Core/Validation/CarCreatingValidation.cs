using Core.DTO.CarDTO;
using FluentValidation;

namespace Core.Validation
{
    public class CarCreatingValidation : AbstractValidator<CreateCarDTO>
    {
        public CarCreatingValidation()
        {
            RuleFor(car => car.Model)
                .NotEmpty()
                .Matches("^[a-zA-Z0-9 ]*$");
            RuleFor(car => car.Color)
                .NotEmpty()
                .Matches("^[a-zA-Z]*$");
            RuleFor(car => car.RegistrationNumber)
                .NotEmpty()
                .Matches("^[a-zA-Z0-9 ]*$");
            RuleFor(car => car.Vin)
                .NotEmpty()
                .Length(17)
                .Matches("^[a-zA-Z0-9]*$");
            RuleFor(car => car.TechnicalPassport)
                .NotEmpty()
                .Matches("^[a-zA-Z0-9]*$");
            RuleFor(car => car.LoadCapacity)
                .GreaterThan(0);
        }
    }
}
