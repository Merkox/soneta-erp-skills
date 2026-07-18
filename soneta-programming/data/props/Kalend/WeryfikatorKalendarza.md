# Pola i właściwości klasy biznesowej: `Soneta.Kalend.WeryfikatorKalendarza`
Nazwa tabeli: `WeryfKalend`
Tytuł: Weryfikatory dla kalendarzy
Opis: Element szczegółowy kalendarza (KalendarzBase). Przypisanie weryfikatora do kalendarza pracy, określające typ weryfikacji (ostrzeżenie/błąd) stosowanej podczas walidacji danych kalendarza.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Kalend.DefinicjaWeryfikatoraKalendarza` | bazodanowe, tylko-odczyt |  |  |
| Kalendarz | `Soneta.Kalend.KalendarzBase` | bazodanowe, tylko-odczyt |  |  |
| Typ | `Soneta.Kalend.TypWeryfikacjiKalendarza` (enum) | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypWeryfikacjiKalendarza (`Soneta.Kalend.TypWeryfikacjiKalendarza`)
- `Warning` = 100 — Ostrzeżenie
- `Error` = 200 — Błąd
