using Microsoft.AspNetCore.Components;
using Recepten.Models;

namespace Recepten.Components;

public partial class RecipeGallery
{
    [Inject] private NavigationManager NavigationManager { get; init; } = null!;
    [Inject] private RecipeService RecipeService { get; init; } = null!;
    [Parameter] public IOrderedEnumerable<Recipe> Recipes { get; set; } = Enumerable.Empty<Recipe>().Order();

    private void OnClickRecipe(Recipe recipe)
    {
        NavigationManager.NavigateTo(recipe.Identifier);
    }

    private async Task OnToggleFavorite(Recipe recipe)
    {
        recipe.IsFavorite = !recipe.IsFavorite;

        await RecipeService.ToggleFavorite(recipe.Identifier);
    }
}
