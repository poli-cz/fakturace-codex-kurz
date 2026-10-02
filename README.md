# Fakturace

Vzorový projekt ke kurzu OpenAI Codex a agentní vývoj (ICT Pro). Malá doména vydaných faktur: položky, výpočty s DPH, validace.

- `src/Billing` – doména (Invoice, InvoiceLine, Customer), výpočty (InvoiceCalculator), kontroly (InvoiceValidator)
- `tests/Billing.Tests` – testy (xUnit)

```
dotnet build Fakturace.slnx
dotnet test Fakturace.slnx
```

Úlohy pro cvičení: [ULOHY.md](ULOHY.md).
