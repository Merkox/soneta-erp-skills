# Pola i właściwości klasy biznesowej: `Soneta.Core.DbTuples.DbTuple`
Nazwa tabeli: `Tuples`
Tytuł: Dokumenty dodatkowe
Opis: Dokument dodatkowy (zdarzenie, formularz dynamiczny) tworzony na podstawie definicji. Zawiera numer, serię, datę, termin, okres, powiązanie z dokumentem podstawowym, relację podstawową oraz pola dynamiczne definiowane w konfiguracji.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IŹródłoPowiązaniaStrukturyOrganizacyjnej`, `IDokument`, `IManagedRowInfoHost`, `IPoświadczenieOdbioruHost`

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BasicDocument | `Soneta.Core.Dms.IBasicDocument` | bazodanowe | Dokument podstawowy | Dokument podstawowy |
| Data | `Soneta.Types.Date` | bazodanowe | Data | Data dokumentu |
| Definicja | `Soneta.Core.DbTuples.DbTupleDefinition` | bazodanowe | Definicja | Definicja dokumentu |
| Fields | `Soneta.Business.Runtime.RuntimeFields` | bazodanowe |  |  |
| Fields.Code | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Host | `Soneta.Business.GuidedRow` |  |  |  |
| IsSignatureRequired | `bool` |  |  |  |
| ManagedState | `Soneta.Core.ManagedRowStates` | enum |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe | Okres | Okres zdarzenia |
| Opis | `string` |  |  |  |
| PowiązaniaStrOrg | `Soneta.Business.SubTable<Soneta.Core.PowiązanieStrukturyOrganizacyjnej>` |  |  |  |
| PoświadczeniaOdbioru | `Soneta.Business.SubTable<Soneta.Core.PoświadczenieOdbioru>` |  |  |  |
| PoświadczenieOdbioru | `Soneta.Core.PoświadczenieOdbioru` |  |  |  |
| RelacjaPodstawowa | `Soneta.Business.IGuidedRow` | bazodanowe | Relacja podstawowa | Relacja podstawowa |
| Relations | `Soneta.Business.SubTable<Soneta.Core.DbTuples.DbTupleRel>` |  |  |  |
| Seria | `string` | bazodanowe |  |  |
| Termin | `Soneta.Types.Date` | bazodanowe | Termin | Data zdarzenia |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ManagedRowStates (`Soneta.Core.ManagedRowStates`)
- `Pending` = 1 — Wprowadzany
- `Active` = 2 — Przetwarzany
- `Finished` = 3 — Zakończony
- `Abandoned` = 4 — Porzucony
- `Removed` = 5 — Usunięty
