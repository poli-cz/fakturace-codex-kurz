namespace Billing;

/// <summary>Povolené sazby DPH jako desetinné číslo (0,21 = 21 %).</summary>
public static class VatRates
{
    public static readonly IReadOnlyList<decimal> Allowed = [0m, 0.12m, 0.21m];
}
