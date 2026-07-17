# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Models.SalesPlans.DefRealizacjiPlanu`
Nazwa tabeli: `DefRealPlanow`
Tytuł: Definicje realizacji planów sprzedażowych
Opis: Szablon definicji realizacji planu sprzedażowego określający sposób wyliczania wartości netto lub brutto oraz rolę opiekuna. Umożliwia konfigurację algorytmów i filtrowanie realizacji według towarów i kontrahentów.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 13
- pola kalkulowane (z klas biznesowych): 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AktywnyAlgorytm | `bool` |  |  |  |
| AlgorytmPlanu | `Soneta.Zadania.Models.SalesPlans.AlgorytmPlanu` | bazodanowe |  | Algorytm dla definicji algorytmu planu sprzedaży |
| AlgorytmPlanu.Aktywny | `bool` | bazodanowe |  |  |
| AlgorytmPlanu.Kod | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Blokada | `bool` | bazodanowe | Zablokowana | Określa zablokowanie definicji. Zablokowane definicje nie będą wyświetlane w liście wyboru. |
| ClassName | `string` |  |  |  |
| DefaultFileName | `string` |  |  |  |
| DefaultIdentifier | `string` |  |  |  |
| DefaultProject | `Soneta.Business.Compiler.RuntimeProject` |  |  |  |
| Documents | `System.Collections.Generic.IEnumerable<Soneta.Business.Compiler.IRuntimeDocument>` |  |  |  |
| KodAlgorytmu | `Soneta.Business.MemoText` |  |  |  |
| Kontrahenci | `Soneta.Business.SubTable<Soneta.Zadania.Models.SalesPlans.KontrahentRealizacji>` |  |  |  |
| Namespace | `object` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NettoBrutto | `Soneta.Zadania.Enums.NettoBrutto` | bazodanowe, enum | Netto/Brutto | Określa czy realizacja ma być wyliczana po wartości netto czy brutto |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| RolaOpiekun | `Soneta.CRM.Config.RolaOpiekun` | bazodanowe | Rola opiekuna | Określa wg jakiej roli opiekuna ma być wyliczane realizacja planu |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| Symbol | `string` | bazodanowe |  |  |
| Towary | `Soneta.Business.SubTable<Soneta.Zadania.Models.SalesPlans.TowarRealizacji>` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### NettoBrutto (`Soneta.Zadania.Enums.NettoBrutto`)
- `Netto` = 0
- `Brutto` = 1
