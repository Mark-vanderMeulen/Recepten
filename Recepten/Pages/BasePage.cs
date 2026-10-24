using Elysium.Components.Services;
using Elysium.Utilities.DeviceInfo;
using Microsoft.AspNetCore.Components;

namespace Recepten.Pages;

public abstract class BasePage : ComponentBase, IDisposable
{
    [Inject] protected DeviceInfoService DeviceInfoService { get; init; } = null!;
    [Inject] protected ElAppBarService AppBarService { get; init; } = null!;
    [Inject] protected NavigationManager NavigationManager { get; init; } = null!;
    [Inject] protected RecipeService RecipeService { get; init; } = null!;

    protected Orientation Orientation { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var deviceInfo = await DeviceInfoService.GetDeviceInfoAsync();

        Orientation = deviceInfo.Orientation;

        DeviceInfoService.OrientationChanged += OnOrientationChanged;
    }

    private void OnOrientationChanged(object? sender, DeviceInfoEventArgs e)
    {
        if (e.DeviceInfo.Orientation == Orientation) return;

        Orientation = e.DeviceInfo.Orientation;

        StateHasChanged();
    }

    public void Dispose()
    {
        DeviceInfoService.OrientationChanged -= OnOrientationChanged;
    }
}
