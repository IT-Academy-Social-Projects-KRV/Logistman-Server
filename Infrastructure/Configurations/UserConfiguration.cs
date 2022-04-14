using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .Property(p => p.Name)
                .IsRequired();
            builder
                .Property(p => p.Surname)
                .IsRequired();
            builder
                .Property(p => p.Email)
                .IsRequired();
            builder
                .Property(p => p.Rating)
                .IsRequired();
            builder
                .Property(p => p.IsHasCar)
                .IsRequired();
            builder
                .Property(p => p.RegistrationDate)
                .IsRequired();
            builder
                .HasMany<Car>(p => p.Cars)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);
            builder
                .HasMany<Offer>(p => p.Offers)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);
            builder
                .HasMany<UserTrip>(p => p.UserTrips)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);
                
            builder
                .HasMany<Report>(p => p.Reports)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);
        }
    }
}