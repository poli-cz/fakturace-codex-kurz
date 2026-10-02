namespace Billing;

/// <summary>Kontroly faktury před uložením.</summary>
public static class InvoiceValidator
{
    public static ValidationResult Validate(Invoice invoice)
    {
        var result = new ValidationResult();

        if (string.IsNullOrWhiteSpace(invoice.Number))
            result.Add("Faktura musí mít číslo.");

        if (string.IsNullOrWhiteSpace(invoice.Customer.Name))
            result.Add("Odběratel musí mít název.");

        if (invoice.Customer.Ico is { } ico && !IsValidIco(ico))
            result.Add("IČO musí mít 8 číslic.");

        if (invoice.Lines.Count == 0)
            result.Add("Faktura musí mít aspoň jednu položku.");

        foreach (var line in invoice.Lines)
        {
            if (line.Quantity <= 0)
                result.Add($"Položka „{line.Description}“ musí mít kladné množství.");

            if (line.UnitPrice < 0)
                result.Add($"Položka „{line.Description}“ nesmí mít zápornou cenu.");

            if (!VatRates.Allowed.Contains(line.VatRate))
                result.Add($"Položka „{line.Description}“ má nepovolenou sazbu DPH.");
        }

        return result;
    }

    private static bool IsValidIco(string ico) =>
        ico.Length == 8 && ico.All(char.IsAsciiDigit);
}
