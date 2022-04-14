using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class RouteConfiguration : IEntityTypeConfiguration<Route>
    {
        public void Configure(EntityTypeBuilder<Route> builder)
        {
            builder
                .HasMany<Offer>(p => p.Offers)
                .WithOne(p => p.Route)
                .HasForeignKey(p => p.RouteId);
            builder
                .HasMany<Trip>(p => p.Trips)
                .WithOne(p => p.Route)
                .HasForeignKey(p => p.RouteId);
            builder
                .HasMany<Point>(p => p.Points)
                .WithOne(p => p.Route)
                .HasForeignKey(p => p.RouteId);
        }
    }
}