# Pola i właściwości klasy biznesowej: `Soneta.Kadry.OkresWakacjiSkladki`
Nazwa tabeli: `OkresyWakacjiSkladki`
Tytuł: Wakacje składkowe
Opis: Element szczegółowy pracownika (Pracownik). Ewidencja miesięcy, w których przedsiębiorca korzysta ze zwolnienia z opłacania składek ZUS (tzw. wakacje składkowe), z podaniem roku i miesiąca zwolnienia.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Miesiac | `Soneta.Place.DefinicjeMiesiecy` (enum) | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Rok | `int` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DefinicjeMiesiecy (`Soneta.Place.DefinicjeMiesiecy`)
- `styczen` = 0 — styczeń
- `luty` = 1 — luty
- `marzec` = 2 — marzec
- `kwiecien` = 3 — kwiecień
- `maj` = 4 — maj
- `czerwiec` = 5 — czerwiec
- `lipiec` = 6 — lipiec
- `sierpien` = 7 — sierpień
- `wrzesien` = 8 — wrzesień
- `pazdziernik` = 9 — październik
- `listopad` = 10 — listopad
- `grudzien` = 11 — grudzień
