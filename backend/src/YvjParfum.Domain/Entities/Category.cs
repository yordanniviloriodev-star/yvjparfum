using YvjParfum.Domain.Common;

namespace YvjParfum.Domain.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public ICollection<Perfume> Perfumes { get; set; } = [];
}

