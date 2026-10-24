using Elysium.Utilities.LocalStorage;
using Recepten.Models;
using System.Text.Json;

namespace Recepten;

public class RecipeService
{
    private readonly LocalStorageService _localStorageService;
    private readonly List<Recipe> _recipes = [];
    private readonly HashSet<string> _favorites = new(StringComparer.OrdinalIgnoreCase);
    private bool _initialized;

    public RecipeService(LocalStorageService localStorageService) => _localStorageService = localStorageService;

    public Recipe? GetRecipeByIdentifier(string identifier) => _recipes.FirstOrDefault(recipe => recipe.Identifier.Equals(identifier, StringComparison.OrdinalIgnoreCase));
    public IEnumerable<Recipe> GetRecipes(Func<Recipe, bool>? predicate = null) => predicate != null ? _recipes.Where(predicate) : _recipes;
    
    public async Task ToggleFavorite(string identifier)
    {
        if (!_favorites.Add(identifier))
        {
            _favorites.Remove(identifier);
        }

        await _localStorageService.SetItemAsync("favorites", JsonSerializer.Serialize(_favorites));
    }

    public async Task InitializeAsync()
    {
        if (_initialized) return;

        await InitializeFavoritesAsync();

        _recipes.Clear();

        var recipeTypes = typeof(RecipeService).Assembly.GetTypes().Where(t => t.IsClass && !t.IsAbstract && typeof(Recipe).IsAssignableFrom(t));

        foreach (var type in recipeTypes)
        {
            if (Activator.CreateInstance(type) is not Recipe recipe) continue;
            
            recipe.IsFavorite = _favorites.Contains(recipe.Identifier);

            _recipes.Add(recipe);
        }

        _initialized = true;
    }

    private async Task InitializeFavoritesAsync()
    {
        var favoritesJson = await _localStorageService.GetItemAsync("favorites");

        if (string.IsNullOrEmpty(favoritesJson))
        {
            await _localStorageService.SetItemAsync("favorites", "[]");
            return;
        }

        if (JsonSerializer.Deserialize<HashSet<string>>(favoritesJson) is not { Count: > 0 } favorites) return;
        
        _favorites.Clear();

        foreach (var favorite in favorites)
        {
            _favorites.Add(favorite);
        }
    }
}
