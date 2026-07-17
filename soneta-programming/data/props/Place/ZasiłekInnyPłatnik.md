# Pola i właściwości klasy biznesowej: `Soneta.Place.ZasiłekInnyPłatnik`
Nazwa tabeli: `ZasInnyPlatnik`
Tytuł: Zasiłki (inny płatnik)
Opis: Ewidencja zasiłków wypłacanych pracownikowi przez innego płatnika (np. ZUS). Rejestruje rodzaj zasiłku, kwotę i datę wypłaty, co wpływa na naliczanie podatku i deklaracje roczne pracownika.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Kwota | `decimal` | bazodanowe |  |  |
| Miesiąc | `Soneta.Types.YearMonth` |  |  |  |
| MiesiącDeklaracji | `Soneta.Types.YearMonth` |  |  |  |
| Netto | `bool` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Rodzaj | `Soneta.Place.RodzajZasiłkuInnegoPłatnika` | bazodanowe, enum |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajZasiłkuInnegoPłatnika (`Soneta.Place.RodzajZasiłkuInnegoPłatnika`)
- `Macierzyński` = 1 — Macierzyński
