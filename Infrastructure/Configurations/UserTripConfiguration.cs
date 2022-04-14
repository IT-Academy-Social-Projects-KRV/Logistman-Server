using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class UserTripConfiguration : IEntityTypeConfiguration<UserTrip>
    {
        public void Configure(EntityTypeBuilder<UserTrip> builder)
        {
            builder
                .ToTable("UserTrips")
                .HasKey(p => p.Id);
            builder
                .HasOne(p => p.User)
                .WithMany(p => p.UserTrips);
            builder
                .HasOne(p => p.Offer)
                .WithMany(p => p.UserTrips)
                .HasForeignKey(p => p.OfferId);
            builder
                .HasOne(p => p.Trip)
                .WithMany(p => p.UserTrips)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(p => p.TripId);

        }
    }
}