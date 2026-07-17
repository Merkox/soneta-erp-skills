# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Models.SalesPlans.DefPlanuSprzedazy`
Nazwa tabeli: `DefPlanSprzed`
Tytuł: Definicje planów sprzedażowych
Opis: Szablon planu sprzedażowego określający typ, numerację, algorytm wyliczeń oraz domyślną definicję realizacji. Stanowi bazę konfiguracyjną dla tworzenia planów sprzedażowych operatorów i zespołów.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe: 15
- pola kalkulowane (z klas biznesowych): 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AktywnyAlgorytm | `bool` |  |  |  |
| AlgorytmPlanu | `Soneta.Zadania.Models.SalesPlans.AlgorytmPlanu` | bazodanowe |  | Algorytm dla definicji algorytmu planu sprzedaży |
| AlgorytmPlanu.Aktywny | `bool` | bazodanowe |  |  |
| AlgorytmPlanu.Kod | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Blokada | `bool` | bazodanowe | Zablokowana | Określa zablokowanie definicji. Zablokowane definicje nie będą wyświetlane w liście wyboru. |
| ChildDefinition | `Soneta.Zadania.Models.SalesPlans.DefPlanuSprzedazy` | bazodanowe | Definicja podrzędnych | Definicja planów podrzędnych generowanych przy utworzeniu planu |
| ClassName | `string` |  |  |  |
| DefRealizacjiPlanu | `Soneta.Zadania.Models.SalesPlans.DefRealizacjiPlanu` | bazodanowe |  | Domyślna definicja realizacji planu sprzedaży |
| DefaultFileName | `string` |  |  |  |
| DefaultIdentifier | `string` |  |  |  |
| DefaultProject | `Soneta.Business.Compiler.RuntimeProject` |  |  |  |
| Documents | `System.Collections.Generic.IEnumerable<Soneta.Business.Compiler.IRuntimeDocument>` |  |  |  |
| Generuj | `bool` | bazodanowe | Generuj podrzędne | Automatyczne generowanie podrzędnych planów |
| KodAlgorytmu | `Soneta.Business.MemoText` |  |  |  |
| Namespace | `object` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| Symbol | `string` | bazodanowe |  |  |
| Typ | `Soneta.Zadania.Enums.SalePlanType` | bazodanowe, enum |  | Określa typ planu sprzedażowego |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### SalePlanType (`Soneta.Zadania.Enums.SalePlanType`)
- `Yearly` = 0 — Roczny
- `Quarterly` = 1 — Kwartalny
- `Monthly` = 2 — Miesięczny
- `Periodic` = 3 — Okresowy
