# Pola i właściwości klasy biznesowej: `Soneta.Kalend.WeryfikatorKalendarza`
Nazwa tabeli: `WeryfKalend`
Tytuł: Weryfikatory dla kalendarzy
Opis: Element szczegółowy kalendarza (KalendarzBase). Przypisanie weryfikatora do kalendarza pracy, określające typ weryfikacji (ostrzeżenie/błąd) stosowanej podczas walidacji danych kalendarza.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Kalend.DefinicjaWeryfikatoraKalendarza` | bazodanowe |  |  |
| Kalendarz | `Soneta.Kalend.KalendarzBase` | bazodanowe |  |  |
| Typ | `Soneta.Kalend.TypWeryfikacjiKalendarza` | bazodanowe, enum |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypWeryfikacjiKalendarza (`Soneta.Kalend.TypWeryfikacjiKalendarza`)
- `Warning` = 100 — Ostrzeżenie
- `Error` = 200 — Błąd
