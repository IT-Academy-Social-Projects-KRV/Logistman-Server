using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class ReportConfiguration : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> builder)
        {
            builder
                .Property(p => p.Name)
                .IsRequired();
            builder
                .Property(p => p.Closed)
                .HasDefaultValue(false);
            builder
                .Property(p => p.Description)
                .IsRequired();
            builder
                .Property(p => p.Date)
                .IsRequired();
            builder
                .HasOne<User>(p => p.User)
                .WithMany(p => p.Reports)
                .HasForeignKey(p => p.UserId);
            builder
                .HasOne<Trip>(p => p.Trip)
                .WithMany(p => p.Reports)
                .HasForeignKey(p => p.TripId);
        }
    }
}