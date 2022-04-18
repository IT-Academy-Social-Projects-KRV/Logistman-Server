using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Entities.ReportEntity
{
    public class ReportConfiguration : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> builder)
        {
            builder
                .HasOne(p => p.ReportedUser)
                .WithMany(p => p.ReportedReports)
                .HasForeignKey(p => p.ReportedUserId);
            builder
                .HasOne(p => p.ReporterUser)
                .WithMany(p => p.ReporterReports)
                .HasForeignKey(p => p.ReporterUserId);
            builder
                .HasOne(p => p.Trip)
                .WithMany(p => p.Reports)
                .HasForeignKey(p => p.TripId);
        }
    }
}
