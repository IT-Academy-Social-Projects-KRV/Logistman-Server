using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder
                .HasMany<OfferTag>(p => p.OfferTags)
                .WithOne(p => p.Tag)
                .HasForeignKey(p => p.TagId);
            builder
                .Property(p => p.Name)
                .IsRequired();
        }
    }
}