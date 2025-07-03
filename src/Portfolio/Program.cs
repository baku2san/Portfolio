using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Portfolio;
using Portfolio.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// デバッグ情報の出力
Console.WriteLine($"Base address: {builder.HostEnvironment.BaseAddress}");
Console.WriteLine($"Environment: {builder.HostEnvironment.Environment}");

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// HttpClient設定
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Portfolio services
builder.Services.AddScoped<IPortfolioDataService, PortfolioDataService>();

// エラーハンドリング
#if DEBUG
builder.Logging.SetMinimumLevel(LogLevel.Debug);
#else
builder.Logging.SetMinimumLevel(LogLevel.Information);
#endif

try
{
    Console.WriteLine("Starting Blazor application...");
    await builder.Build().RunAsync();
}
catch (Exception ex)
{
    Console.WriteLine($"Application startup error: {ex.Message}");
    Console.WriteLine($"Stack trace: {ex.StackTrace}");

    // Inner exception の情報も出力
    if (ex.InnerException != null)
    {
        Console.WriteLine($"Inner exception: {ex.InnerException.Message}");
        Console.WriteLine($"Inner exception stack trace: {ex.InnerException.StackTrace}");
    }

    throw;
}
