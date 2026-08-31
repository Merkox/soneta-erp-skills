# Pola i właściwości klasy biznesowej: `Soneta.Windykacja.SprawaWindykacyjna`
Nazwa tabeli: `SprawyWindyk`
Tytuł: Sprawy windykacyjne
Opis: Dokument sprawy windykacyjnej prowadzonej wobec konkretnego podmiotu. Rejestruje przebieg postępowania windykacyjnego, w tym przypisanego windykatora, aktualny etap realizacji, daty rozpoczęcia i planowanego zakończenia oraz powiązane należności.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IEmailElement`, `IDokumentCRM`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AktualnyTask | `Db.Task` | tylko-odczyt | Aktualne zadanie |  |
| CzasTrwania | `int` | tylko-odczyt |  |  |
| Data | `Date` | bazodanowe | Data rozpoczęcia |  |
| Definicja | `Soneta.Windykacja.DefinicjaSprawyWindykacyjnej` | bazodanowe |  |  |
| Kod | `string` | tylko-odczyt |  |  |
| Kwota | `Currency` | tylko-odczyt |  |  |
| MailTo | `string` | tylko-odczyt |  |  |
| Nazwa | `string` | tylko-odczyt |  |  |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| Podmiot | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| Pozycje | `LpSubTable<Soneta.Windykacja.PozycjaSprawyWindykacyjnej>` | podlista |  |  |
| Stan | `Soneta.Kasa.StanSprawyWindykacyjnej` (enum) | bazodanowe |  |  |
| Termin | `Date` | bazodanowe | Planowany termin zakończenia |  |
| WiadomosciPowiazane | `SubTable` | podlista |  |  |
| Windykator | `App.Operator` | bazodanowe | Windykator |  |
| ZadaniaCRM | `SubTable` | podlista |  |  |
| ZrealizowanyEtap | `Soneta.Windykacja.EtapDefinicjiWindykacji` | bazodanowe | Zrealizowany etap |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Podmiot | `IPodmiotKasowy` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StanSprawyWindykacyjnej (`Soneta.Kasa.StanSprawyWindykacyjnej`)
- `Planowana` = 0 — Planowana
- `Windykowana` = 1
- `Zakończona` = 2
- `Anulowana` = 99
