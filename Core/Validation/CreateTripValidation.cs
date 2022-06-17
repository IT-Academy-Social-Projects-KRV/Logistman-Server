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
            RuleFor(trip => trip.StartDate)
                .NotEmpty()
                .Must(date => date >= DateTimeOffset.UtcNow)
                .WithMessage("Start date cannot be earlier than the current time!");

            RuleFor(trip => trip.ExpirationDate.Subtract(trip.StartDate) < _hour)
                .Must(date => !date)
                .WithMessage(
                    $"The difference between the start date and the expiration date must be at least {_hour.Hours} hours!");

            RuleFor(trip => trip.Description)
                .MinimumLength(0)
                .MaximumLength(1000)
                .WithMessage("'{PropertyName}' must be between 0 & 1000 symbols!");

            RuleFor(trip => trip.LoadCapacity)
                .GreaterThan(0)
                .WithMessage("Load capacity must be greater than 0!");

            RuleFor(trip => trip.MaxRouteDeviationKm)
                .InclusiveBetween(1, 25)
                .WithMessage("Max route deviation must be from 1 to 25 km!");

            RuleFor(trip => trip.Distance)
                .GreaterThanOrEqualTo(1)
                .WithMessage("Distance must be greater than or equal to 1 km!");

            RuleFor(trip => trip.Points.Count)
                .GreaterThanOrEqualTo(1)
                .WithMessage("The count of points must be greater than or equal to 1!");

            RuleForEach(trip => trip.Points)
                .SetValidator(new CreatePointValidation());
        }
    }
}
