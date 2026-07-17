# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.ElemOpisuAnalitycznego`
Nazwa tabeli: `OpisAnalityczny`
Tytuł: Opis analityczny
Opis: Element szczegółowy dokumentu ewidencji (DokEwidencji). Reprezentuje pojedynczą pozycję opisu analitycznego, przypisującą kwotę do wymiaru analitycznego (np. centrum kosztów, projektu). Obsługuje podzielniki kosztów, budżety projektów, rozliczenia międzyokresowe oraz powiązania z płatnościami i zapisami księgowymi.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Ewidencja` → `DokEwidencji`

- pola bazodanowe: 23
- pola kalkulowane (z klas biznesowych): 16

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BudzetProjWgKwotyDodatkowej | `bool` | bazodanowe |  |  |
| BudzetowanieRozszerzone | `bool` |  |  |  |
| CentrumKosztow | `Soneta.Core.CentrumKosztow` | bazodanowe | Centrum kosztów | Centrum kosztów |
| CzyRelacje | `bool` |  |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| DataOstatniegoRozliczenia | `Soneta.Types.Date` | bazodanowe | Data ostatniego rozliczenia | Data ostatniego rozliczenia |
| DataOstatniegoRozliczeniaDod | `Soneta.Types.Date` | bazodanowe | Data ostatniego rozliczenia dodatkowego | Data ostatniego rozliczenia dodatkowego |
| DataPierwszegoRozliczenia | `Soneta.Types.Date` | bazodanowe | Data pierwszego rozliczenia | Data pierwszego rozliczenia |
| DataPierwszegoRozliczeniaDod | `Soneta.Types.Date` | bazodanowe | Data pierwszego rozliczenia dodatkowego | Data pierwszego rozliczenia dodatkowego |
| ElementyRozliczajace | `Soneta.Business.SubTable<Soneta.Ksiega.RozliczenieOA>` |  |  |  |
| ElementyRozliczane | `Soneta.Business.SubTable<Soneta.Ksiega.RozliczenieOA>` |  |  |  |
| Ewidencja | `Soneta.Core.DokEwidencji` | bazodanowe, guided-parent |  |  |
| IBudzetProjektu | `Soneta.Core.IBudzetProjektu` |  |  |  |
| Ilosc | `Soneta.Types.Amount` | bazodanowe |  |  |
| Informacja | `string` |  |  |  |
| InitKwotaIlosc | `bool` |  |  |  |
| IsReadOnlyBudget | `bool` |  |  |  |
| KategoriaBudzetowa | `Soneta.Core.IBudgetCategoryDefinition` | bazodanowe |  | Kategoria budżetu |
| Kwota | `Soneta.Types.Currency` | bazodanowe |  |  |
| KwotaDodatkowa | `Soneta.Types.Currency` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| ParentSettlements | `System.Collections.Generic.IEnumerable<Soneta.Ksiega.ElemOpisuAnalitycznego>` |  |  |  |
| PlatnoscPowiazana | `Soneta.Kasa.Platnosc` | bazodanowe |  | Powiązana płatność |
| PozycjaBudzProj | `Soneta.Core.IPozycjaBudzProjRow` | bazodanowe |  | Pozycja budżetu projektu, z którą powiązany jest element |
| Projekt | `Soneta.Core.IBudzetowany` | iface-ref |  |  |
| Rodzaj | `Soneta.Core.RodzajOpisuAnalitycznego` | bazodanowe, enum |  |  |
| RozszerzenieSymbolu | `Soneta.Ksiega.ElemOpisuAnalitycznego.RozszerzenieSymboluOpisu` |  |  |  |
| RozszerzenieWymiaru | `Soneta.Ksiega.ElemOpisuAnalitycznego.RozszerzenieWymiaruOpisu` |  |  |  |
| SchematPodz | `Soneta.Ksiega.Podzielniki.SchematPodz` | bazodanowe |  |  |
| SegmentyBudzetowe | `Soneta.Ksiega.ElemOpisuAnalitycznego.SegmentyBudzetoweCollection` |  |  |  |
| SegmentyBudzetoweZad | `Soneta.Ksiega.ElemOpisuAnalitycznego.SegmentyBudzetoweCollection` |  |  |  |
| SubordinateRightsSettlements | `System.Collections.Generic.IEnumerable<Soneta.Ksiega.ElemOpisuAnalitycznego>` |  |  |  |
| Symbol | `string` | bazodanowe |  |  |
| Typ | `Soneta.Ksiega.TypOpisuAnalitycznego` | bazodanowe, enum |  |  |
| WersjaPlanu | `Soneta.Core.IBudgetPlanVersion` | bazodanowe |  | Wersja planu |
| Wymiar | `string` | bazodanowe |  |  |
| ZapisPowiazany | `Soneta.Ksiega.ZapisKsiegowy` | bazodanowe |  | Powiązany zapis |
| ZapisyKsiegowe | `System.Collections.Generic.IEnumerable<Soneta.Ksiega.ZapisKsiegowy>` |  |  |  |
| Zrodlo | `Soneta.Core.IZrodloOpisuAnalitycznego` | bazodanowe, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Projekt | `IBudzetowany` | `Projekt` |
| Zrodlo | `IZrodloOpisuAnalitycznego` | `Deklaracja`, `Delegacja`, `DokumentHandlowy`, `ElemEwidencjiVATAkcyzy`, `ObrotRMK`, `ObrotST`, `PlanowanaWypłata`, `Platnosc`, `PozycjaDokHandlowego`, `PreliminarzDokument`, `Wyplata`, `Zaplata` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajOpisuAnalitycznego (`Soneta.Core.RodzajOpisuAnalitycznego`)
- `Zwykły` = 0
- `Storno` = 1
- `ZwykłyDoStorna` = 2
- `RóżnicaZysk` = 3
- `RóżnicaStrata` = 4

### TypOpisuAnalitycznego (`Soneta.Ksiega.TypOpisuAnalitycznego`)
- `Brak` = 0 — Brak
- `OpisEwidencji` = 1
- `OpisŹródła` = 2
