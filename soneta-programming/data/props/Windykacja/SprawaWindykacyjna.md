# Pola i właściwości klasy biznesowej: `Soneta.Windykacja.SprawaWindykacyjna`
Nazwa tabeli: `SprawyWindyk`
Tytuł: Sprawy windykacyjne
Opis: Dokument sprawy windykacyjnej prowadzonej wobec konkretnego podmiotu. Rejestruje przebieg postępowania windykacyjnego, w tym przypisanego windykatora, aktualny etap realizacji, daty rozpoczęcia i planowanego zakończenia oraz powiązane należności.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IEmailElement`, `IDokumentCRM`

- pola bazodanowe: 11
- pola kalkulowane (z klas biznesowych): 12

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AktualnyTask | `Soneta.Business.Db.Task` |  | Aktualne zadanie |  |
| CzasTrwania | `int` |  |  |  |
| Data | `Soneta.Types.Date` | bazodanowe | Data rozpoczęcia |  |
| Definicja | `Soneta.Windykacja.DefinicjaSprawyWindykacyjnej` | bazodanowe |  |  |
| Kod | `string` |  |  |  |
| Kwota | `Soneta.Types.Currency` |  |  |  |
| MailTo | `string` |  |  |  |
| Nazwa | `string` |  |  |  |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| Podmiot | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, iface-ref |  |  |
| Pozycje | `Soneta.Business.LpSubTable<Soneta.Windykacja.PozycjaSprawyWindykacyjnej>` |  |  |  |
| Stan | `Soneta.Kasa.StanSprawyWindykacyjnej` | bazodanowe, enum |  |  |
| Termin | `Soneta.Types.Date` | bazodanowe | Planowany termin zakończenia |  |
| WiadomosciPowiazane | `Soneta.Business.SubTable` |  |  |  |
| Windykator | `Soneta.Business.App.Operator` | bazodanowe | Windykator |  |
| ZadaniaCRM | `Soneta.Business.SubTable` |  |  |  |
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
