using FlashCards.ApiClient;
using FlashCards.BlazorClient;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddHttpClient<CardsApiClient>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration["WebApiUri"]);
});

await builder.Build().RunAsync();
