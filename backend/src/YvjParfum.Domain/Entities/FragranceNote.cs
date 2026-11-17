using YvjParfum.Domain.Common;

namespace YvjParfum.Domain.Entities;

public class FragranceNote : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public ICollection<PerfumeNote> PerfumeNotes { get; set; } = [];
}