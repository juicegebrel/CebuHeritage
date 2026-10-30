namespace CebuHeritage.Models;

public record TimelineEntry(string Year, string Text);

public record CultureItem(string Icon, string Title, string Text);

public record Attraction(string Name, string Category, string Icon, string Description);

public record Stay(string Name, string Style, string Description);

public class Place
{
    public required string Slug { get; init; }
    public required string Name { get; init; }
    public required string Kind { get; init; }          // "City" or "Municipality"
    public required string Region { get; init; }
    public required string Tagline { get; init; }
    public required string Gradient { get; init; }      // full Tailwind gradient classes, e.g. "from-orange-500 to-purple-700"
    public required string Overview { get; init; }
    public required string GettingThere { get; init; }

    public string? ImageUrl { get; init; }      // e.g. "/images/cebu-city.jpg"
    public string? ImageAlt { get; init; }      // optional description for screen readers
    public string? ImageCredit { get; init; }   // optional photographer / licence line

    public string? FestivalName { get; init; }
    public string? FestivalNote { get; init; }

    public List<string> KnownFor { get; init; } = new();
    public List<TimelineEntry> History { get; init; } = new();
    public List<CultureItem> Culture { get; init; } = new();
    public List<Attraction> Attractions { get; init; } = new();
    public List<Stay> Stays { get; init; } = new();
    public string? StayNote { get; init; }
}
