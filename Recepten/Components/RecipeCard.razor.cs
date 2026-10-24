using Microsoft.AspNetCore.Components;
using Recepten.Models;

namespace Recepten.Components;

public partial class RecipeCard
{
    [Parameter] public required Recipe Recipe { get; set; }
    [Parameter] public EventCallback OnClick { get; set; }
    [Parameter] public EventCallback OnToggleFavorite { get; set; }
}
