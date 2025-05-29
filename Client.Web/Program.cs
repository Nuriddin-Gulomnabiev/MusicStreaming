using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Client.Web;
using Client.Web.Services;
using Microsoft.AspNetCore.Components.Authorization;
using MudBlazor.Services;
using Client.Web.Services.ApiHttpService;
using Blazored.LocalStorage;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddMudServices();
builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped<ApiHttpService>();
builder.Services.AddScoped<TokenProvider>();
builder.Services.AddScoped<CustomAuthStateProvider>();
builder.Services.AddScoped<AuthenticationStateProvider>(sp =>
{
    var authStateProvider = sp.GetRequiredService<CustomAuthStateProvider>();
    var tokenProvider = sp.GetRequiredService<TokenProvider>();
    tokenProvider.OnTokenChanged += () => authStateProvider.NotifyAuthenticationStateChanged();
    return authStateProvider;
});

builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped(sp =>
{
    var tokenProvider = sp.GetRequiredService<TokenProvider>();
    return new HttpClient(new AuthMessageHandler(tokenProvider))
    {
        BaseAddress = new Uri("https://localhost:7193/")
    };
});

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

var host = builder.Build();

var tokenProvider = host.Services.GetRequiredService<TokenProvider>();
await tokenProvider.InitAsync();

await host.RunAsync();
