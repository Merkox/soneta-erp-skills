# Pola i właściwości klasy biznesowej: `Soneta.Kadry.DefPodstawyStazu`
Nazwa tabeli: `DefPodstawStazu`
Tytuł: Def. podstaw stażu pracy
Opis: Definicja podstawy naliczania stażu pracy. Pozwala skonfigurować, które okresy (nauki, pracy, niewliczane) są uwzględniane przy wyliczaniu poszczególnych rodzajów stażu, np. stażu urlopowego czy ogólnego stażu pracy.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| OkresNauki | `bool` | bazodanowe |  |  |
| OkresyNiewliczane | `bool` | bazodanowe |  |  |
| RodzajPodstawy | `Soneta.Kadry.RodzajPodstawyStażuPracy` | enum |  |  |
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
