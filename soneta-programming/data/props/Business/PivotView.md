# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.PivotView`
Nazwa tabeli: `PivotViews`
Tytuł: Raporty przestawne
Opis: Definicja raportu przestawnego (tabeli przestawnej). Określa typ źródła danych, nazwę, opis i możliwość indywidualizacji per operator.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`
Selektor: pole `Type` (`Db.PivotViewType`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataSource | `string` | bazodanowe | Źródło danych |  |
| DefaultStyles | `SubTable<Db.PivotViewDefaultStyle>` | podlista |  |  |
| Description | `string` | bazodanowe | Opis | Opisuje zawartość raportu przestawnego. |
| IndividualGuid | `System.Guid` | bazodanowe | Identyfikator operatora | Identyfikator właściciela raportu przestawnego. |
| IsIndividual | `bool` | tylko-odczyt |  |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa raportu przestawnego wyświetlana w drzewie folderów. |
| Styles | `SubTable<Db.PivotViewStyle>` | podlista |  |  |
| Type | `Db.PivotViewType` (enum) | bazodanowe, tylko-odczyt, selektor | Typ | Typ źródła danych raportu przestawnego. |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Type`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `BI` | 1 | `Db.BIPivotView` |  |
| `CRM` | 2 | `Soneta.Zadania.Models.CRMPivotView` |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### PivotViewType (`Db.PivotViewType`)
- `BI` = 1
- `CRM` = 2
