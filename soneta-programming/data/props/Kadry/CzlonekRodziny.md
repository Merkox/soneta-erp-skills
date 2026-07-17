# Pola i właściwości klasy biznesowej: `Soneta.Kadry.CzlonekRodziny`
Nazwa tabeli: `Rodzina`
Tytuł: Członek rodziny
Opis: Ewidencja członków rodziny pracownika z danymi osobowymi (PESEL, data urodzenia, dokument tożsamości) oraz informacjami ubezpieczeniowymi. Służy do zgłaszania członków rodziny do ubezpieczenia zdrowotnego, ustalania stopnia pokrewieństwa i niepełnosprawności.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IZrodloDeklaracji`, `IAdresHost`, `IPowiązanieDodatku`

- pola bazodanowe: 23
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` |  |  |  |
| Deklaracje | `Soneta.Business.SubTable` |  |  |  |
| Dodatki | `Soneta.Business.SubTable<Soneta.Kadry.Dodatek>` |  |  |  |
| Dokument | `Soneta.Kadry.DokumentOsoby` | bazodanowe |  |  |
| Dokument.DataWaznosci | `Soneta.Types.Date` | bazodanowe |  |  |
| Dokument.DataWydania | `Soneta.Types.Date` | bazodanowe |  |  |
| Dokument.Rodzaj | `Soneta.Kadry.KodRodzajuDokumentu` | bazodanowe, enum |  |  |
| Dokument.SeriaNumer | `string` | bazodanowe |  |  |
| Dokument.WydanyPrzez | `string` | bazodanowe |  |  |
| EuVAT | `string` | bazodanowe | EU VAT |  |
| Imie | `string` | bazodanowe |  |  |
| ImieDrugie | `string` | bazodanowe |  |  |
| Kod | `string` |  |  |  |
| NIP | `string` | bazodanowe |  |  |
| NaUtrzymaniu | `bool` | bazodanowe |  |  |
| Nazwisko | `string` | bazodanowe |  |  |
| OdbKsztalcenie | `bool` | bazodanowe |  |  |
| OpiekaOpiekuna | `Soneta.Business.SubTable<Soneta.Place.OświadczenieZusOpieka>` |  |  |  |
| OpiekaPodopiecznego | `Soneta.Business.SubTable<Soneta.Place.OświadczenieZusOpieka>` |  |  |  |
| PESEL | `string` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| StNiepelnosprawnosci | `Soneta.Kadry.KodStNiepelnosprawnosci` | bazodanowe, enum |  |  |
| StPokrewienstwa | `Soneta.Kadry.KodStPokrewienstwa` | bazodanowe, enum |  |  |
| UbezpieczenieOkres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Ubezpieczony | `bool` | bazodanowe |  |  |
| Urodzony | `Soneta.Kadry.Urodzony` | bazodanowe |  |  |
| Urodzony.Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Urodzony.Miejsce | `string` | bazodanowe |  |  |
| WspolneGospDomowe | `bool` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KodRodzajuDokumentu (`Soneta.Kadry.KodRodzajuDokumentu`)
- `Niezdefiniowany` = 0
- `DowodOsobisty` = 1 — Dowód osobisty
- `Paszport` = 2 — 2 - paszport

### KodStNiepelnosprawnosci (`Soneta.Kadry.KodStNiepelnosprawnosci`)
- `Brak` = 0
- `Lekki` = 1
- `Umiarkowany` = 2
- `Znaczny` = 3
- `OsobaDo16Roku` = 4 — Osoba niepełnosprawna do 16 roku życia

### KodStPokrewienstwa (`Soneta.Kadry.KodStPokrewienstwa`)
- `Brak` = 0
- `Malzonek` = 1 — Małżonek
- `Dziecko` = 11
- `Wnuk` = 21
- `Matka` = 30
- `Ojciec` = 31
- `Macocha` = 32
- `Ojczym` = 33
- `Babka` = 40
- `Dziadek` = 41
- `OsobaPrzyspasabiajaca` = 50 — Osoba przysposabiająca
- `InniKrewni` = 60
