using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Entities.TripEntity
{
    public class TripConfiguration : IEntityTypeConfiguration<Trip>
    {
        public void Configure(EntityTypeBuilder<Trip> builder)
        {
            builder
                .Property(p => p.EndDate)
                .IsRequired(false);
            builder
                .Property(p => p.Description)
                .IsRequired(false);
            builder
                .Property(p => p.RouteGeographyData)
                .IsRequired(true);
            builder
                .HasMany(p => p.Points)
                .WithOne(p => p.Trip)
                .HasForeignKey(p => p.TripId);
            builder
                .HasMany(p => p.Offers)
                .WithOne(p => p.Trip)
                .HasForeignKey(p => p.RelatedTripId);
            builder
                .HasMany(p => p.Ratings)
                .WithOne(p => p.Trip)
                .HasForeignKey(p => p.TripId);
            builder
                .HasMany(p => p.Reports)
                .WithOne(p => p.Trip)
                .HasForeignKey(p => p.TripId);
            builder
                .HasOne(p => p.User)
                .WithMany(p => p.Trips)
                .HasForeignKey(p => p.TripCreatorId);
            builder
                .HasOne(p => p.Car)
                .WithMany(p => p.Trips)
                .HasForeignKey(p => p.TransportationCarId);
        }
    }
}
