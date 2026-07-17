# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.UczestnikHist`
Nazwa tabeli: `UczestnicyHist`
Tytuł: Historia uczestników, członków
Opis: Rejestr zmian statusu członkostwa uczestników w organizacji. Przechowuje chronologiczną historię zmian stanów, takich jak przyjęcie, zawieszenie czy skreślenie, wraz z numerami protokołów i uchwał.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe | Data zmiany | Data zmiany. |
| DyplomStan | `Soneta.CzlonkowieSzkolenia.StanUczestnika` | bazodanowe, enum |  |  |
| Opis | `string` | bazodanowe | Dodatkowy opis | Dodatkowy opis. |
| Protokol | `string` | bazodanowe | Numer protokołu | Numer protokołu. |
| Stan | `Soneta.CzlonkowieSzkolenia.StanUczestnika` | bazodanowe, enum |  |  |
| Uchwala | `string` | bazodanowe | Numer uchwały | Numer uchwały. |
| Uczestnik | `Soneta.CzlonkowieSzkolenia.UczestnikBase` | bazodanowe |  |  |
| Zmiana | `string` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StanUczestnika (`Soneta.CzlonkowieSzkolenia.StanUczestnika`)
- `NieDotyczy` = 0 — Nie dotyczy
- `Oczekujący` = 1
- `Czynny` = 2
- `Skreślony` = 3
- `Razem` = 99
