namespace Billing;

/// <summary>Vydaná faktura.</summary>
public sealed class Invoice
{
    public required string Number { get; init; }

    public required Customer Customer { get; init; }

    public DateOnly IssueDate { get; init; }

    public DateOnly DueDate { get; init; }

    public List<InvoiceLine> Lines { get; } = new();
}
