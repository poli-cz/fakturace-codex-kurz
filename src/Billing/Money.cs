namespace Billing;

/// <summary>Práce s peněžními částkami. Částky jsou vždy decimal.</summary>
public static class Money
{
    /// <summary>Zaokrouhlí částku na haléře (2 desetinná místa, polovina nahoru od nuly).</summary>
    public static decimal Round(decimal amount) =>
        Math.Round(amount, 2, MidpointRounding.AwayFromZero);
}
