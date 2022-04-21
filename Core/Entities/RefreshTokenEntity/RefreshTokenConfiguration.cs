using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Core.Entities.RefreshTokenEntity
{
    public class RefreshTokenConfiguration : IEntityTypeConfiguration<RefreshToken>
    {
        public void Configure(EntityTypeBuilder<RefreshToken> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Token)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(x => x.UserId)
                .IsRequired();

            builder
                .HasOne(x => x.User)
                .WithMany(x => x.RefreshTokens)
                .HasForeignKey(x => x.UserId);
        }
    }
}
