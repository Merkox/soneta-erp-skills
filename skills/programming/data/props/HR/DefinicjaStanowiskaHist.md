# Pola i właściwości klasy biznesowej: `Soneta.HR.DefinicjaStanowiskaHist`
Nazwa tabeli: `DefStanowiskHist`
Tytuł: Definicje stanowisk historia
Opis: Element szczegółowy definicji stanowiska (DefinicjaStanowiska). Przechowuje wersje historyczne parametrów stanowiska (zaszeregowanie, kalendarz, kod zawodu), umożliwiając śledzenie zmian w czasie.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DefinicjaStanowiska` → `DefinicjaStanowiska`
Historia: Tak — zapis historyczny tabeli `DefinicjaStanowiska`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `FromTo` | bazodanowe, podlista |  |  |
| DefinicjaFunkcji | `Soneta.HR.DefinicjaFunkcji` | bazodanowe |  |  |
| DefinicjaStanowiska | `Soneta.HR.DefinicjaStanowiska` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| ElementyStanowiska | `SubTable<Soneta.HR2.ElementWynagDod>` | podlista |  |  |
| Funkcja | `string` | bazodanowe |  |  |
| FunkcjaPelna | `string` | bazodanowe |  |  |
| Grupa | `Soneta.Kadry.GrupaZaszeregowania` | bazodanowe |  |  |
| GrupaStanowisk | `Soneta.HR.GrupaStanowisk` | bazodanowe |  |  |
| Ilosc | `Fraction` | tylko-odczyt |  |  |
| InterpretacjaKalendarza | `Soneta.Kadry.InterpretacjaKalendarza` (enum) | bazodanowe |  |  |
| Kalendarz | `Soneta.Kalend.KalendarzBase` | bazodanowe |  |  |
| KategoriaPracownika | `Soneta.HR.KategoriaPracownika` | bazodanowe |  |  |
| KodPracyWSzczWarunkach | `Soneta.Kadry.KodPracyWSzególnychWarunkachCharakterze` | bazodanowe |  |  |
| KodWykonywanegoZawodu | `Soneta.Kadry.KodWykonywanegoZawodu` | bazodanowe |  |  |
| KodWymiany | `string` | bazodanowe |  |  |
| MaksymalneWynagrodzenieBrutto | `Currency` | bazodanowe |  |  |
| MinimalneWynagrodzenieBrutto | `Currency` | bazodanowe |  |  |
| NieNadpisujKalendarza | `bool` | bazodanowe |  |  |
| ObszaryOdpowiedzialnosciDlaAktualnosci | `System.Collections.Generic.IEnumerable<Soneta.HR.ZKL.OpisStanowiska.Odpowiedzialnosci.ObszarOdpowiedzialnosciStanowiska>` | podlista |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| OpisAktualizacji | `MemoText` | bazodanowe, podlista | Opis aktualizacji | Opis aktualizacji zapisu |
| OpisLinia | `string` | tylko-odczyt |  |  |
| OpisPierwszaLinia | `string` | tylko-odczyt |  |  |
| OpisStanowiskaZeSkierowaniaNaBad | `string` | bazodanowe |  |  |
| OptymalneWynagrodzenieBrutto | `Currency` | bazodanowe |  |  |
| Parent | `Row` | tylko-odczyt |  |  |
| PoczatkowaWysokoscStawki | `Currency` | bazodanowe |  |  |
| PowodAktualizacji | `string` | bazodanowe, tylko-odczyt | Powód aktualizacji | Opis powodu aktualizacji zapisu |
| Specjalosc | `string` | bazodanowe |  |  |
| SrednieWynagrodzenieBrutto | `Currency` | tylko-odczyt |  |  |
| StanowiskaPodrzedne | `System.Collections.Generic.IEnumerable<Soneta.HR.DefinicjaStanowiska>` | podlista |  |  |
| Stanowisko | `string` | bazodanowe |  |  |
| StanowiskoKierownicze | `bool` | bazodanowe |  |  |
| StanowiskoNadrzedne | `Soneta.HR.DefinicjaStanowiska` | bazodanowe |  |  |
| StanowiskoPelne | `string` | bazodanowe |  |  |
| TypStawki | `Soneta.Kadry.TypStawkiZaszeregowania` (enum) | bazodanowe |  |  |
| Zaszeregowanie | `Soneta.Kadry.Zaszeregowanie` (subrow) | bazodanowe |  |  |
| Zaszeregowanie.Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Zaszeregowanie.Godzinowe | `bool` | tylko-odczyt |  |  |
| Zaszeregowanie.Miesięczne | `bool` | tylko-odczyt |  |  |
| Zaszeregowanie.RodzajStawki | `Soneta.Kadry.RodzajStawkiZaszeregowania` (enum) | bazodanowe |  |  |
| Zaszeregowanie.Stawka | `Currency` | bazodanowe |  |  |
| Zaszeregowanie.TypStawki | `Soneta.Kadry.TypStawkiZaszeregowania` (enum) |  |  |  |
| Zaszeregowanie.WgElement | `Key` | podlista |  |  |
| Zaszeregowanie.WskaznikKrotnosc | `double` | bazodanowe |  |  |
| Zaszeregowanie.WskaznikNazwa | `string` | bazodanowe |  |  |
| Zaszeregowanie.Wymiar | `Fraction` | bazodanowe |  |  |
| ZklInfo | `Soneta.HR.DefinicjaStanowiskaHistZkl` | tylko-odczyt |  |  |

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
