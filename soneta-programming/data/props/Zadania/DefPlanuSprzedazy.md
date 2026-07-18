# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Models.SalesPlans.DefPlanuSprzedazy`
Nazwa tabeli: `DefPlanSprzed`
Tytuł: Definicje planów sprzedażowych
Opis: Szablon planu sprzedażowego określający typ, numerację, algorytm wyliczeń oraz domyślną definicję realizacji. Stanowi bazę konfiguracyjną dla tworzenia planów sprzedażowych operatorów i zespołów.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe (zapisywalne): 11
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 5
- podlisty: 5
- subrowy: 2
- razem: 24

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AktywnyAlgorytm | `bool` |  |  |  |
| AlgorytmPlanu | `Soneta.Zadania.Models.SalesPlans.AlgorytmPlanu` (subrow) | bazodanowe |  | Algorytm dla definicji algorytmu planu sprzedaży |
| AlgorytmPlanu.Aktywny | `bool` | bazodanowe |  |  |
| AlgorytmPlanu.Kod | `MemoText` | bazodanowe, podlista |  |  |
| Blokada | `bool` | bazodanowe | Zablokowana | Określa zablokowanie definicji. Zablokowane definicje nie będą wyświetlane w liście wyboru. |
| ChildDefinition | `Soneta.Zadania.Models.SalesPlans.DefPlanuSprzedazy` | bazodanowe | Definicja podrzędnych | Definicja planów podrzędnych generowanych przy utworzeniu planu |
| ClassName | `string` | tylko-odczyt |  |  |
| DefRealizacjiPlanu | `Soneta.Zadania.Models.SalesPlans.DefRealizacjiPlanu` | bazodanowe |  | Domyślna definicja realizacji planu sprzedaży |
| DefaultFileName | `string` | tylko-odczyt |  |  |
| DefaultIdentifier | `string` | tylko-odczyt |  |  |
| DefaultProject | `Compiler.RuntimeProject` | tylko-odczyt |  |  |
| Documents | `System.Collections.Generic.IEnumerable<Compiler.IRuntimeDocument>` | podlista |  |  |
| Generuj | `bool` | bazodanowe | Generuj podrzędne | Automatyczne generowanie podrzędnych planów |
| KodAlgorytmu | `MemoText` | podlista |  |  |
| Namespace | `object` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| Symbol | `string` | bazodanowe |  |  |
| Typ | `Soneta.Zadania.Enums.SalePlanType` (enum) | bazodanowe |  | Określa typ planu sprzedażowego |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### SalePlanType (`Soneta.Zadania.Enums.SalePlanType`)
- `Yearly` = 0 — Roczny
- `Quarterly` = 1 — Kwartalny
- `Monthly` = 2 — Miesięczny
- `Periodic` = 3 — Okresowy
