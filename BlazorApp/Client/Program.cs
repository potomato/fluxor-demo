using BlazorApp.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Fluxor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

var currentAssembly = typeof(Program).Assembly;
builder.Services.AddFluxor(o =>
    {
        o.ScanAssemblies(currentAssembly);
#if DEBUG
        o.UseReduxDevTools();
#endif
    });

await builder.Build().RunAsync();