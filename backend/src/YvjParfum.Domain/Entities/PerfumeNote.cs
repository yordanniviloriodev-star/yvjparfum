using YvjParfum.Domain.Enums;

namespace YvjParfum.Domain.Entities;

public class PerfumeNote
{
    public int PerfumeId { get; set; }
    public Perfume Perfume { get; set; } = null!;

    public int FragranceNoteId { get; set; }
    public FragranceNote FragranceNote { get; set; } = null!;

    public NoteLevel Level { get; set; }
}