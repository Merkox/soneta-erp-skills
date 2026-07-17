# Pola i właściwości klasy biznesowej: `Soneta.BI.AnalysisAreaDefinition`
Nazwa tabeli: `AnalysisAreaDefs`
Tytuł: Definicje obszarów
Opis: Definicja obszaru merytorycznego w module BI. Obszary tworzą hierarchiczną strukturę kategoryzacji modeli danych i wizualizacji (np. Sprzedaż, Finanse, Kadry). Umożliwiają organizowanie analiz w logiczne grupy tematyczne.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Appearances | `Soneta.Business.SubTable<Soneta.BI.AnalysisAreaAppearance>` |  |  |  |
| AreaColor | `Soneta.Business.UI.PastelColorPaletteBase` | enum |  |  |
| AreaPath | `string` |  |  |  |
| Name | `string` | bazodanowe | Nazwa |  |
| Parent | `Soneta.BI.AnalysisAreaDefinition` | bazodanowe | Definicja nadrzędna |  |
| Subareas | `Soneta.Business.SubTable<Soneta.BI.AnalysisAreaDefinition>` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### PastelColorPaletteBase (`Soneta.Business.UI.PastelColorPaletteBase`)
- `Green` = 0 — Zielony
- `ForestGreen` = 1 — Zielony leśny
- `Lime` = 2 — Limonkowy
- `Sea` = 3 — Morski
- `DeepSea` = 4 — Morska głębia
- `Blue` = 5 — Niebieski
- `NavyBlue` = 6 — Granatowy
- `Violet` = 7 — Fioletowy
- `Red` = 8 — Czerwony
- `Yellow` = 9 — Żółty
- `Brown` = 10 — Brązowy
- `Neutral` = 11 — Neutralny
