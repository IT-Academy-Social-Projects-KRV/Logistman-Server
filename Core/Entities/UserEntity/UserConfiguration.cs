using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Entities.UserEntity
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .Property(p => p.Rating)
                .IsRequired();
            builder
                .HasMany(p => p.Offers)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.OfferCreatorId);
            builder
                .HasMany(p => p.Trips)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.TripCreatorId);
            builder
                .HasMany(p => p.RatedRatings)
                .WithOne(p => p.RatedUser)
                .HasForeignKey(p => p.RatedUserId);
            builder
                .HasMany(p => p.EstimatorRatings)
                .WithOne(p => p.EstimatorUser)
                .HasForeignKey(p => p.EstimatorUserId);
            builder
                .HasMany(p => p.ReportedReports)
                .WithOne(p => p.ReportedUser)
                .HasForeignKey(p => p.ReportedUserId);
            builder
                .HasMany(p => p.ReporterReports)
                .WithOne(p => p.ReporterUser)
                .HasForeignKey(p => p.ReporterUserId);
        }
    }
}
