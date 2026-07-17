# Pola i właściwości klasy biznesowej: `Soneta.HR.DefinicjaStanowiskaHist`
Nazwa tabeli: `DefStanowiskHist`
Tytuł: Definicje stanowisk historia
Opis: Element szczegółowy definicji stanowiska (DefinicjaStanowiska). Przechowuje wersje historyczne parametrów stanowiska (zaszeregowanie, kalendarz, kod zawodu), umożliwiając śledzenie zmian w czasie.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DefinicjaStanowiska` → `DefinicjaStanowiska`

- pola bazodanowe: 35
- pola kalkulowane (z klas biznesowych): 13

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `Soneta.Types.FromTo` | bazodanowe |  |  |
| DefinicjaFunkcji | `Soneta.HR.DefinicjaFunkcji` | bazodanowe |  |  |
| DefinicjaStanowiska | `Soneta.HR.DefinicjaStanowiska` | bazodanowe, guided-parent |  |  |
| ElementyStanowiska | `Soneta.Business.SubTable<Soneta.HR2.ElementWynagDod>` |  |  |  |
| Funkcja | `string` | bazodanowe |  |  |
| FunkcjaPelna | `string` | bazodanowe |  |  |
| Grupa | `Soneta.Kadry.GrupaZaszeregowania` | bazodanowe |  |  |
| GrupaStanowisk | `Soneta.HR.GrupaStanowisk` | bazodanowe |  |  |
| Ilosc | `Soneta.Types.Fraction` |  |  |  |
| InterpretacjaKalendarza | `Soneta.Kadry.InterpretacjaKalendarza` | bazodanowe, enum |  |  |
| Kalendarz | `Soneta.Kalend.KalendarzBase` | bazodanowe |  |  |
| KategoriaPracownika | `Soneta.HR.KategoriaPracownika` | bazodanowe |  |  |
| KodPracyWSzczWarunkach | `Soneta.Kadry.KodPracyWSzególnychWarunkachCharakterze` | bazodanowe |  |  |
| KodWykonywanegoZawodu | `Soneta.Kadry.KodWykonywanegoZawodu` | bazodanowe |  |  |
| KodWymiany | `string` | bazodanowe |  |  |
| MaksymalneWynagrodzenieBrutto | `Soneta.Types.Currency` | bazodanowe |  |  |
| MinimalneWynagrodzenieBrutto | `Soneta.Types.Currency` | bazodanowe |  |  |
| NieNadpisujKalendarza | `bool` | bazodanowe |  |  |
| ObszaryOdpowiedzialnosciDlaAktualnosci | `System.Collections.Generic.IEnumerable<Soneta.HR.ZKL.OpisStanowiska.Odpowiedzialnosci.ObszarOdpowiedzialnosciStanowiska>` |  |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| OpisAktualizacji | `Soneta.Business.MemoText` | bazodanowe | Opis aktualizacji | Opis aktualizacji zapisu |
| OpisLinia | `string` |  |  |  |
| OpisPierwszaLinia | `string` |  |  |  |
| OpisStanowiskaZeSkierowaniaNaBad | `string` | bazodanowe |  |  |
| OptymalneWynagrodzenieBrutto | `Soneta.Types.Currency` | bazodanowe |  |  |
| Parent | `Soneta.Business.Row` |  |  |  |
| PoczatkowaWysokoscStawki | `Soneta.Types.Currency` | bazodanowe |  |  |
| PowodAktualizacji | `string` | bazodanowe | Powód aktualizacji | Opis powodu aktualizacji zapisu |
| Specjalosc | `string` | bazodanowe |  |  |
| SrednieWynagrodzenieBrutto | `Soneta.Types.Currency` |  |  |  |
| StanowiskaPodrzedne | `System.Collections.Generic.IEnumerable<Soneta.HR.DefinicjaStanowiska>` |  |  |  |
| Stanowisko | `string` | bazodanowe |  |  |
| StanowiskoKierownicze | `bool` | bazodanowe |  |  |
| StanowiskoNadrzedne | `Soneta.HR.DefinicjaStanowiska` | bazodanowe |  |  |
| StanowiskoPelne | `string` | bazodanowe |  |  |
| TypStawki | `Soneta.Kadry.TypStawkiZaszeregowania` | bazodanowe, enum |  |  |
| Zaszeregowanie | `Soneta.Kadry.Zaszeregowanie` | bazodanowe |  |  |
| Zaszeregowanie.Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Zaszeregowanie.Godzinowe | `bool` |  |  |  |
| Zaszeregowanie.Miesięczne | `bool` |  |  |  |
| Zaszeregowanie.RodzajStawki | `Soneta.Kadry.RodzajStawkiZaszeregowania` | bazodanowe, enum |  |  |
| Zaszeregowanie.Stawka | `Soneta.Types.Currency` | bazodanowe |  |  |
| Zaszeregowanie.TypStawki | `Soneta.Kadry.TypStawkiZaszeregowania` | enum |  |  |
| Zaszeregowanie.WgElement | `Soneta.Business.Key` |  |  |  |
| Zaszeregowanie.WskaznikKrotnosc | `double` | bazodanowe |  |  |
| Zaszeregowanie.WskaznikNazwa | `string` | bazodanowe |  |  |
| Zaszeregowanie.Wymiar | `Soneta.Types.Fraction` | bazodanowe |  |  |
| ZklInfo | `Soneta.HR.DefinicjaStanowiskaHistZkl` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### InterpretacjaKalendarza (`Soneta.Kadry.InterpretacjaKalendarza`)
- `WgPlanu` = 0
- `WgObecnosci` = 1 — Wg obecności
- `WgZestawien` = 2 — Wg zestawień

### RodzajStawkiZaszeregowania (`Soneta.Kadry.RodzajStawkiZaszeregowania`)
- `Godzinowa` = 0 — Za godzinę
- `Miesieczna` = 1 — Miesięcznie
- `DochodDeklarowany` = 2 — Dochód deklarowany

### TypStawkiZaszeregowania (`Soneta.Kadry.TypStawkiZaszeregowania`)
- `Dowolna` = 0 — Dowolna
- `Minimalna` = 1
- `ZZakresu` = 2
- `WgWskaźnika` = 3
- `Nieokreślona` = 10
