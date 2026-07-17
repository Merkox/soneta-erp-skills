# Pola i właściwości klasy biznesowej: `Soneta.Kadry.UmowaZewnetrznaHistoria`
Nazwa tabeli: `UmowyZewnHist`
Tytuł: UmowyZewnetrzne
Opis: Element szczegółowy umowy zewnętrznej (UmowaZewnetrzna). Wersja historyczna umowy zewnętrznej rejestrująca zmiany zakresu umowy, stanowiska, okresu obowiązywania, kalendarza i powodu aktualizacji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Umowa` → `UmowaZewnetrzna`

- pola bazodanowe: 13
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| DefinicjaStanowiska | `Soneta.HR.DefinicjaStanowiska` | bazodanowe |  |  |
| DefinicjaStanowiskaHistoria | `Soneta.HR.DefinicjaStanowiskaHist` |  |  |  |
| IndywidualnyKalendarz | `bool` | bazodanowe |  |  |
| InterpretacjaKalendarza | `Soneta.Kadry.InterpretacjaKalendarza` | bazodanowe, enum |  |  |
| Kalendarz | `Soneta.Kalend.Kalendarz` | bazodanowe |  | Domyślny kalendarz umowy |
| Nastepny | `Soneta.Kadry.UmowaZewnetrznaHistoria` |  |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Parent | `Soneta.Business.Row` |  |  |  |
| Poprzedni | `Soneta.Kadry.UmowaZewnetrznaHistoria` |  |  |  |
| PowodAktualizacji | `string` | bazodanowe | Powód aktualizacji | Opis powodu aktualizacji zapisu |
| Stanowisko | `string` | bazodanowe |  |  |
| Typ | `Soneta.Kadry.TypUmowyZewnetrznej` | bazodanowe, enum |  |  |
| Umowa | `Soneta.Kadry.UmowaZewnetrzna` | bazodanowe, guided-parent |  |  |
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
