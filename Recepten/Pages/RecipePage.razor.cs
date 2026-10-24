using Elysium.Components.Services;
using Elysium.Icons;
using Microsoft.AspNetCore.Components;
using Recepten.Models;

namespace Recepten.Pages;

public partial class RecipePage : BasePage
{
    [Parameter] public string? Identifier { get; set; }

    private Recipe Recipe { get => field ?? throw new FileNotFoundException(Identifier); set; }
    private int _persons = 2;

    protected override void OnInitialized()
    {
        if (string.IsNullOrEmpty(Identifier) || RecipeService.GetRecipeByIdentifier(Identifier) is not Recipe recipe)
        {
            NavigationManager.NavigateTo("/not-found");
            return;
        }

        Recipe = recipe;

        SetAppBarConfig();
    }

    private void SetAppBarConfig()
    {
        AppBarService.SetConfig(new AppBarConfig
        {
            Title = Recipe.Name,
            LeftButtons = [new AppBarBackButton()],
            RightButtons = [new AppBarButton(Recipe.IsFavorite ? Icons.Star_Fill : Icons.Star, ToggleFavorite)]
        });
    }

    private async Task ToggleFavorite()
    {
        Recipe.IsFavorite = !Recipe.IsFavorite;

        await RecipeService.ToggleFavorite(Recipe.Identifier);

        SetAppBarConfig();
    }

    private void Decrement()
    {
        if (_persons == 1) return;

        _persons--;
    }

    private void Increment()
    {
        _persons++;
    }
}
