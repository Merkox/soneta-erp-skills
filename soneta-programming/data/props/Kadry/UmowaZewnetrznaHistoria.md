# Pola i właściwości klasy biznesowej: `Soneta.Kadry.UmowaZewnetrznaHistoria`
Nazwa tabeli: `UmowyZewnHist`
Tytuł: UmowyZewnetrzne
Opis: Element szczegółowy umowy zewnętrznej (UmowaZewnetrzna). Wersja historyczna umowy zewnętrznej rejestrująca zmiany zakresu umowy, stanowiska, okresu obowiązywania, kalendarza i powodu aktualizacji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Umowa` → `UmowaZewnetrzna`
Historia: Tak — zapis historyczny tabeli `UmowaZewnetrzna`

- pola bazodanowe (zapisywalne): 8
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 7
- podlisty: 2
- subrowy: 0
- razem: 17

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
| Typ | `Soneta.Kadry.TypUmowyZewnetrznej` (enum) | bazodanowe, tylko-odczyt |  |  |
| Umowa | `Soneta.Kadry.UmowaZewnetrzna` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| WgZestawien | `bool` | bazodanowe |  |  |
| ZakresUmowy | `string` | bazodanowe |  |  |

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
