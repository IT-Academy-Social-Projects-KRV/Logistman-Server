using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class RoleConfigurations : IEntityTypeConfiguration<ParticipantRole>
    {
        public void Configure(EntityTypeBuilder<ParticipantRole> builder)
        {
            builder
                .HasMany<Offer>(p => p.Offers)
                .WithOne(p => p.ParticipantRole)
                .HasForeignKey(p => p.ParticipantRoleId);
            builder
                .HasMany<Point>(p => p.Points)
                .WithOne(p => p.ParticipantRole)
                .HasForeignKey(p => p.ParticipantRoleId);
        }
    }
}