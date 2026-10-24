namespace Recepten.Models;

public abstract class Recipe
{
    public abstract string Identifier { get; }
    public abstract string Name { get; }
    public abstract Category? Categories { get; }
    public abstract string? Description { get; }
    public abstract List<Ingredient> IngredientsPerPerson { get; }
    public abstract List<string> Instructions { get; }
    public bool IsFavorite { get; set; }
}
