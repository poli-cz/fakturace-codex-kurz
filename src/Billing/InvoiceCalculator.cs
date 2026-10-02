namespace Billing;

/// <summary>Výpočty částek faktury. Každý mezivýsledek se zaokrouhluje přes Money.Round.</summary>
public static class InvoiceCalculator
{
    public static decimal LineTotal(InvoiceLine line) =>
        Money.Round(line.Quantity * line.UnitPrice);

    public static decimal LineVat(InvoiceLine line) =>
        Money.Round(LineTotal(line) * line.VatRate);

    public static decimal TotalWithoutVat(Invoice invoice) =>
        invoice.Lines.Sum(LineTotal);

    public static decimal TotalVat(Invoice invoice) =>
        invoice.Lines.Sum(LineVat);

    public static decimal TotalWithVat(Invoice invoice) =>
        TotalWithoutVat(invoice) + TotalVat(invoice);
}
