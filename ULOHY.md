# Úlohy pro cvičení

Vzorový repozitář Fakturace (.NET 10, xUnit). Build a testy: `dotnet build Fakturace.slnx`, `dotnet test Fakturace.slnx`.

## Cvičení 1: slabé vs. dobré zadání

Vyberte jednu úlohu. Nejdřív ji zadejte agentovi jen slabým zadáním, pak stejnou úlohu v novém vlákně zadáním v pěti částech (cíl, výstup, rozsah, omezení, hotovo). Mezi pokusy vraťte repozitář do původního stavu (`git restore .` a `git clean -fd`).

| Úloha | Slabé zadání | Co má obsahovat dobré zadání |
|---|---|---|
| A. DIČ odběratele | „Přidej do faktur kontrolu DIČ.“ | kde (InvoiceValidator), formát CZ a SK, prázdné DIČ povoleno, chyba přes ValidationResult, testy |
| B. Sleva na položku | „Přidej slevy.“ | sleva v procentech 0 až 100 na položce, zaokrouhlení přes Money.Round, vliv na DPH, testy |
| C. Splatnost | „Ošetři splatnost.“ | splatnost nesmí být před datem vystavení, chyba přes ValidationResult, testy hraničních dnů |

Porovnejte: počet iterací, změněné soubory, prošly testy, dodržel agent zvyklosti projektu?

## Cvičení 2: AGENTS.md před a po

Vyberte jednu úlohu. Nejdřív ji zadejte bez AGENTS.md a výsledek si uložte (`git stash` nebo větev). Pak napište AGENTS.md (nebo upravte kostru z `/init`) a stejnou úlohu zadejte znovu v novém vlákně.

| Úloha | Zadání |
|---|---|
| D. Rekapitulace DPH | Přidej výpočet součtu základu a DPH po jednotlivých sazbách. |
| E. E-mail odběratele | Přidej kontrolu formátu e-mailu odběratele. |
| F. Export do CSV | Přidej export položek faktury do CSV. |

Každá úloha naráží na pravidlo projektu, které agent bez AGENTS.md snadno poruší. Které to je, zjistíte z kódu. Porovnejte výsledek před a po.

Pokročilí: zabalte postup jedné úlohy do skillu v `.agents/skills/`.
