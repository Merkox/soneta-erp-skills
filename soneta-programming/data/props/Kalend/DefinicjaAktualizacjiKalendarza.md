# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DefinicjaAktualizacjiKalendarza`
Nazwa tabeli: `DefAktKalendarzy`
Tytuł: Definicje dokumentów aktualizacji kalendarzy
Opis: Konfigurowalna definicja dokumentu aktualizacji kalendarza. Określa rodzaj aktualizacji (plan/czas), symbol, numerację, źródła danych (etat, umowy zlecenia, umowy zewnętrzne), powiązany proces oraz widoczne cechy dokumentu.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe: 24
- pola kalkulowane (z klas biznesowych): 12

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `Soneta.Kalend.DefinicjaAktualizacjiKalendarza.AlgorytmBase` |  |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| ClassName | `string` |  |  |  |
| Code | `Soneta.Business.MemoText` | bazodanowe |  |  |
| CreateProcess | `Soneta.Core.DbTuples.CreateProcessType` | bazodanowe, enum | Powiązany proces |  |
| CzasPracy | `bool` |  |  |  |
| DefPowiazania | `Soneta.Kalend.DefinicjaPowiązaniaDokumentu` | bazodanowe |  |  |
| DefPowiazania.RodzajStruktury | `string` | bazodanowe |  |  |
| DefPowiazania.StrOrganizacyjna | `Soneta.Core.StrukturaOrganizacyjna` | bazodanowe | Struktura organizacyjna |  |
| DefPowiazania.StrukturaFirmy | `Soneta.Oceny.TableRef` |  |  |  |
| DefPowiazania.WgStrOrganizacyjna | `Soneta.Business.Key` |  |  |  |
| DefinicjaProcesu | `System.Guid` | bazodanowe | Powiązany proces |  |
| DlaJednegoZrodla | `bool` |  |  |  |
| DokumentDla | `Soneta.Kalend.DokumentDlaAktualizacjiKalendarza` | bazodanowe, enum |  |  |
| FormatedName | `string` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Numeracja | `Soneta.Core.DefinicjaNumeracji` | bazodanowe |  |  |
| Numeracja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numeracja.PodczasZapisu | `bool` |  |  |  |
| Numeracja.Separator | `string` | bazodanowe |  |  |
| Numeracja.Wzor | `string` | bazodanowe |  |  |
| PlanPracy | `bool` |  |  |  |
| Rodzaj | `Soneta.Kalend.RodzajAktualizacjiKalendarza` | bazodanowe, enum |  |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| Seria | `bool` | bazodanowe | Ogólne |  |
| Symbol | `string` | bazodanowe |  |  |
| WfDefinition | `Soneta.Business.IWFDefinition` | iface-ref |  |  |
| WidoczneCechy | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Zestawienia | `Soneta.Business.SubTable<Soneta.Kalend.ZestawienieAktualizacjiKalendarza>` |  |  |  |
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
