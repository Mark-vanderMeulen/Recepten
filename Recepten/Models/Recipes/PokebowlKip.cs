namespace Recepten.Models.Recipes;

public class PokebowlKip : Recipe
{
    public override string Identifier { get; } = nameof(PokebowlKip);
    public override string Name { get; } = "Pokébowl met kip";
    public override Category? Categories { get; }
    public override string? Description { get; }
    public override List<Ingredient> IngredientsPerPerson { get; } =
    [
        new("Sushirijst", 90, "gram"),
        new("Krokante kipburger", 1),
        new("Komkommer"),
        new("Ui en/of lente-ui", 1),
        new("Wortel"),
        new("Mayonnaise"),
        new("Chilisaus (zoet)"),
        new("Sesamzaadjes (optioneel)")
    ];

    public override List<string> Instructions { get; } =
    [
        "Bereid de sushirijst volgens de instructies op de verpakking",
        "Bak de kipburger volgens de instructies op de verpakking",
        "Snipper de ui",
        "Bak de ui glazig",
        "Snij ondertussen de groenten in stukjes",
        "Snij de kipburger in stukjes",
        "Doe de rijst in een kom",
        "Verdeel alle toppings over de rijst",
        "Meng de mayonnaise en chilisaus 50/50",
        "Verteel de saus over de kom"
    ];
}
