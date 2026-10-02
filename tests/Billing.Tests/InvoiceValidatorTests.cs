using Billing;

namespace Billing.Tests;

public class InvoiceValidatorTests
{
    [Fact]
    public void Platna_faktura_projde()
    {
        var result = InvoiceValidator.Validate(TestData.ValidInvoice());
        Assert.True(result.IsValid);
    }

    [Fact]
    public void Chybejici_cislo_je_chyba()
    {
        var valid = TestData.ValidInvoice();
        var invoice = new Invoice { Number = "", Customer = valid.Customer, IssueDate = valid.IssueDate, DueDate = valid.DueDate };
        invoice.Lines.AddRange(valid.Lines);

        var result = InvoiceValidator.Validate(invoice);

        Assert.Contains("Faktura musí mít číslo.", result.Errors);
    }

    [Fact]
    public void Faktura_bez_polozek_je_chyba()
    {
        var invoice = new Invoice { Number = "FV-1", Customer = new Customer("Firma") };
        var result = InvoiceValidator.Validate(invoice);
        Assert.Contains("Faktura musí mít aspoň jednu položku.", result.Errors);
    }

    [Theory]
    [InlineData("1234567")]
    [InlineData("123456789")]
    [InlineData("1234567A")]
    public void Neplatne_ICO_je_chyba(string ico)
    {
        var valid = TestData.ValidInvoice();
        var invoice = new Invoice { Number = "FV-1", Customer = new Customer("Firma", Ico: ico) };
        invoice.Lines.AddRange(valid.Lines);

        var result = InvoiceValidator.Validate(invoice);

        Assert.Contains("IČO musí mít 8 číslic.", result.Errors);
    }

    [Fact]
    public void Nepovolena_sazba_DPH_je_chyba()
    {
        var invoice = new Invoice { Number = "FV-1", Customer = new Customer("Firma") };
        invoice.Lines.Add(new InvoiceLine("Zboží", 1m, 100m, 0.15m));

        var result = InvoiceValidator.Validate(invoice);

        Assert.False(result.IsValid);
    }
}
