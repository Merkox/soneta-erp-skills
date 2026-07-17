# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Dms.Config.BasicDocumentDefinition`
Nazwa tabeli: `BasicDocDefs`
Tytuł: Definicje dokumentów podstawowych
Opis: Definicja typu dokumentu podstawowego w module DMS. Określa reguły numeracji, seryjność, wymagalność metryk i kategorii archiwalnej, domyślny poziom dostępu oraz dozwolone definicje dokumentów dodatkowych. Stanowi szablon dla tworzenia dokumentów podstawowych.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`, `IChronoOrderHostDefinition`

- pola bazodanowe: 20
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AllowedRuntimeDefs | `Soneta.Core.CoreModule.DbTupleDefinitionRow[]` | bazodanowe | Dozwolone definicje | Dozwolone definicje dokumentów dodatkowych |
| BasicDocuments | `Soneta.Business.SubTable<Soneta.Workflow.Dms.BasicDocument>` |  |  |  |
| Default | `bool` | bazodanowe | Domyślna | Definicja domyślna |
| DefaultDaysToResponse | `int` | bazodanowe | Dni na odpowiedź | Domyślna liczba dni na odpowiedź dla tej definicji dokumentu |
| DefaultDocumentAccess | `Soneta.Workflow.Enums.AccessEnum` | bazodanowe, enum | Dostęp | Dostęp do dokumentu |
| IsArchCatRequired | `bool` | bazodanowe | Wymagana kategoria archiwalna | Wymagana kategoria archiwalna |
| IsCRUAvailable | `bool` | bazodanowe | Dostępny Centralny Rejestr Umów | Dostępny Centralny Rejestr Umów (CRU) |
| IsEnabledChronoOrder | `bool` |  |  |  |
| IsMetricsRequired | `bool` | bazodanowe | Metryki wymagane | Metryki wymagane |
| IsVisibleBDocBusEnts | `bool` | bazodanowe | Obsługa wielu nadawców | Możliwe dodawanie wielu nadawców na dokumencie |
| IsVisibleOthersFromBasicDoc | `bool` | bazodanowe | Widoczność zakładki pozostałe | Widoczność zakładki pozostałe na dokumencie podstawowym |
| LanguageCode | `string` | bazodanowe | Kod języka | Kod języka |
| Locked | `bool` | bazodanowe | Zablokowana | Definicja zablokowana |
| Name | `string` | bazodanowe | Nazwa | Nazwa definicji |
| Numerator | `Soneta.Core.DefinicjaNumeracji` | bazodanowe | Numeracja | Określa sposób numerowania definicji |
| Numerator.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numerator.PodczasZapisu | `bool` |  |  |  |
| Numerator.Separator | `string` | bazodanowe |  |  |
| Numerator.Wzor | `string` | bazodanowe |  |  |
| ResponseDeadlineBaseDate | `Soneta.Workflow.Enums.ResponseDeadlineBaseDateEnum` | bazodanowe, enum | Bazowa data odpowiedzi | Data od której liczone są dni na odpowiedź |
| Series | `bool` | bazodanowe | Seria | Seria definicji |
| Symbol | `string` | bazodanowe | Symbol | Symbol definicji |
| Xml | `Soneta.Business.MemoText` | bazodanowe | Zakładka użytkownika | Definicja zakładki użytkownika |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AccessEnum (`Soneta.Workflow.Enums.AccessEnum`)
- `Public` = 0 — Publiczny - dostępny w całości
- `PartialPublic` = 1 — Publiczny - dostępny częściowo
- `Private` = 2 — Niepubliczny

### ResponseDeadlineBaseDateEnum (`Soneta.Workflow.Enums.ResponseDeadlineBaseDateEnum`)
- `DateOfReceipt` = 0 — Data wpływu
- `DateOfDocument` = 1 — Data dokumentu
- `DateOfDispatch` = 2 — Data nadania
