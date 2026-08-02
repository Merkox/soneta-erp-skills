# Moduł `Przeszeregowania` — tabele biznesowe

- Opis: Moduł obsługujący przeszeregowania pracowników. Zawiera mechanizmy masowych zmian warunków zatrudnienia, wynagrodzeń i stanowisk.
- Tabel: **2**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| ElementPrzeszeregowania | Elementy przeszeregowań | `ElementyPrzeszer` |  | child: Przeszeregowanie→Przeszeregowanie |  |  | RodzajPrzeszergowania (6) | [ElementPrzeszeregowania.md](ElementPrzeszeregowania.md) |
| Przeszeregowanie | Przeszeregowania pracowników | `Przeszeregowania` |  | root |  |  |  | [Przeszeregowanie.md](Przeszeregowanie.md) |

