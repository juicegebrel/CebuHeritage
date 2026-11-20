using CebuHeritage.Data;
using CebuHeritage.Models;
using Microsoft.EntityFrameworkCore;

namespace CebuHeritage.Services;

public class PlaceService(IDbContextFactory<AppDbContext> factory)
{
    private IReadOnlyList<Place> _places = Array.Empty<Place>();
    private DateTime _loadedAt = DateTime.MinValue;
    private readonly object _lock = new();

    private IReadOnlyList<Place> Load()
    {
        lock (_lock)
        {
            if (DateTime.UtcNow - _loadedAt > TimeSpan.FromMinutes(5))
            {
                using var db = factory.CreateDbContext();
                _places = db.Places.AsNoTracking().OrderBy(p => p.SortOrder).ToList();
                _loadedAt = DateTime.UtcNow;
            }
            return _places;
        }
    }

    public IReadOnlyList<Place> GetAll() => Load();

    public IReadOnlyList<string> Regions => Load().Select(p => p.Region).Distinct().ToList();

    public Place? GetBySlug(string slug) =>
        Load().FirstOrDefault(p => string.Equals(p.Slug, slug, StringComparison.OrdinalIgnoreCase));

    public (Place? Previous, Place? Next) GetNeighbors(string slug)
    {
        var list = Load();
        var index = list.ToList().FindIndex(p => string.Equals(p.Slug, slug, StringComparison.OrdinalIgnoreCase));
        if (index < 0) return (null, null);
        return (index > 0 ? list[index - 1] : null,
                index < list.Count - 1 ? list[index + 1] : null);
    }
}