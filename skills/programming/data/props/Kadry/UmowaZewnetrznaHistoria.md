# Pola i właściwości klasy biznesowej: `Soneta.Kadry.UmowaZewnetrznaHistoria`
Nazwa tabeli: `UmowyZewnHist`
Tytuł: UmowyZewnetrzne
Opis: Element szczegółowy umowy zewnętrznej (UmowaZewnetrzna). Wersja historyczna umowy zewnętrznej rejestrująca zmiany zakresu umowy, stanowiska, okresu obowiązywania, kalendarza i powodu aktualizacji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Umowa` → `UmowaZewnetrzna`
Historia: Tak — zapis historyczny tabeli `UmowaZewnetrzna`
Selektor: pole `Typ` (`Soneta.Kadry.TypUmowyZewnetrznej`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `FromTo` | bazodanowe, podlista |  |  |
| Data | `Date` | bazodanowe |  |  |
| DefinicjaStanowiska | `Soneta.HR.DefinicjaStanowiska` | bazodanowe |  |  |
| DefinicjaStanowiskaHistoria | `Soneta.HR.DefinicjaStanowiskaHist` | tylko-odczyt |  |  |
| IndywidualnyKalendarz | `bool` | bazodanowe |  |  |
| InterpretacjaKalendarza | `Soneta.Kadry.InterpretacjaKalendarza` (enum) | bazodanowe |  |  |
| Kalendarz | `Soneta.Kalend.Kalendarz` | bazodanowe |  | Domyślny kalendarz umowy |
| Nastepny | `Soneta.Kadry.UmowaZewnetrznaHistoria` | tylko-odczyt |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Parent | `Row` | tylko-odczyt |  |  |
| Poprzedni | `Soneta.Kadry.UmowaZewnetrznaHistoria` | tylko-odczyt |  |  |
| PowodAktualizacji | `string` | bazodanowe, tylko-odczyt | Powód aktualizacji | Opis powodu aktualizacji zapisu |
| Stanowisko | `string` | bazodanowe |  |  |
| Typ | `Soneta.Kadry.TypUmowyZewnetrznej` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| Umowa | `Soneta.Kadry.UmowaZewnetrzna` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| WgZestawien | `bool` | bazodanowe |  |  |
| ZakresUmowy | `string` | bazodanowe |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Typ`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `UmowaB2B` | 1 | `Soneta.Kadry.UmowaB2BHistoria` |  |
| `UmowaAPT` | 2 | `Soneta.Kadry.UmowaAPTHistoria` |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### InterpretacjaKalendarza (`Soneta.Kadry.InterpretacjaKalendarza`)
- `WgPlanu` = 0
- `WgObecnosci` = 1 — Wg obecności
- `WgZestawien` = 2 — Wg zestawień

### TypUmowyZewnetrznej (`Soneta.Kadry.TypUmowyZewnetrznej`)
- `Wszystkie` = 0 — Wszystkie
- `UmowaB2B` = 1 — Umowa B2B
- `UmowaAPT` = 2 — Umowa APT
