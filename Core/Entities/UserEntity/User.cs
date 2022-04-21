using Core.Entities.OfferEntity;
using Core.Entities.RatingEntity;
using Core.Entities.RefreshTokenEntity;
using Core.Entities.ReportEntity;
using Core.Entities.TripEntity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Core.Entities.UserEntity
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public float? Rating  { get; set; }
        public bool HasCar { get; set; }
        public DateTimeOffset RegistrationDate { get; set; }
        public ICollection<Offer> Offers { get; set; }
        public ICollection<Trip> Trips { get; set; }
        public ICollection<Rating> RatedRatings { get; set; }
        public ICollection<Rating> EstimatorRatings { get; set; }
        public ICollection<Report> ViolationReports { get; set; }
        public ICollection<Report> ReporterReports { get; set; }
        public ICollection<RefreshToken> RefreshTokens { get; set; }
    }
}
