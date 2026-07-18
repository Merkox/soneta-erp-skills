# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.UczestnikHist`
Nazwa tabeli: `UczestnicyHist`
Tytuł: Historia uczestników, członków
Opis: Rejestr zmian statusu członkostwa uczestników w organizacji. Przechowuje chronologiczną historię zmian stanów, takich jak przyjęcie, zawieszenie czy skreślenie, wraz z numerami protokołów i uchwał.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 7
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe | Data zmiany | Data zmiany. |
| DyplomStan | `Soneta.CzlonkowieSzkolenia.StanUczestnika` (enum) | bazodanowe |  |  |
| Opis | `string` | bazodanowe | Dodatkowy opis | Dodatkowy opis. |
| Protokol | `string` | bazodanowe | Numer protokołu | Numer protokołu. |
| Stan | `Soneta.CzlonkowieSzkolenia.StanUczestnika` (enum) | bazodanowe |  |  |
| Uchwala | `string` | bazodanowe | Numer uchwały | Numer uchwały. |
| Uczestnik | `Soneta.CzlonkowieSzkolenia.UczestnikBase` | bazodanowe |  |  |
| Zmiana | `string` | tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StanUczestnika (`Soneta.CzlonkowieSzkolenia.StanUczestnika`)
- `NieDotyczy` = 0 — Nie dotyczy
- `Oczekujący` = 1
- `Czynny` = 2
- `Skreślony` = 3
- `Razem` = 99
