using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Entities.PointTripEntity
{
    public class PointTripConfiguration : IEntityTypeConfiguration<PointTrip>
    {
        public void Configure(EntityTypeBuilder<PointTrip> builder)
        {
            builder
                .HasOne(p => p.Point)
                .WithMany(p => p.PointTrips)
                .HasForeignKey(p => p.PointId);
            builder
                .HasOne(p => p.Trip)
                .WithMany(p => p.PointTrips)
                .HasForeignKey(p => p.TripId);
        }
    }
}
