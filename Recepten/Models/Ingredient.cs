using System.Diagnostics.CodeAnalysis;

namespace Recepten.Models;

public class Ingredient
{
    public required string Name { get; set; }
    public double? Amount { get; set; }
    public string? Unit { get; set; }

    [SetsRequiredMembers]
    public Ingredient(string name, double? amount = null, string? unit = null)
    {
        Name = name;
        Amount = amount;
        Unit = unit;
    }

    public string GetLabel(double multiplier)
    {
        var label = Name;

        if (Amount != null)
        {
            label += $" ({Amount * multiplier}";

            if (!string.IsNullOrEmpty(Unit))
                label += $" {Unit}";

            label += ")";
        }

        return label;
    }
}
