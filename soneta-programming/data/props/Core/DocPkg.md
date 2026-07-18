# Pola i właściwości klasy biznesowej: `Soneta.Core.DocPkg`
Nazwa tabeli: `DocPkgs`
Tytuł: Paczki dokumentów
Opis: Tabela przechowuje paczki dokumentów, czyli zestawy dokumentów przetwarzane razem w ramach jednego zgrupowania. Każda paczka posiada datę, numer, definicję, flagi, status przetwarzania oraz zakres dat obowiązywania.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokument`

- pola bazodanowe (zapisywalne): 6
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 3
- podlisty: 4
- subrowy: 1
- razem: 15

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | tylko-odczyt |  |  |
| Date | `Date` | bazodanowe | Data | Data utworzenia paczki |
| Definicja | `Soneta.Core.DocPkgDef` | bazodanowe |  |  |
| ElementsCount | `int` | tylko-odczyt |  |  |
| Flags | `Db.DocPkgFlags` (enum) | bazodanowe | Flagi |  |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| PkgStatus | `Db.DocPkgStatus` (enum) | bazodanowe | Status paczki dokumentów |  |
| Pozycje | `SubTable<Soneta.Core.DocPkgItem>` | podlista |  |  |
| Range | `FromTo` | bazodanowe, podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DocPkgFlags (`Db.DocPkgFlags`)

### DocPkgStatus (`Db.DocPkgStatus`)
- `Opened` = 0 — Otwarta
- `Closed` = 1 — Zamknięta
