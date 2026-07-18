# Pola i właściwości klasy biznesowej: `Soneta.Kadry.DefPodstawyStazu`
Nazwa tabeli: `DefPodstawStazu`
Tytuł: Def. podstaw stażu pracy
Opis: Definicja podstawy naliczania stażu pracy. Pozwala skonfigurować, które okresy (nauki, pracy, niewliczane) są uwzględniane przy wyliczaniu poszczególnych rodzajów stażu, np. stażu urlopowego czy ogólnego stażu pracy.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 8
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| OkresNauki | `bool` | bazodanowe |  |  |
| OkresyNiewliczane | `bool` | bazodanowe |  |  |
| RodzajPodstawy | `Soneta.Kadry.RodzajPodstawyStażuPracy` (enum) | tylko-odczyt |  |  |
| StazDoUrlopu | `bool` | bazodanowe |  |  |
| StazPodsumowanie | `bool` | bazodanowe |  |  |
| StazPracy | `bool` | bazodanowe |  |  |
| StazPracyWFirmie | `bool` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajPodstawyStażuPracy (`Soneta.Kadry.RodzajPodstawyStażuPracy`)
- `OkresNauki` = 1
- `StazDoUrlopu` = 2
- `StazPracy` = 4
- `StazPracyWFirmie` = 8
