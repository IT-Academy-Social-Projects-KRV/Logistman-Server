using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class TripConfiguration : IEntityTypeConfiguration<Trip>
    {
        public void Configure(EntityTypeBuilder<Trip> builder)
        {
            builder
                .Property(p => p.Name)
                .IsRequired();
            builder
                .Property(p => p.IsActive)
                .HasDefaultValue(false);
            builder
                .Property(p => p.Ended)
                .HasDefaultValue(false);
            builder
                .Property(p => p.StartDate)
                .IsRequired();

            builder
                .HasOne<Route>(p => p.Route)
                .WithMany(p => p.Trips)
                .HasForeignKey(p => p.RouteId);
            builder
                .HasMany<UserTrip>(p => p.UserTrips)
                .WithOne(p => p.Trip)
                .HasForeignKey(p => p.TripId)
                .OnDelete(DeleteBehavior.Restrict);
            builder
                .HasMany<Report>(p => p.Reports)
                .WithOne(p => p.Trip)
                .HasForeignKey(p => p.TripId);
        }
    }
}