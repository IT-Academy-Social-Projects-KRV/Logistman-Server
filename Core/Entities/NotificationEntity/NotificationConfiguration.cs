using Core.Entities.OfferEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Entities.NotificationEntity
{
    public class NotificationConfiguration : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder
                .HasOne(n => n.User)
                .WithMany(u => u.Notifications)
                .HasForeignKey(n => n.UserId);
            builder
                .HasOne(n => n.Offer)
                .WithOne(o => o.Notification)
                .HasForeignKey<Offer>(o => o.NotificationId);
            builder
                .HasOne(n => n.Trip)
                .WithMany(t => t.Notifications)
                .HasForeignKey(n => n.TripId);
        }
    }
}
