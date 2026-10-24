namespace Recepten.Models.Recipes;

public class VerseTomatenpasta : Recipe
{
    public override string Identifier { get; } = nameof(VerseTomatenpasta);
    public override string Name { get; } = "Verse tomatenpasta";
    public override string? Description { get; }
    public override List<Ingredient> IngredientsPerPerson { get; } =
    [
        new("Ui", 0.5),
        new("Knoflook", 1, "teen"),
        new("Tomaat", 125, "gram"),
        new("Pasta", 80, "gram"),
        new("Burrata", 0.5, "bol"),
        new("Basilicum", 0.5, "handjevol"),
        new("Parmezaanse kaas", 20, "gram"),
        new("(Buine) suiker", 20, "gram")
    ];

    public override List<string> Instructions { get; } =
    [
        "Halveer de tomaten",
        "Verdeel de suiker in een koekenpan",
        "Doe een beetje olie in de pan",
        "Verdeel de tomaten over de pan",
        "Bak totdat de velletjes los komen van de tomaten",
        "Blend de tomaten, burrata, basilicum en de helft van de parmezaanse kaas",
        "Snipper de ui",
        "Snij de knoflook fijn",
        "Bak de ui en knoflook tot de ui glazig is",
        "Breng het water aan de kook",
        "Kook de pasta volgens de instructies op de verpakking",
        "Giet de pasta af",
        "Voeg de (geblende) saus toe aan de ui en knoflook",
        "Meng de gekookte pasta met de saus"
    ];
}
