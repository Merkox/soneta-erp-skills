# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.ElemOpisuAnalitycznego`
Nazwa tabeli: `OpisAnalityczny`
Tytuł: Opis analityczny
Opis: Element szczegółowy dokumentu ewidencji (DokEwidencji). Reprezentuje pojedynczą pozycję opisu analitycznego, przypisującą kwotę do wymiaru analitycznego (np. centrum kosztów, projektu). Obsługuje podzielniki kosztów, budżety projektów, rozliczenia międzyokresowe oraz powiązania z płatnościami i zapisami księgowymi.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Ewidencja` → `DokEwidencji`

- pola bazodanowe (zapisywalne): 17
- pola kalkulowane (zapisywalne): 2
- pola tylko-odczyt: 15
- podlisty: 5
- subrowy: 0
- razem: 39

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BudzetProjWgKwotyDodatkowej | `bool` | bazodanowe |  |  |
| BudzetowanieRozszerzone | `bool` | tylko-odczyt |  |  |
| CentrumKosztow | `Soneta.Core.CentrumKosztow` | bazodanowe | Centrum kosztów | Centrum kosztów |
| CzyRelacje | `bool` | tylko-odczyt |  |  |
| Data | `Date` | bazodanowe |  |  |
| DataOstatniegoRozliczenia | `Date` | bazodanowe | Data ostatniego rozliczenia | Data ostatniego rozliczenia |
| DataOstatniegoRozliczeniaDod | `Date` | bazodanowe | Data ostatniego rozliczenia dodatkowego | Data ostatniego rozliczenia dodatkowego |
| DataPierwszegoRozliczenia | `Date` | bazodanowe | Data pierwszego rozliczenia | Data pierwszego rozliczenia |
| DataPierwszegoRozliczeniaDod | `Date` | bazodanowe | Data pierwszego rozliczenia dodatkowego | Data pierwszego rozliczenia dodatkowego |
| ElementyRozliczajace | `SubTable<Soneta.Ksiega.RozliczenieOA>` | podlista |  |  |
| ElementyRozliczane | `SubTable<Soneta.Ksiega.RozliczenieOA>` | podlista |  |  |
| Ewidencja | `Soneta.Core.DokEwidencji` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| IBudzetProjektu | `Soneta.Core.IBudzetProjektu` |  |  |  |
| Ilosc | `Amount` | bazodanowe |  |  |
| Informacja | `string` | tylko-odczyt |  |  |
| InitKwotaIlosc | `bool` |  |  |  |
| IsReadOnlyBudget | `bool` | tylko-odczyt |  |  |
| KategoriaBudzetowa | `Soneta.Core.IBudgetCategoryDefinition` | bazodanowe |  | Kategoria budżetu |
| Kwota | `Currency` | bazodanowe |  |  |
| KwotaDodatkowa | `Currency` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| ParentSettlements | `System.Collections.Generic.IEnumerable<Soneta.Ksiega.ElemOpisuAnalitycznego>` | podlista |  |  |
| PlatnoscPowiazana | `Soneta.Kasa.Platnosc` | bazodanowe, tylko-odczyt |  | Powiązana płatność |
| PozycjaBudzProj | `Soneta.Core.IPozycjaBudzProjRow` | bazodanowe |  | Pozycja budżetu projektu, z którą powiązany jest element |
| Projekt | `Soneta.Core.IBudzetowany` | tylko-odczyt, iface-ref |  |  |
| Rodzaj | `Soneta.Core.RodzajOpisuAnalitycznego` (enum) | bazodanowe, tylko-odczyt |  |  |
| RozszerzenieSymbolu | `Soneta.Ksiega.ElemOpisuAnalitycznego.RozszerzenieSymboluOpisu` | tylko-odczyt |  |  |
| RozszerzenieWymiaru | `Soneta.Ksiega.ElemOpisuAnalitycznego.RozszerzenieWymiaruOpisu` | tylko-odczyt |  |  |
| SchematPodz | `Soneta.Ksiega.Podzielniki.SchematPodz` | bazodanowe |  |  |
| SegmentyBudzetowe | `Soneta.Ksiega.ElemOpisuAnalitycznego.SegmentyBudzetoweCollection` | tylko-odczyt |  |  |
| SegmentyBudzetoweZad | `Soneta.Ksiega.ElemOpisuAnalitycznego.SegmentyBudzetoweCollection` | tylko-odczyt |  |  |
| SubordinateRightsSettlements | `System.Collections.Generic.IEnumerable<Soneta.Ksiega.ElemOpisuAnalitycznego>` | podlista |  |  |
| Symbol | `string` | bazodanowe |  |  |
| Typ | `Soneta.Ksiega.TypOpisuAnalitycznego` (enum) | bazodanowe, tylko-odczyt |  |  |
| WersjaPlanu | `Soneta.Core.IBudgetPlanVersion` | bazodanowe |  | Wersja planu |
| Wymiar | `string` | bazodanowe |  |  |
| ZapisPowiazany | `Soneta.Ksiega.ZapisKsiegowy` | bazodanowe, tylko-odczyt |  | Powiązany zapis |
| ZapisyKsiegowe | `System.Collections.Generic.IEnumerable<Soneta.Ksiega.ZapisKsiegowy>` | podlista |  |  |
| Zrodlo | `Soneta.Core.IZrodloOpisuAnalitycznego` | bazodanowe, tylko-odczyt, iface-ref |  |  |

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
