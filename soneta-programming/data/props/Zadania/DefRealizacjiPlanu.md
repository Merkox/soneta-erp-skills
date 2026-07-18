# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Models.SalesPlans.DefRealizacjiPlanu`
Nazwa tabeli: `DefRealPlanow`
Tytuł: Definicje realizacji planów sprzedażowych
Opis: Szablon definicji realizacji planu sprzedażowego określający sposób wyliczania wartości netto lub brutto oraz rolę opiekuna. Umożliwia konfigurację algorytmów i filtrowanie realizacji według towarów i kontrahentów.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 9
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 5
- podlisty: 7
- subrowy: 2
- razem: 24

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AktywnyAlgorytm | `bool` |  |  |  |
| AlgorytmPlanu | `Soneta.Zadania.Models.SalesPlans.AlgorytmPlanu` (subrow) | bazodanowe |  | Algorytm dla definicji algorytmu planu sprzedaży |
| AlgorytmPlanu.Aktywny | `bool` | bazodanowe |  |  |
| AlgorytmPlanu.Kod | `MemoText` | bazodanowe, podlista |  |  |
| Blokada | `bool` | bazodanowe | Zablokowana | Określa zablokowanie definicji. Zablokowane definicje nie będą wyświetlane w liście wyboru. |
| ClassName | `string` | tylko-odczyt |  |  |
| DefaultFileName | `string` | tylko-odczyt |  |  |
| DefaultIdentifier | `string` | tylko-odczyt |  |  |
| DefaultProject | `Compiler.RuntimeProject` | tylko-odczyt |  |  |
| Documents | `System.Collections.Generic.IEnumerable<Compiler.IRuntimeDocument>` | podlista |  |  |
| KodAlgorytmu | `MemoText` | podlista |  |  |
| Kontrahenci | `SubTable<Soneta.Zadania.Models.SalesPlans.KontrahentRealizacji>` | podlista |  |  |
| Namespace | `object` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NettoBrutto | `Soneta.Zadania.Enums.NettoBrutto` (enum) | bazodanowe | Netto/Brutto | Określa czy realizacja ma być wyliczana po wartości netto czy brutto |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| RolaOpiekun | `Soneta.CRM.Config.RolaOpiekun` | bazodanowe | Rola opiekuna | Określa wg jakiej roli opiekuna ma być wyliczane realizacja planu |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| Symbol | `string` | bazodanowe |  |  |
| Towary | `SubTable<Soneta.Zadania.Models.SalesPlans.TowarRealizacji>` | podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### NettoBrutto (`Soneta.Zadania.Enums.NettoBrutto`)
- `Netto` = 0
- `Brutto` = 1
