using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YvjParfum.Domain.Entities;

namespace YvjParfum.Infrastructure.Persistence.Configurations;

public class PerfumeConfiguration : IEntityTypeConfiguration<Perfume>
{
    public void Configure(EntityTypeBuilder<Perfume> builder)
    {
        builder.Property(p => p.Name)
               .HasMaxLength(150)
               .IsRequired();

        builder.Property(p => p.Description)
               .HasMaxLength(2000);

        builder.Property(p => p.Price)
               .HasPrecision(10, 2);

        builder.Property(p => p.ImageUrl)
               .HasMaxLength(500);

        builder.HasOne(p => p.Brand)
               .WithMany(b => b.Perfumes)
               .HasForeignKey(p => p.BrandId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(p => p.Category)
               .WithMany(c => c.Perfumes)
               .HasForeignKey(p => p.CategoryId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(p => new { p.Name, p.BrandId, p.SizeMl })
               .IsUnique();
    }
}
