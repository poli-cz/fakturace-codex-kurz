# Úlohy pro cvičení

Build a testy: `dotnet build Fakturace.slnx`, `dotnet test Fakturace.slnx`.
Mezi pokusy vraťte repozitář do původního stavu: `git restore .` a `git clean -fd`.

## Cvičení 1: slabé vs. dobré zadání

Vyberte jednu úlohu. Nejdřív ji agentovi zadejte jen větou z tabulky. Pak stejnou úlohu v novém
vlákně zadejte rozepsanou do pěti částí: cíl, výstup, rozsah, omezení, hotovo. Dobré zadání si
napište sami, jak byste ho dali kolegovi.

| Úloha | Slabé zadání |
|---|---|
| A. DIČ odběratele | „Přidej do faktur kontrolu DIČ.“ |
| B. Sleva na položku | „Přidej slevy.“ |
| C. Splatnost | „Ošetři splatnost.“ |

Porovnejte: počet iterací, změněné soubory, prošly testy, udělal agent to, co jste chtěli?

## Cvičení 2: AGENTS.md před a po

Vyberte jednu úlohu. Nejdřív ji zadejte bez AGENTS.md a výsledek si uložte (`git stash` nebo
větev). Pak napište AGENTS.md (nebo upravte kostru z `/init`) a stejnou úlohu zadejte znovu
v novém vlákně.

| Úloha | Zadání |
|---|---|
| D. Rekapitulace DPH | „Přidej výpočet součtu základu a DPH po jednotlivých sazbách.“ |
| E. E-mail odběratele | „Přidej kontrolu formátu e-mailu odběratele.“ |
| F. Export do CSV | „Přidej export položek faktury do CSV.“ |

Porovnejte výsledek před a po.

Pokročilí: zabalte postup jedné úlohy do skillu v `.agents/skills/`.
