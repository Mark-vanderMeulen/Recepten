using Elysium.Components.Services;
using Elysium.Themes;
using Elysium.Utilities.DeviceInfo;
using Elysium.Utilities.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace Recepten;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");

        builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

        builder.Services.AddElysiumThemes();
        builder.Services.AddScoped<DeviceInfoService>();
        builder.Services.AddScoped<ElAppBarService>();
        builder.Services.AddScoped<LocalStorageService>();

        builder.Services.AddScoped<RecipeService>();

        await builder.Build().RunAsync();
    }
}
