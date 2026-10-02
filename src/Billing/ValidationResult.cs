namespace Billing;

/// <summary>Výsledek validace. Validátory chyby sbírají, nevyhazují výjimky.</summary>
public sealed class ValidationResult
{
    private readonly List<string> _errors = new();

    public IReadOnlyList<string> Errors => _errors;

    public bool IsValid => _errors.Count == 0;

    public void Add(string error) => _errors.Add(error);
}
