using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Npgsql;
using CebuHeritage.Data;
using CebuHeritage.Models;
using Microsoft.EntityFrameworkCore;
using CebuHeritage.Components;
using CebuHeritage.Services;

var builder = WebApplication.CreateBuilder(args);

// Static SSR by default; individual pages opt in to interactivity with @rendermode.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddSingleton<PlaceService>();

builder.Services.AddDbContextFactory<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Supabase")));

var app = builder.Build();

var dbFactory = app.Services.GetRequiredService<IDbContextFactory<AppDbContext>>();
using (var db = dbFactory.CreateDbContext())
{
    try
    {
        // Creates only our tables, even though the database isn't empty.
        db.GetService<IRelationalDatabaseCreator>().CreateTables();
    }
    catch (PostgresException ex) when (ex.SqlState == PostgresErrorCodes.DuplicateTable)
    {
        // The places table already exists from an earlier run, which is fine.
    }

    if (!db.Places.Any())
    {
        var seed = PlaceData.Build().ToList();
        for (var i = 0; i < seed.Count; i++) seed[i].SortOrder = i;
        db.Places.AddRange(seed);
        db.SaveChanges();
    }
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
