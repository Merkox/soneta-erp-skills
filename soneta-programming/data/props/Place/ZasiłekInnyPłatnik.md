# Pola i właściwości klasy biznesowej: `Soneta.Place.ZasiłekInnyPłatnik`
Nazwa tabeli: `ZasInnyPlatnik`
Tytuł: Zasiłki (inny płatnik)
Opis: Ewidencja zasiłków wypłacanych pracownikowi przez innego płatnika (np. ZUS). Rejestruje rodzaj zasiłku, kwotę i datę wypłaty, co wpływa na naliczanie podatku i deklaracje roczne pracownika.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 4
- podlisty: 0
- subrowy: 0
- razem: 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe, tylko-odczyt |  |  |
| Kwota | `decimal` | bazodanowe |  |  |
| Miesiąc | `YearMonth` |  |  |  |
| MiesiącDeklaracji | `YearMonth` | tylko-odczyt |  |  |
| Netto | `bool` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| Rodzaj | `Soneta.Place.RodzajZasiłkuInnegoPłatnika` (enum) | bazodanowe, tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajZasiłkuInnegoPłatnika (`Soneta.Place.RodzajZasiłkuInnegoPłatnika`)
- `Macierzyński` = 1 — Macierzyński
