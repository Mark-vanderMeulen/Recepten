namespace Recepten.Models.Recipes;

public class Pompoenrisotto : Recipe
{
    public override string Identifier { get; } = nameof(Pompoenrisotto);
    public override string Name { get; } = "Pompoenrisotto";
    public override Category? Categories { get; }
    public override string? Description { get; }
    public override List<Ingredient> IngredientsPerPerson { get; } =
    [
        new("Risottorijst", 85, "gram"),
        new("Flespompoen", 0.25),
        new("Ui", 0.5),
        new("Parmezaanse kaas", 40, "gram"),
        new("(Droge) witte wijn", 75, "milliliter"),
        new("Bouillonblokje naar keuze", 0.5),
        new("Olijfolie")
    ];

    public override List<string> Instructions { get; } =
    [
        "Schil de pompoen en snij deze in stukjes van 1-2 centimeter",
        "Verdeel de stukjes pompoen over een ingevette ovenschaal",
        "Verdeel wat olijfolie over de stukjes pompoen",
        "Bak de stukjes pompoen 20 minuten in een voorverwarmde oven (180°C) - draai ze halverwege om",
        "To be continued..."
    ];
}
