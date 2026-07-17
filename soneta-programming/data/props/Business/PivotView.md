# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.PivotView`
Nazwa tabeli: `PivotViews`
Tytuł: Raporty przestawne
Opis: Definicja raportu przestawnego (tabeli przestawnej). Określa typ źródła danych, nazwę, opis i możliwość indywidualizacji per operator.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataSource | `string` | bazodanowe | Źródło danych |  |
| DefaultStyles | `Soneta.Business.SubTable<Soneta.Business.Db.PivotViewDefaultStyle>` |  |  |  |
| Description | `string` | bazodanowe | Opis | Opisuje zawartość raportu przestawnego. |
| IndividualGuid | `System.Guid` | bazodanowe | Identyfikator operatora | Identyfikator właściciela raportu przestawnego. |
| IsIndividual | `bool` |  |  |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa raportu przestawnego wyświetlana w drzewie folderów. |
| Styles | `Soneta.Business.SubTable<Soneta.Business.Db.PivotViewStyle>` |  |  |  |
| Type | `Soneta.Business.Db.PivotViewType` | bazodanowe, enum | Typ | Typ źródła danych raportu przestawnego. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### PivotViewType (`Soneta.Business.Db.PivotViewType`)
- `BI` = 1
- `CRM` = 2
