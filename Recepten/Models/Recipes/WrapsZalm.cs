namespace Recepten.Models.Recipes;

public class WrapsZalm : Recipe
{
    public override string Identifier { get; } = nameof(WrapsKip);
    public override string Name { get; } = "Wraps met zalm";
    public override Category? Categories { get; }
    public override string? Description { get; }
    public override List<Ingredient> IngredientsPerPerson { get; } =
    [
        new("Wraps", 2),
        new("Gerookte zalm", 100, "gram"),
        new("Sla"),
        new("Tomaat"),
        new("Komkommer"),
        new("Roomkaas")
    ];

    public override List<string> Instructions { get; } =
    [
        "Snij de groenten in stukjes",
        "Snij de zalm in stukjes",
        "Smeer een laagje roomkaas op de wrap(s)",
        "Verdeel de zalm en groenten over de wraps",
        "Rol de wraps op"
    ];
}
