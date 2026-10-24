using Elysium.Components.Services;

namespace Recepten.Pages;

public partial class FavoritesPage : BasePage
{
    protected override void OnInitialized()
    {
        AppBarService.SetConfig(new AppBarConfig { Title = "Favorieten" });
    }
}
