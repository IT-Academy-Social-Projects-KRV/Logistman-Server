using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Entities.PointEntity
{
    public class PointConfiguration : IEntityTypeConfiguration<PointData>
    {
        public void Configure(EntityTypeBuilder<PointData> builder)
        {
            builder
                .Property(p => p.Address)
                .HasMaxLength(100);
            builder
                .Property(p => p.Settlement)
                .HasMaxLength(100);
            builder
                .Property(p => p.Region)
                .HasMaxLength(100);
            builder
                .HasMany(p => p.Offers)
                .WithOne(p => p.Point)
                .HasForeignKey(p => p.OfferPointId);
            builder
                .HasOne(p => p.Trip)
                .WithMany(p => p.Points)
                .HasForeignKey(p => p.TripId)
                .IsRequired(false);
        }
    }
}
