# Pola i właściwości klasy biznesowej: `Soneta.Core.DocPkg`
Nazwa tabeli: `DocPkgs`
Tytuł: Paczki dokumentów
Opis: Tabela przechowuje paczki dokumentów, czyli zestawy dokumentów przetwarzane razem w ramach jednego zgrupowania. Każda paczka posiada datę, numer, definicję, flagi, status przetwarzania oraz zakres dat obowiązywania.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokument`

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` |  |  |  |
| Date | `Soneta.Types.Date` | bazodanowe | Data | Data utworzenia paczki |
| Definicja | `Soneta.Core.DocPkgDef` | bazodanowe |  |  |
| ElementsCount | `int` |  |  |  |
| Flags | `Soneta.Business.Db.DocPkgFlags` | bazodanowe, enum | Flagi |  |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| PkgStatus | `Soneta.Business.Db.DocPkgStatus` | bazodanowe, enum | Status paczki dokumentów |  |
| Pozycje | `Soneta.Business.SubTable<Soneta.Core.DocPkgItem>` |  |  |  |
| Range | `Soneta.Types.FromTo` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DocPkgFlags (`Soneta.Business.Db.DocPkgFlags`)

### DocPkgStatus (`Soneta.Business.Db.DocPkgStatus`)
- `Opened` = 0 — Otwarta
- `Closed` = 1 — Zamknięta
