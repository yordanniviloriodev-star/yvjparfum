using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YvjParfum.Domain.Entities;

namespace YvjParfum.Infrastructure.Persistence.Configurations;

public class PerfumeNoteConfiguration : IEntityTypeConfiguration<PerfumeNote>
{
    public void Configure(EntityTypeBuilder<PerfumeNote> builder)
    {
        builder.HasKey(pn => new { pn.PerfumeId, pn.FragranceNoteId });

        builder.HasOne(pn => pn.Perfume)
               .WithMany(p => p.Notes)
               .HasForeignKey(pn => pn.PerfumeId);

        builder.HasOne(pn => pn.FragranceNote)
               .WithMany(n => n.PerfumeNotes)
               .HasForeignKey(pn => pn.FragranceNoteId);
    }
}
