using Core.Entities.NotificationEntity;
using Core.Entities.PointEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Entities.OfferEntity
{
    public class OfferConfiguration : IEntityTypeConfiguration<Offer>
    {
        public void Configure(EntityTypeBuilder<Offer> builder)
        {
            builder
                .Property(o => o.Description)
                .IsRequired(false);
            builder
                .HasOne(o => o.OfferRole)
                .WithMany(o => o.Offers)
                .HasForeignKey(o => o.CreatorRoleId);
            builder
                .HasOne(o => o.Point)
                .WithOne(p => p.Offer)
                .HasForeignKey<PointData>(p => p.OfferId);
            builder
                .HasOne(p => p.GoodCategory)
                .WithMany(gc => gc.Offers)
                .HasForeignKey(p => p.GoodCategoryId);
            builder
                .HasOne(p => p.Trip)
                .WithMany(t => t.Offers)
                .HasForeignKey(p => p.RelatedTripId)
                .IsRequired(false);
            builder
                .HasOne(p => p.User)
                .WithMany(u => u.Offers)
                .HasForeignKey(p => p.OfferCreatorId);
            builder
                .HasOne(p => p.Notification)
                .WithOne(n => n.Offer)
                .HasForeignKey<Notification>(p => p.OfferId);
        }
    }
}
