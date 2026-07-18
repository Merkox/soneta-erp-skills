# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.ZnacznikKonta`
Nazwa tabeli: `ZnacznikiKont`
Tytuł: Znaczniki kont
Opis: Znacznik konta umożliwia dodatkową klasyfikację kont księgowych niezależnie od struktury planu kont. Pozwala oznaczać konta symbolami i opisami w celu grupowania, filtrowania i raportowania, np. do celów podatkowych lub sprawozdawczych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 10
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 12

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Blokuje znacznik konta |
| Lp | `int` | bazodanowe |  | Liczba porządkowa znacznika konta |
| Opis | `string` | tylko-odczyt |  |  |
| Opis1 | `string` | bazodanowe |  |  |
| Opis2 | `string` | bazodanowe |  |  |
| Opis3 | `string` | bazodanowe |  |  |
| Opis4 | `string` | bazodanowe |  |  |
| Opis5 | `string` | bazodanowe |  |  |
| Opis6 | `string` | bazodanowe |  |  |
| Symbol | `string` | bazodanowe | Symbol znacznika |  |
| TypKonta | `Soneta.Ksiega.TypKontaZnacznikaKonta` (enum) | bazodanowe | Typ konta znacznika | Typ konta znacznika |
| TypZnacznika | `Soneta.Ksiega.TypZnacznikaKonta` (enum) | bazodanowe, tylko-odczyt |  | Typ znacznika konta |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypKontaZnacznikaKonta (`Soneta.Ksiega.TypKontaZnacznikaKonta`)
- `Brak` = 0
- `Aktywa` = 1
- `Pasywa` = 2
- `Wynikowe` = 3
- `Bilansowe` = 4
- `Pozabilansowe` = 5
- `PD` = 6
- `RW` = 7
- `RZIS` = 8
- `Inne` = 9

### TypZnacznikaKonta (`Soneta.Ksiega.TypZnacznikaKonta`)
- `Brak` = 0
- `Banki` = 1
- `ZakladyUbezpieczen` = 2 — Zakłady ubezpieczeń i zakłady reasekuracji
- `JednostkiPubliczne` = 3 — Organizacje pożytku publicznego
- `FunduszeInwestycyjne` = 4 — Fundusze inwestycyjne
- `DomyMaklerskie` = 5 — Domy maklerskie
- `SpoldzielczeKasy` = 6 — Spółdzielcze kasy oszczędnościowo-kredytowe
- `PozostaleJednostki` = 7 — Pozostałe jednostki
- `PD_Pozabilansowe` = 8 — Konta PD/pozabilansowe
- `MSSF` = 9
