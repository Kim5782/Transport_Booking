using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Transport_Booking.Client;
using Toolbelt.Blazor.Extensions.DependencyInjection;
using Transport_Booking.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("Transport_Booking.ServerAPI", (sp,client) => {client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
    client.EnableIntercept(sp);
})
.AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();
// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("Transport_Booking.ServerAPI"));

builder.Services.AddHttpClientInterceptor();
builder.Services.AddApiAuthorization();
builder.Services.AddScoped<HttpInterceptorService>();

await builder.Build().RunAsync();
