using YvjParfum.Domain.Common;
using YvjParfum.Domain.Enums;

namespace YvjParfum.Domain.Entities;

public class Perfume : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public Gender Gender { get; set; }
    public int SizeMl { get; set; }
    public decimal Price { get; set; }
    public string? ImageUrl { get; set; }
    public bool IsActive { get; set; } = true;

    public int BrandId { get; set; }
    public Brand Brand { get; set; } = null!;

    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;

    public ICollection<PerfumeNote> Notes { get; set; } = [];
}