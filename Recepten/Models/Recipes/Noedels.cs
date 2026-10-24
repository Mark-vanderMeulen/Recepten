namespace Recepten.Models.Recipes;

public class Noedels : Recipe
{
    public override string Identifier { get; } = nameof(Noedels);
    public override string Name { get; } = "Noedels";
    public override Category? Categories { get; }
    public override string? Description { get; }
    public override List<Ingredient> IngredientsPerPerson { get; } =
    [
        new("Ui", 0.5),
        new("Knoflook", 1, "teen"),
        new("Paprika", 0.5),
        new("Prei", 0.5),
        new("Noedels"),
        new("Ei", 1),
        new("Zout")
    ];

    public override List<string> Instructions { get; } =
    [
        "Snipper de ui",
        "Snij de paprika en prei in stukjes",
        "Snij de knoflook fijn",
        "Bak alles in de pan",
        "Voeg na een paar minuten de kruiden toe",
        "Breng het water aan de kook",
        "Kook de noedels voor een paar minuten",
        "Giet de noedels af",
        "Mix de noedels met de groenten",
        "Bak de eieren"
    ];
}
