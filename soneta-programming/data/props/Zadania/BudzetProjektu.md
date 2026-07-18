# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Budzetowanie.BudzetProjektu`
Nazwa tabeli: `BudzetyProjektu`
Tytuł: Budzety projektu
Opis: Budżet przypisany do projektu lub innego obiektu budżetowanego. Zawiera walutę, stan, okres, sposób rozliczania oraz wymiar analityczny, umożliwiając kontrolę finansową realizacji projektu.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 13
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 6
- podlisty: 4
- subrowy: 0
- razem: 24

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywny | `bool` | bazodanowe | Aktywny | Wskazuje, czy budżet jest aktywny (otwarty). |
| BasicDefaultPlanVersion | `Soneta.Zadania.Budzetowanie.WersjaPlanu` | tylko-odczyt |  |  |
| BudgetConfiguration | `Soneta.Core.IBudgetConfiguration` | tylko-odczyt |  |  |
| BudgetItemSourceService | `System.Lazy<Soneta.Zadania.Budzetowanie.Services.BudgetItemSourceStrategyService>` | tylko-odczyt |  |  |
| CzyZakazPracowaniaZBudzetem | `bool` | tylko-odczyt |  |  |
| DataZamkniecia | `Date` | bazodanowe | Data zamknięcia budżetu | Określa datę zamknięcia budżetu. |
| Definicja | `Soneta.Zadania.Budzetowanie.DefBudget` | bazodanowe | Definicja budżetu | Definicja budżetu. |
| DlaEtapow | `Soneta.Core.SposobRozliczania` (enum) | bazodanowe |  |  |
| KwotyBudzetu | `SubTable<Soneta.Zadania.Budzetowanie.KwotaBudzProj>` | podlista |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa budzetu projektu. |
| Podstawowy | `bool` | bazodanowe | Budżet podstawowy | Określa czy budżet jest podstawowy w ramach projektu. |
| PozycjeBudzProj | `SubTable<Soneta.Zadania.Budzetowanie.PozycjaBudzProj>` | podlista |  |  |
| Projekt | `Soneta.Core.IBudzetowany` | bazodanowe, iface-ref |  |  |
| SaKwoty | `bool` | tylko-odczyt |  |  |
| SaPozycje | `bool` | tylko-odczyt |  |  |
| SposobRozliczania | `Soneta.Core.SposobRozliczania` (enum) |  |  |  |
| Stan | `Soneta.Core.StanBudzetu` (enum) | bazodanowe | Stan budżetu | Określa stan budżetu. |
| Symbol | `string` | bazodanowe | Symbol | Symbol budzetu projektu. |
| TypOkresu | `Soneta.Core.TypOkresu` (enum) | bazodanowe | Typ okresu budżetu. |  |
| Uprawnienia | `SubTable<Soneta.Zadania.Budzetowanie.BudzetUprawnienie>` | podlista |  |  |
| Waluta | `string` | bazodanowe | Nazwa | Nazwa budzetu projektu. |
| WariantRozliczania | `Soneta.Core.SettlementVariant` (enum) | bazodanowe | Wariant rozliczania | Wariant rozliczania. |
| WersjePlanu | `SubTable<Soneta.Zadania.Budzetowanie.WersjaPlanu>` | podlista |  |  |
| Wymiar | `string` | bazodanowe | Symbol konta | Domyślny wymiar dla opisu analitycznego. |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Projekt | `IBudzetowany` | `Projekt` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### SettlementVariant (`Soneta.Core.SettlementVariant`)
- `NoVerification` = 0 — Bez weryfikacji
- `InPeriodOrStage` = 1 — W okresie/etapie
- `CumulativeToPeriodOrStage` = 2 — Narastająco do okresu/etapu (od początku okresu do danego miesiąca/etapu)
- `InBudgetPeriod` = 3 — W całym okresie budżetowym (od początku do końca okresu budżetowego)

### SposobRozliczania (`Soneta.Core.SposobRozliczania`)
- `Narastająco` = 0 — Narastająco
- `DlaEtapów` = 1 — Dla etapów
- `DlaOkresów` = 2 — Dla okresów

### StanBudzetu (`Soneta.Core.StanBudzetu`)
- `Bufor` = 0 — Bufor
- `Zatwierdzony` = 1
- `Korygowany` = 2

### TypOkresu (`Soneta.Core.TypOkresu`)
- `Miesięczny` = 0 — Miesięczny
- `Kwartalny` = 1
- `Półroczny` = 2
- `Roczny` = 3
