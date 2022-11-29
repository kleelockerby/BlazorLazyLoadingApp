using BlazorLazyLoadingApp.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjYxMjU2QDMyMzAyZTMxMmUzME81WGE2cDRKSnA2eUdFZFRlMFdsRGtGdVEzaVBwU0pzelBienNDQW5IUnc9");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

var http = new HttpClient()
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
};
builder.Services.AddScoped(sp => http);
using var response = await http.GetAsync("assemblySettings.json");
using var stream = await response.Content.ReadAsStreamAsync();
builder.Configuration.AddJsonStream(stream);

builder.Services.AddScoped<WeatherForecastLazyService>();
builder.Services.AddSyncfusionBlazor();
builder.Services.AddScoped<LoadAssembliesService>();

await builder.Build().RunAsync();
