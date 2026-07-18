# Pola i właściwości klasy biznesowej: `Soneta.Core.DbTuples.DbTuple`
Nazwa tabeli: `Tuples`
Tytuł: Dokumenty dodatkowe
Opis: Dokument dodatkowy (zdarzenie, formularz dynamiczny) tworzony na podstawie definicji. Zawiera numer, serię, datę, termin, okres, powiązanie z dokumentem podstawowym, relację podstawową oraz pola dynamiczne definiowane w konfiguracji.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IŹródłoPowiązaniaStrukturyOrganizacyjnej`, `IDokument`, `IManagedRowInfoHost`, `IPoświadczenieOdbioruHost`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BasicDocument | `Soneta.Core.Dms.IBasicDocument` | bazodanowe, tylko-odczyt | Dokument podstawowy | Dokument podstawowy |
| Data | `Date` | bazodanowe | Data | Data dokumentu |
| Definicja | `Soneta.Core.DbTuples.DbTupleDefinition` | bazodanowe, tylko-odczyt | Definicja | Definicja dokumentu |
| Fields | `Runtime.RuntimeFields` (subrow) | bazodanowe |  |  |
| Fields.Code | `MemoText` | bazodanowe, podlista |  |  |
| Host | `GuidedRow` | tylko-odczyt |  |  |
| IsSignatureRequired | `bool` | tylko-odczyt |  |  |
| ManagedState | `Soneta.Core.ManagedRowStates` (enum) | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| Okres | `FromTo` | bazodanowe, podlista | Okres | Okres zdarzenia |
| Opis | `string` | tylko-odczyt |  |  |
| PowiązaniaStrOrg | `SubTable<Soneta.Core.PowiązanieStrukturyOrganizacyjnej>` | podlista |  |  |
| PoświadczeniaOdbioru | `SubTable<Soneta.Core.PoświadczenieOdbioru>` | podlista |  |  |
| PoświadczenieOdbioru | `Soneta.Core.PoświadczenieOdbioru` | tylko-odczyt |  |  |
| RelacjaPodstawowa | `IGuidedRow` | bazodanowe | Relacja podstawowa | Relacja podstawowa |
| Relations | `SubTable<Soneta.Core.DbTuples.DbTupleRel>` | podlista |  |  |
| Seria | `string` | bazodanowe |  |  |
| Termin | `Date` | bazodanowe | Termin | Data zdarzenia |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ManagedRowStates (`Soneta.Core.ManagedRowStates`)
- `Pending` = 1 — Wprowadzany
- `Active` = 2 — Przetwarzany
- `Finished` = 3 — Zakończony
- `Abandoned` = 4 — Porzucony
- `Removed` = 5 — Usunięty
