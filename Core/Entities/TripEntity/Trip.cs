﻿using Core.Entities.CarEntity;
using Core.Entities.OfferEntity;
using Core.Entities.PointTripEntity;
using Core.Entities.RatingEntity;
using Core.Entities.ReportEntity;
using Core.Entities.UserEntity;
using System;
using System.Collections.Generic;

namespace Core.Entities.TripEntity
{
    public class Trip
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsEnded { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset ExpirationDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public string Description { get; set; }
        public float LoadCapacity { get; set; }
        public int MaxRouteDeviation { get; set; }
        public string TripCreatorId { get; set; }
        public User User { get; set; }
        public int TransportationCarId { get; set; }
        public Car Car { get; set; }
        public ICollection<Offer> Offers { get; set; }
        public ICollection<Rating> Ratings { get; set; }
        public ICollection<Report> Reports { get; set; }
        public ICollection<PointTrip> PointTrips { get; set; }

    }
}