using Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Configurations;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Data
{
    public class LogistDbContext : IdentityDbContext
    {
        public LogistDbContext(DbContextOptions<LogistDbContext> options) : base(options)
        {
        }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<ParticipantRole> ParticipantRoles { get; set; }
        public virtual DbSet<UserTrip> UserTrips { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<Offer> Offers { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<Point> Points { get; set; }
        public virtual DbSet<OfferTag> OfferTags { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Trip> Trips { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(LogistDbContext).Assembly);
            base.OnModelCreating(builder);
        }
    }
}
