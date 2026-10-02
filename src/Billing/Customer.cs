namespace Billing;

/// <summary>Odběratel faktury.</summary>
public sealed record Customer(string Name, string? Ico = null, string? Dic = null, string? Email = null);
