using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder
                .Property(p => p.Name)
                .IsRequired();
            builder
                .Property(p => p.TechnicalPassport)
                .IsRequired();
            builder
                .Property(p => p.LoadCapacity)
                .IsRequired();
            builder
                .Property(p => p.Volume)
                .IsRequired();
            builder
                .Property(p => p.Vin)
                .IsRequired();
            builder
                .Property(p => p.Category)
                .IsRequired();
            builder
                .Property(p => p.RegistrationDate)
                .IsRequired();
            builder
                .HasOne(p => p.User)
                .WithMany(p => p.Cars)
                .HasForeignKey(p => p.UserId);
            builder
                .HasMany(p => p.Offers)
                .WithOne(p => p.Car)
                .HasForeignKey(p => p.CarId);
        }
    }
}