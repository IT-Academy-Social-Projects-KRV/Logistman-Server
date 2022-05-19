using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Entities.OfferEntity
{
    public class OfferConfiguration : IEntityTypeConfiguration<Offer>
    {
        public void Configure(EntityTypeBuilder<Offer> builder)
        {
            builder
                .Property(p => p.Description)
                .IsRequired(false);
            builder
                .HasOne(p => p.OfferRole)
                .WithMany(p => p.Offers)
                .HasForeignKey(p => p.CreatorRoleId);
            builder
                .HasOne(p => p.Point)
                .WithMany(p => p.Offers)
                .HasForeignKey(p => p.OfferPointId);
            builder
                .HasOne(p => p.GoodCategory)
                .WithMany(p => p.Offers)
                .HasForeignKey(p => p.GoodCategoryId);
            builder
                .HasOne(p => p.Trip)
                .WithMany(p => p.Offers)
                .HasForeignKey(p => p.RelatedTripId)
                .IsRequired(false);
            builder
                .HasOne(p => p.User)
                .WithMany(p => p.Offers)
                .HasForeignKey(p => p.OfferCreatorId);
        }
    }
}
