namespace Recepten.Models.Recipes;

public class Pompoenrisotto : Recipe
{
    public override string Identifier { get; } = nameof(Pompoenrisotto);
    public override string Name { get; } = "Pompoenrisotto";
    public override string? Description { get; }
    public override List<Ingredient> IngredientsPerPerson { get; } =
    [
        new("Risottorijst", 75, "gram"),
        new("Flespompoen", 0.25),
        new("Ui", 0.5),
        new("Parmezaanse kaas", 40, "gram"),
        new("(Droge) witte wijn", 50, "milliliter"),
        new("Bouillonblokje naar keuze", 0.5),
        new("Water", 500, "milliliter"),
        new("Ongezouten roomboter", 15, "gram"),
        new("Olijfolie")
    ];

    public override List<string> Instructions { get; } =
    [
        "Schil de pompoen en snij deze in stukjes van 1-2 centimeter",
        "Verdeel de stukjes pompoen over een ingevette ovenschaal",
        "Verdeel wat olijfolie over de stukjes pompoen",
        "Bak de stukjes pompoen 20 minuten in een voorverwarmde oven (180°C) - draai ze halverwege om",
        "Breng het water met bouillonblokje aan de kook",
        "Snipper de ui",
        "Bak de ui ~8 minuten in een beetje olijfolie, tot deze glazig is",
        "Voeg de rijst toe en bak 3 minuten mee, tot deze glazig is",
        "Schenk de wijn er in één keer bij en roer op hoog vuur tot het vocht is opgenomen",
        "Voeg een scheutje bouillon toe en blijf roeren tot deze is opgenomen",
        "Herhaal dit scheutje voor scheutje met de rest van de bouillon",
        "Kook op middelhoog vuur tot de risotto beetgaar is - dit duurt ~25 minuten",
        "De risotto is klaar als het een romig geheel is, het mag nog een beetje nat zijn",
        "Breng op smaak met peper en eventueel zout",
        "Pureer de helft van de pompoen met een staafmixer",
        "Rasp de parmezaanse kaas",
        "Haal de pan van het vuur en meng de helft van de geraspte kaas, de boter en de pompoenpuree door de risotto",
        "Verdeel de risotto over de borden en verdeel de rest van de pompoen en kaas erover"
    ];
}
