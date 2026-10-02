using Billing;

namespace Billing.Tests;

internal static class TestData
{
    public static Invoice ValidInvoice() =>
        new()
        {
            Number = "FV-2026-0001",
            Customer = new Customer("Pekárna U Mlýna s.r.o.", Ico: "12345678"),
            IssueDate = new DateOnly(2026, 10, 7),
            DueDate = new DateOnly(2026, 10, 21),
            Lines =
            {
                new InvoiceLine("Chléb", 10m, 45.50m, 0.12m),
                new InvoiceLine("Rozvoz", 1m, 250m, 0.21m),
            },
        };
}
