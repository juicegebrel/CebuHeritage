using CebuHeritage.Data;
using CebuHeritage.Models;
using Microsoft.EntityFrameworkCore;

namespace CebuHeritage.Services;

/// <summary>
/// Registered as Scoped, so each page request gets a new instance and reads fresh data
/// from Supabase. Within one request, the places are loaded only once.
/// </summary>
public class PlaceService(IDbContextFactory<AppDbContext> factory)
{
    private IReadOnlyList<Place>? _places;

    private IReadOnlyList<Place> Load()
    {
        if (_places is null)
        {
            using var db = factory.CreateDbContext();
            _places = db.Places.AsNoTracking().OrderBy(p => p.SortOrder).ToList();
        }
        return _places;
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