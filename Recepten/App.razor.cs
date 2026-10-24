using Microsoft.AspNetCore.Components;

namespace Recepten;

public partial class App
{
    [Inject] private RecipeService RecipeService { get; init; } = null!;

    protected override async Task OnInitializedAsync()
    {
        await RecipeService.InitializeAsync();
    }
}
