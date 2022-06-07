﻿using Core.DTO.TripDTO;
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
                .MinimumLength(0)
                .MaximumLength(1000)
                .WithMessage("'{PropertyName}' must be between 0 & 1000 symbols!");

            RuleFor(offer => offer.LoadCapacity)
                .GreaterThan(0)
                .WithMessage("Load capacity must be greater than 0!");

            RuleFor(offer => offer.MaxRouteDeviationKm)
                .InclusiveBetween(1, 25)
                .WithMessage("Max route deviation must be from 1 to 25km!");

            RuleFor(trip => trip.Points.Count)
                .InclusiveBetween(2, 10)
                .WithMessage("The count of points must be between 2 & 10!");

            RuleForEach(trip => trip.Points)
                .SetValidator(new CreatePointValidation());
        }
    }
}