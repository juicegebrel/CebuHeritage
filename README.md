# Cebu Heritage

A Blazor Web App (.NET 8) with Tailwind CSS about the history, culture, and places to visit and stay in Cebu's cities and municipalities.

## Screens

| Route | What it shows |
|---|---|
| `/` | Home: hero, featured places, key dates, browse by area |
| `/places` | Searchable, filterable list (interactive server rendering) |
| `/places/{slug}` | One screen per place: overview, history timeline, culture, where to visit, where to stay |

Places included: Cebu City, Lapu-Lapu City, Carcar City, Argao, Boljoon, Oslob, Dalaguete, Badian, Moalboal, Daanbantayan and Malapascua, Bantayan Island.

## Requirements

- .NET 8 SDK
- Node.js 18 or newer (for the Tailwind CLI)

## Run

```bash
cd CebuHeritage
dotnet run
```

The first build runs `npm install` and `npm run build:css` automatically (see the `TailwindBuild` target in the `.csproj`). Then open http://localhost:5080.

### Live Tailwind rebuilds while developing

Use two terminals:

```bash
npm run watch:css
dotnet watch
```

Add `-p:SkipTailwind=true` to `dotnet watch` if you do not want MSBuild to rebuild the CSS as well.

## Adding or editing a place

All content lives in `Data/PlaceData.cs`. Add a new `Place` to the list and it appears on the home page, the list page and gets its own `/places/{slug}` screen.

Tailwind only generates classes it can see as full strings, so write gradients in full (for example `"from-sky-500 via-cyan-600 to-blue-800"`) and never build class names by concatenation.

## Project layout

```
Components/
  Layout/    MainLayout, NavMenu
  Pages/     Home, Places, PlaceDetail, Error
  Shared/    PlaceCard, Bunting
Data/        PlaceData.cs  (all content)
Models/      Place and related records
Services/    PlaceService
Styles/      app.css  (Tailwind input)
wwwroot/css/ app.css  (generated, git-ignored)
```

## Content note

Travel times, festival dates and hotel names are for planning inspiration and may change. Verify before travelling.
