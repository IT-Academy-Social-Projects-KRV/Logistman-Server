using Core.DTO.TripDTO;
using FluentValidation;
using System;

namespace Core.Validation
{
    public class TripCreateValidation : AbstractValidator<CreateTripDTO>
    {
        private readonly TimeSpan _hour = new TimeSpan(12, 0, 0);
        public TripCreateValidation()
        {
            RuleFor(offer => offer.StartDate)
                .NotEmpty()
                .Must(date => date >= DateTimeOffset.UtcNow)
                .WithMessage("Start date cannot be earlier than the current time!");

            RuleFor(offer => offer.ExpirationDate.Subtract(offer.StartDate) < _hour)
                .Must(date => !date)
                .WithMessage(
                    $"The difference between the start date and the expiration date must be at least {_hour.Hours} hours!");

            RuleFor(offer => offer.Description)
                .MinimumLength(1)
                .MaximumLength(1000)
                .WithMessage("The description must be between 1 and 1000 symbols!");

            RuleFor(offer => offer.LoadCapacity)
                .GreaterThan(0)
                .WithMessage("Load capacity must be greater than 0!");

            RuleFor(offer => offer.MaxRouteDeviationKm)
                .InclusiveBetween(1, 25)
                .WithMessage("Max route deviation must be greater than 0 and less than 25 km!");

            RuleFor(offer => offer.TransportationCarId)
                .GreaterThan(0)
                .WithMessage("Transportation car id must be greater than 0!");
        }
    }
}
