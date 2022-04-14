using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class OfferTagConfiguration : IEntityTypeConfiguration<OfferTag>
    {
        public void Configure(EntityTypeBuilder<OfferTag> builder)
        {
            builder
                .HasOne<Offer>(p => p.Offer)
                .WithMany(p => p.OfferTags)
                .HasForeignKey(p => p.OfferId);
            builder
                .HasOne<Tag>(p => p.Tag)
                .WithMany(p => p.OfferTags)
                .HasForeignKey(p => p.TagId);
        }
    }
}