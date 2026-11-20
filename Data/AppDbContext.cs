using CebuHeritage.Models;
using Microsoft.EntityFrameworkCore;

namespace CebuHeritage.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Place> Places => Set<Place>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Place>(e =>
        {
            e.ToTable("places");
            e.HasKey(p => p.Slug);
            // Nested lists are stored as jsonb columns, so one table is enough.
            e.OwnsMany(p => p.History, o => o.ToJson());
            e.OwnsMany(p => p.Culture, o => o.ToJson());
            e.OwnsMany(p => p.Attractions, o => o.ToJson());
            e.OwnsMany(p => p.Stays, o => o.ToJson());
            // KnownFor (List<string>) maps to a text[] column automatically.
        });
    }
}