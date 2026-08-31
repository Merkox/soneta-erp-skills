# Pola i właściwości klasy biznesowej: `Soneta.BI.AnalysisAreaDefinition`
Nazwa tabeli: `AnalysisAreaDefs`
Tytuł: Definicje obszarów
Opis: Definicja obszaru merytorycznego w module BI. Obszary tworzą hierarchiczną strukturę kategoryzacji modeli danych i wizualizacji (np. Sprzedaż, Finanse, Kadry). Umożliwiają organizowanie analiz w logiczne grupy tematyczne.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Appearances | `SubTable<Soneta.BI.AnalysisAreaAppearance>` | podlista |  |  |
| AreaColor | `UI.PastelColorPaletteBase` (enum) | tylko-odczyt |  |  |
| AreaPath | `string` | tylko-odczyt |  |  |
| Name | `string` | bazodanowe | Nazwa |  |
| Parent | `Soneta.BI.AnalysisAreaDefinition` | bazodanowe, tylko-odczyt | Definicja nadrzędna |  |
| Subareas | `SubTable<Soneta.BI.AnalysisAreaDefinition>` | podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### PastelColorPaletteBase (`UI.PastelColorPaletteBase`)
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
