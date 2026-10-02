using Billing;

namespace Billing.Tests;

public class InvoiceCalculatorTests
{
    [Fact]
    public void LineTotal_je_mnozstvi_krat_cena()
    {
        var line = new InvoiceLine("Chléb", 10m, 45.50m, 0.12m);
        Assert.Equal(455.00m, InvoiceCalculator.LineTotal(line));
    }

    [Fact]
    public void LineTotal_zaokrouhluje_polovinu_nahoru()
    {
        var line = new InvoiceLine("Drobnost", 1m, 0.125m, 0.21m);
        Assert.Equal(0.13m, InvoiceCalculator.LineTotal(line));
    }

    [Fact]
    public void LineVat_se_pocita_ze_zaokrouhleneho_zakladu()
    {
        var line = new InvoiceLine("Rozvoz", 1m, 250m, 0.21m);
        Assert.Equal(52.50m, InvoiceCalculator.LineVat(line));
    }

    [Fact]
    public void Soucty_faktury()
    {
        var invoice = TestData.ValidInvoice();
        Assert.Equal(705.00m, InvoiceCalculator.TotalWithoutVat(invoice));
        Assert.Equal(107.10m, InvoiceCalculator.TotalVat(invoice));
        Assert.Equal(812.10m, InvoiceCalculator.TotalWithVat(invoice));
    }
}
