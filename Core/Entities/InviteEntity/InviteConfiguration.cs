using Core.Entities.InviteEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Entities.OfferEntity
{
    public class InviteConfiguration : IEntityTypeConfiguration<Invite>
    {
        public void Configure(EntityTypeBuilder<Invite> builder)
        {
            builder
                .HasOne(i => i.User)
                .WithMany(i => i.Invites)
                .HasForeignKey(i => i.UserId);
            builder
                .HasOne(i => i.Trip)
                .WithMany(i => i.Invites)
                .HasForeignKey(i => i.TripId);
        }
    }
}
