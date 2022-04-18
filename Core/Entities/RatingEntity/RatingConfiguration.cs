using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Entities.RatingEntity
{
    public class RatingConfiguration : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder
                .Property(p => p.Description)
                .IsRequired();
            builder
               .HasOne(p => p.EstimatorUser)
               .WithMany(p => p.EstimatorRatings)
               .HasForeignKey(p => p.EstimatorUserId);
            builder
                .HasOne(p => p.RatedUser)
                .WithMany(p => p.RatedRatings)
                .HasForeignKey(p => p.RatedUserId);
            builder
                .HasOne(p => p.Trip)
                .WithMany(p => p.Ratings)
                .HasForeignKey(p => p.TripId);
        }
    }
}
