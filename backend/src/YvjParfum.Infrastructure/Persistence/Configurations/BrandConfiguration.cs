using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YvjParfum.Domain.Entities;

namespace YvjParfum.Infrastructure.Persistence.Configurations;

public class BrandConfiguration : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.Property(b => b.Name)
               .HasMaxLength(100)
               .IsRequired();

        builder.HasIndex(b => b.Name)
               .IsUnique();
    }
}
