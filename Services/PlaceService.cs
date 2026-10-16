using CebuHeritage.Data;
using CebuHeritage.Models;

namespace CebuHeritage.Services;

public class PlaceService
{
    private readonly IReadOnlyList<Place> _places = PlaceData.Build();

    public IReadOnlyList<Place> GetAll() => _places;

    public IReadOnlyList<string> Regions =>
        _places.Select(p => p.Region).Distinct().ToList();

    public Place? GetBySlug(string slug) =>
        _places.FirstOrDefault(p => string.Equals(p.Slug, slug, StringComparison.OrdinalIgnoreCase));

    public (Place? Previous, Place? Next) GetNeighbors(string slug)
    {
        var index = _places.ToList().FindIndex(p => string.Equals(p.Slug, slug, StringComparison.OrdinalIgnoreCase));
        if (index < 0) return (null, null);
        return (index > 0 ? _places[index - 1] : null,
                index < _places.Count - 1 ? _places[index + 1] : null);
    }
}
