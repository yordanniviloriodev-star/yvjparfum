using Microsoft.EntityFrameworkCore;

using YvjParfum.Domain.Entities;

namespace YvjParfum.Infrastructure.Persistence;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Brand> Brands => Set<Brand>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Perfume> Perfumes => Set<Perfume>();
    public DbSet<FragranceNote> FragranceNotes => Set<FragranceNote>();
    public DbSet<PerfumeNote> PerfumeNotes => Set<PerfumeNote>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}