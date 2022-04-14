using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class PointConfiguration : IEntityTypeConfiguration<Point>
    {
        public void Configure(EntityTypeBuilder<Point> builder)
        {
            builder
                .Property(p => p.Latitude)
                .IsRequired();
            builder
                .Property(p => p.Longtitude)
                .IsRequired();
            builder
                .Property(p => p.Address)
                .IsRequired();
            builder
                .Property(p => p.Settlement)
                .IsRequired();
            builder
                .Property(p => p.Region)
                .IsRequired();
            builder
                .HasOne<Route>(p => p.Route)
                .WithMany(p => p.Points)
                .HasForeignKey(p => p.RouteId);
            builder
                .HasOne<ParticipantRole>(p => p.ParticipantRole)
                .WithMany(p => p.Points)
                .HasForeignKey(p => p.ParticipantRoleId);
        }
    }
}