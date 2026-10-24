using Elysium.Components.Services;
using Recepten.Models;

namespace Recepten.Pages;

public partial class HomePage : BasePage
{
    private IEnumerable<Recipe> _recipes = [];

    protected override void OnInitialized()
    {
        //AppBarService.SetConfig(new AppBarConfig { Title = "Recepten", OnSearch = (text) => Search(text) });
        AppBarService.SetConfig(new AppBarConfig
        {
            Title = "Recepten",
            RightButtons = [new AppBarSearchButton(Search)]
        });
        
        _recipes = RecipeService.GetRecipes();
    }

    private void Search(string searchText)
    {
        if (string.IsNullOrEmpty(searchText))
        {
            _recipes = RecipeService.GetRecipes();
        }
        else
        {
            _recipes = RecipeService.GetRecipes(recipe => recipe.Name.Contains(searchText, StringComparison.InvariantCultureIgnoreCase));
        }

        StateHasChanged();
    }
}
