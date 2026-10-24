namespace Recepten.Models.Recipes;

public class WrapsKip : Recipe
{
    public override string Identifier { get; } = nameof(WrapsKip);
    public override string Name { get; } = "Wraps met kip";
    public override Category? Categories { get; }
    public override string? Description { get; }
    public override List<Ingredient> IngredientsPerPerson { get; } =
    [
        new("Wraps", 2),
        new("Krokante kipburger", 1),
        new("Sla"),
        new("Tomaat"),
        new("Komkommer"),
        new("Wortel (optioneel)"),
        new("Knoflooksaus")
    ];

    public override List<string> Instructions { get; } =
    [
        "Bak de kipburger volgens de instructies op de verpakking",
        "Snij ondertussen de groenten in stukjes",
        "Snij de gebakken kipburger in stukjes",
        "Doe wat knoflooksaus op de wrap(s)",
        "Verdeel de kip en groenten over de wraps",
        "Rol de wraps op"
    ];
}
