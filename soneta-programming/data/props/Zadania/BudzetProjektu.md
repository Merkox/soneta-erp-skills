# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Budzetowanie.BudzetProjektu`
Nazwa tabeli: `BudzetyProjektu`
Tytuł: Budzety projektu
Opis: Budżet przypisany do projektu lub innego obiektu budżetowanego. Zawiera walutę, stan, okres, sposób rozliczania oraz wymiar analityczny, umożliwiając kontrolę finansową realizacji projektu.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 13
- pola kalkulowane (z klas biznesowych): 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywny | `bool` | bazodanowe | Aktywny | Wskazuje, czy budżet jest aktywny (otwarty). |
| BasicDefaultPlanVersion | `Soneta.Zadania.Budzetowanie.WersjaPlanu` |  |  |  |
| BudgetConfiguration | `Soneta.Core.IBudgetConfiguration` |  |  |  |
| BudgetItemSourceService | `System.Lazy<Soneta.Zadania.Budzetowanie.Services.BudgetItemSourceStrategyService>` |  |  |  |
| CzyZakazPracowaniaZBudzetem | `bool` |  |  |  |
| DataZamkniecia | `Soneta.Types.Date` | bazodanowe | Data zamknięcia budżetu | Określa datę zamknięcia budżetu. |
| Definicja | `Soneta.Zadania.Budzetowanie.DefBudget` | bazodanowe | Definicja budżetu | Definicja budżetu. |
| DlaEtapow | `Soneta.Core.SposobRozliczania` | bazodanowe, enum |  |  |
| KwotyBudzetu | `Soneta.Business.SubTable<Soneta.Zadania.Budzetowanie.KwotaBudzProj>` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa budzetu projektu. |
| Podstawowy | `bool` | bazodanowe | Budżet podstawowy | Określa czy budżet jest podstawowy w ramach projektu. |
| PozycjeBudzProj | `Soneta.Business.SubTable<Soneta.Zadania.Budzetowanie.PozycjaBudzProj>` |  |  |  |
| Projekt | `Soneta.Core.IBudzetowany` | bazodanowe, iface-ref |  |  |
| SaKwoty | `bool` |  |  |  |
| SaPozycje | `bool` |  |  |  |
| SposobRozliczania | `Soneta.Core.SposobRozliczania` | enum |  |  |
| Stan | `Soneta.Core.StanBudzetu` | bazodanowe, enum | Stan budżetu | Określa stan budżetu. |
| Symbol | `string` | bazodanowe | Symbol | Symbol budzetu projektu. |
| TypOkresu | `Soneta.Core.TypOkresu` | bazodanowe, enum | Typ okresu budżetu. |  |
| Uprawnienia | `Soneta.Business.SubTable<Soneta.Zadania.Budzetowanie.BudzetUprawnienie>` |  |  |  |
| Waluta | `string` | bazodanowe | Nazwa | Nazwa budzetu projektu. |
| WariantRozliczania | `Soneta.Core.SettlementVariant` | bazodanowe, enum | Wariant rozliczania | Wariant rozliczania. |
| WersjePlanu | `Soneta.Business.SubTable<Soneta.Zadania.Budzetowanie.WersjaPlanu>` |  |  |  |
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
