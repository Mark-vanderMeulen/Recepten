namespace Recepten.Models.Recipes;

public class CitroenZalmPasta : Recipe
{
    public override string Identifier { get; } = nameof(CitroenZalmPasta);
    public override string Name { get; } = "Citroenpasta met zalm";
    public override string? Description { get; }
    public override List<Ingredient> IngredientsPerPerson { get; } =
    [
        new("Ui", 0.5),
        new("Knoflook", 1, "teen"),
        new("Citroen", 0.5),
        new("Pasta", 80, "gram"),
        new("Parmezaanse kaas", 20, "gram"),
        new("Kookroom", 125, "milliliter")
    ];

    public override List<string> Instructions { get; } =
    [
        "Rasp de citroen",
        "Pers de citroen",
        "Rasp de parmezaanse kaas",
        "Snipper de ui",
        "Snij de knoflook fijn",
        "Doe een beetje olie in de pan",
        "Bak de ui en knoflook tot de ui glazig is",
        "Voeg de kookroom toe",
        "Voeg de citroenrasp en het citroensap toe",
        "Voeg de parmezaanse kaas toe",
        "Breng het water aan de kook",
        "Kook de pasta volgens de instructies op de verpakking",
        "Snij ondertussen de zalm in stukjes",
        "Giet de pasta af",
        "Meng de gekookte pasta met de saus",
        "Meng de zalm er kort doorheen"
    ];
}
