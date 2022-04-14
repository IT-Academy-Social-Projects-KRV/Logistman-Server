using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class OfferConfiguration : IEntityTypeConfiguration<Offer>
    {
        public void Configure(EntityTypeBuilder<Offer> builder)
        {
            builder
                .Property(p => p.Name)
                .IsRequired();
            builder
                .Property(p => p.Date)
                .IsRequired();
            builder
                .Property(p => p.Description)
                .IsRequired();
            builder
                .Property(p => p.Closed)
                .HasDefaultValue(false);
            builder
                .Property(p => p.Weight)
                .IsRequired();
            builder
                .Property(p => p.Volume)
                .IsRequired();
            builder
                .Property(p => p.StartDate)
                .IsRequired();
            builder
                .Property(p => p.EndDate)
                .IsRequired();
            builder
                .HasMany<UserTrip>(p => p.UserTrips)
                .WithOne(p => p.Offer)
                .HasForeignKey(p => p.OfferId);
            builder
                .HasMany<OfferTag>(p => p.OfferTags)
                .WithOne(p => p.Offer)
                .HasForeignKey(p => p.OfferId);
            builder
                .HasOne<ParticipantRole>(p => p.ParticipantRole)
                .WithMany(p => p.Offers)
                .HasForeignKey(p => p.ParticipantRoleId);
            builder
                .HasOne<User>(p => p.User)
                .WithMany(p => p.Offers)
                .HasForeignKey(p => p.UserId);
            builder
                .HasOne<Car>(p => p.Car)
                .WithMany(p => p.Offers)
                .HasForeignKey(p => p.CarId);
            builder
                .HasOne<Route>(p => p.Route)
                .WithMany(p => p.Offers)
                .HasForeignKey(p => p.RouteId);
        }
    }
}