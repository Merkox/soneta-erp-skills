# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.PivotView`
Nazwa tabeli: `PivotViews`
Tytuł: Raporty przestawne
Opis: Definicja raportu przestawnego (tabeli przestawnej). Określa typ źródła danych, nazwę, opis i możliwość indywidualizacji per operator.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 2
- subrowy: 0
- razem: 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataSource | `string` | bazodanowe | Źródło danych |  |
| DefaultStyles | `SubTable<Db.PivotViewDefaultStyle>` | podlista |  |  |
| Description | `string` | bazodanowe | Opis | Opisuje zawartość raportu przestawnego. |
| IndividualGuid | `System.Guid` | bazodanowe | Identyfikator operatora | Identyfikator właściciela raportu przestawnego. |
| IsIndividual | `bool` | tylko-odczyt |  |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa raportu przestawnego wyświetlana w drzewie folderów. |
| Styles | `SubTable<Db.PivotViewStyle>` | podlista |  |  |
| Type | `Db.PivotViewType` (enum) | bazodanowe, tylko-odczyt | Typ | Typ źródła danych raportu przestawnego. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### PivotViewType (`Db.PivotViewType`)
- `BI` = 1
- `CRM` = 2
