# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DefinicjaAktualizacjiKalendarza`
Nazwa tabeli: `DefAktKalendarzy`
Tytuł: Definicje dokumentów aktualizacji kalendarzy
Opis: Konfigurowalna definicja dokumentu aktualizacji kalendarza. Określa rodzaj aktualizacji (plan/czas), symbol, numerację, źródła danych (etat, umowy zlecenia, umowy zewnętrzne), powiązany proces oraz widoczne cechy dokumentu.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe (zapisywalne): 17
- pola kalkulowane (zapisywalne): 3
- pola tylko-odczyt: 8
- podlisty: 5
- subrowy: 3
- razem: 36

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `Soneta.Kalend.DefinicjaAktualizacjiKalendarza.AlgorytmBase` | tylko-odczyt |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| ClassName | `string` | tylko-odczyt |  |  |
| Code | `MemoText` | bazodanowe, podlista |  |  |
| CreateProcess | `Soneta.Core.DbTuples.CreateProcessType` (enum) | bazodanowe | Powiązany proces |  |
| CzasPracy | `bool` | tylko-odczyt |  |  |
| DefPowiazania | `Soneta.Kalend.DefinicjaPowiązaniaDokumentu` (subrow) | bazodanowe |  |  |
| DefPowiazania.RodzajStruktury | `string` | bazodanowe, tylko-odczyt |  |  |
| DefPowiazania.StrOrganizacyjna | `Soneta.Core.StrukturaOrganizacyjna` | bazodanowe | Struktura organizacyjna |  |
| DefPowiazania.StrukturaFirmy | `Soneta.Oceny.TableRef` |  |  |  |
| DefPowiazania.WgStrOrganizacyjna | `Key` | podlista |  |  |
| DefinicjaProcesu | `System.Guid` | bazodanowe | Powiązany proces |  |
| DlaJednegoZrodla | `bool` | tylko-odczyt |  |  |
| DokumentDla | `Soneta.Kalend.DokumentDlaAktualizacjiKalendarza` (enum) | bazodanowe |  |  |
| FormatedName | `string` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Numeracja | `Soneta.Core.DefinicjaNumeracji` (subrow) | bazodanowe |  |  |
| Numeracja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numeracja.PodczasZapisu | `bool` |  |  |  |
| Numeracja.Separator | `string` | bazodanowe |  |  |
| Numeracja.Wzor | `string` | bazodanowe |  |  |
| PlanPracy | `bool` | tylko-odczyt |  |  |
| Rodzaj | `Soneta.Kalend.RodzajAktualizacjiKalendarza` (enum) | bazodanowe, tylko-odczyt |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| Seria | `bool` | bazodanowe | Ogólne |  |
| Symbol | `string` | bazodanowe |  |  |
| WfDefinition | `IWFDefinition` | iface-ref |  |  |
| WidoczneCechy | `MemoText` | bazodanowe, podlista |  |  |
| Zestawienia | `SubTable<Soneta.Kalend.ZestawienieAktualizacjiKalendarza>` | podlista |  |  |
| ZrodloEtat | `bool` | bazodanowe | Ogólne |  |
| ZrodloUmowyZewn | `bool` | bazodanowe | Ogólne |  |
| ZrodloUmowyZlec | `bool` | bazodanowe | Ogólne |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| WfDefinition | `IWFDefinition` | `WFDefinition` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### CreateProcessType (`Soneta.Core.DbTuples.CreateProcessType`)
- `Default` = 0 — Podczas zapisu dokumentu
- `OnAdded` = 1 — Podczas dodawania dokumentu

### DokumentDlaAktualizacjiKalendarza (`Soneta.Kalend.DokumentDlaAktualizacjiKalendarza`)
- `DowolnegoŹródła` = 0
- `Podwładnych` = 1
- `Składającego` = 2
- `InnegoŹródła` = 3

### RodzajAktualizacjiKalendarza (`Soneta.Kalend.RodzajAktualizacjiKalendarza`)
- `AktualizacjaPlanuPracy` = 1
- `WprowadzanieCzasuPracy` = 2
