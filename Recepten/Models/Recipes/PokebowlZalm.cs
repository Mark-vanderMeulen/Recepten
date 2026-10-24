namespace Recepten.Models.Recipes;

public class PokebowlZalm : Recipe
{
    public override string Identifier { get; } = nameof(PokebowlZalm);
    public override string Name { get; } = "Pokébowl met zalm";
    public override Category? Categories { get; }
    public override string? Description { get; }
    public override List<Ingredient> IngredientsPerPerson { get; } =
    [
        new("Sushirijst", 90, "gram"),
        new("Gerookte zalm", 100, "gram"),
        new("Komkommer"),
        new("Avocado", 1),
        new("Ui en/of lente-ui", 1),
        new("Wortel (optioneel)"),
        new("Mayonnaise"),
        new("Chilisaus (zoet)"),
        new("Sesamzaadjes (optioneel)")
    ];

    public override List<string> Instructions { get; } =
    [
        "Bereid de sushirijst volgens de instructies op de verpakking",
        "Snipper de ui",
        "Bak de ui glazig",
        "Snij ondertussen de groenten in stukjes",
        "Snij de zalm in stukjes",
        "Doe de rijst in een kom",
        "Verdeel alle toppings over de rijst",
        "Meng de mayonnaise en chilisaus 50/50",
        "Verteel de saus over de kom"
    ];
}
