using CalculadoraPekus.Components;
using CalculadoraPekus.Data;
using Microsoft.EntityFrameworkCore;
using MudBlazor;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(
    x
        =>x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddMudServices(x =>
{
    x.SnackbarConfiguration.SnackbarVariant = Variant.Outlined;
    x.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.TopCenter;
});

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
