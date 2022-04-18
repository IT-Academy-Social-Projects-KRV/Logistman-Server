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
                .IsRequired();
            builder
                .Property(p => p.Description)
                .IsRequired();
            builder
                .HasMany(p => p.PointTrips)
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
