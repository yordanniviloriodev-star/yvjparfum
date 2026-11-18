using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YvjParfum.Domain.Entities;

namespace YvjParfum.Infrastructure.Persistence.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.Property(c => c.Name)
               .HasMaxLength(50)
               .IsRequired();

        builder.HasIndex(c => c.Name)
               .IsUnique();
    }
}
