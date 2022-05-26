using BlazorServerTest.Data;
using DataAccessLibrary;
using Microsoft.AspNetCore.ResponseCompression;
using BlazorServerTest.Hubs; 


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddTransient<ISqlDataAccess, SqlDataAccess>();
builder.Services.AddTransient<IPlayersData,PlayersData>();
builder.Services.AddTransient<IClubsData, ClubsData>();
builder.Services.AddTransient<ICoachsData, CoachsData>();
builder.Services.AddTransient<CacheDataAccess>();
builder.Services.AddMemoryCache();
builder.Services.AddResponseCompression(opts =>
{
    opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[] { "application/octet-stream" });

});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapHub<DemoHub>("demohub");
app.MapHub<ClubHub>("clubhub");
app.MapFallbackToPage("/_Host");

app.Run();
