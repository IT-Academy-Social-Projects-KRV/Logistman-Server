using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Entities.GoodCategoryEntity
{
    public class GoodCategoryConfiguration : IEntityTypeConfiguration<GoodCategory>
    {
        public void Configure(EntityTypeBuilder<GoodCategory> builder)
        {
            builder
                .Property(p => p.Name)
                .HasMaxLength(50);
            builder
                .HasMany(p => p.Offers)
                .WithOne(p => p.GoodCategory)
                .HasForeignKey(p => p.GoodCategoryId);
        }
    }
}
