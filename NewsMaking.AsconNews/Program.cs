using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using NewsMaking.AsconNews;
using NewsMaking.AsconNews.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient<IAsconService, AsconService>(sp => sp.BaseAddress = new Uri("https://update.ascon.ru"));

await builder.Build().RunAsync();
