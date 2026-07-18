# Pola i właściwości klasy biznesowej: `Soneta.BI.AnalysisAreaAppearance`
Nazwa tabeli: `AnalysisAreaApps`
Tytuł: Wyglądy obszarów
Opis: Element szczegółowy definicji obszaru (AnalysisAreaDefinition). Przechowuje konfigurację wyglądu obszaru merytorycznego, w szczególności kolor przypisany do obszaru, wyświetlany w interfejsie BI.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `AreaDefinition` → `AnalysisAreaDefinition`

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AreaDefinition | `Soneta.BI.AnalysisAreaDefinition` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Color | `UI.PastelColorPaletteBase` (enum) | bazodanowe | Kolor obszaru |  |

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
