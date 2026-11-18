using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YvjParfum.Domain.Entities;

namespace YvjParfum.Infrastructure.Persistence.Configurations;

public class FragranceNoteConfiguration : IEntityTypeConfiguration<FragranceNote>
{
    public void Configure(EntityTypeBuilder<FragranceNote> builder)
    {
        builder.Property(n => n.Name)
               .HasMaxLength(50)
               .IsRequired();

        builder.HasIndex(n => n.Name)
               .IsUnique();
    }
}
