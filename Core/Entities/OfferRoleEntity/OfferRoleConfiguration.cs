using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Entities.RoleEntity
{
    public class OfferRoleConfiguration : IEntityTypeConfiguration<OfferRole>
    {
        public void Configure(EntityTypeBuilder<OfferRole> builder)
        {
            builder.HasMany(p => p.Offers)
                .WithOne(p => p.OfferRole)
                .HasForeignKey(p => p.CreatorRoleId);
        }
    }
}
