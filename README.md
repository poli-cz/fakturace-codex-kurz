# Fakturace

Vzorový projekt ke kurzu OpenAI Codex a agentní vývoj (ICT Pro). Malá vymyšlená doména vydaných faktur:
položky, výpočty s DPH, validace. Žádný firemní kód, smíte ho dát jakémukoli agentovi.

- `src/Billing` – doména (Invoice, InvoiceLine, Customer), výpočty (InvoiceCalculator), kontroly (InvoiceValidator)
- `tests/Billing.Tests` – testy (xUnit)

## Začátek (Windows)

```powershell
winget install Microsoft.DotNet.SDK.10      # jen pokud dotnet --version nehlásí 10.x
git clone https://github.com/poli-cz/fakturace-codex-kurz
cd fakturace-codex-kurz
dotnet test Fakturace.slnx                  # 11 testů, všechny zelené
codex                                       # Codex spouštějte v adresáři repozitáře
```

Na macOS a Linuxu stejně, jen .NET 10 SDK z https://dotnet.microsoft.com/download.

Mezi pokusy vraťte repozitář do původního stavu:

```
git restore .
git clean -fd
```

Úlohy pro cvičení: [ULOHY.md](ULOHY.md).
