using Core.DTO.TripDTO;
using FluentValidation;
using System;

namespace Core.Validation
{
    public class CreateTripValidation : AbstractValidator<CreateTripDTO>
    {
        private readonly TimeSpan _hour = new TimeSpan(12, 0, 0);

        public CreateTripValidation()
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
                .WithMessage("'{PropertyName}' must be between 1 and 1000 symbols!");

            RuleFor(offer => offer.LoadCapacity)
                .GreaterThan(0)
                .WithMessage("Load capacity must be greater than 0!");

            RuleFor(offer => offer.MaxRouteDeviationKm)
                .InclusiveBetween(0, 25)
                .WithMessage("Max route deviation must be from 0 to 25km!");

            RuleFor(trip => trip.Points.Count)
                .GreaterThanOrEqualTo(2)
                .WithMessage("The trip must contain at least 2 points!");
        }
    }
}
