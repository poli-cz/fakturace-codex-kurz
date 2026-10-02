namespace Billing;

/// <summary>Položka faktury. UnitPrice je cena za jednotku bez DPH.</summary>
public sealed record InvoiceLine(string Description, decimal Quantity, decimal UnitPrice, decimal VatRate);
