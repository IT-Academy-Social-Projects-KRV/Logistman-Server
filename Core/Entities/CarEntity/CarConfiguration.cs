using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Entities.CarEntity
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder
                .Property(p => p.Vin)
                .HasMaxLength(17);
            builder
                .Property(p => p.Color)
                .IsRequired()
                .HasMaxLength(15);
            builder
                .Property(p => p.TechnicalPassport)
                .HasMaxLength(20);
            builder
                .Property(p => p.RegistrationNumber)
                .HasMaxLength(20);
            builder
                .Property(p => p.Model)
                .HasMaxLength(100);
            builder
                .HasOne(p => p.Category)
                .WithMany(p => p.Cars)
                .HasForeignKey(p => p.CategoryId);
            builder
                .HasMany(p => p.Trips)
                .WithOne(p => p.Car)
                .HasForeignKey(p => p.TransportationCarId);
        }
    }
}
