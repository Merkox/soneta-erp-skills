# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DefinicjaLimitu`
Nazwa tabeli: `DefinicjeLimitow`
Tytuł: Definicje limitów
Opis: Konfigurowalna definicja limitu nieobecności. Określa typ limitu (np. urlop wypoczynkowy, opieka), sposób naliczania, kumulowanie oraz proporcjonalność do wymiaru etatu. Może być powiązana z innym limitem w celu wspólnego zaokrąglenia.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 16
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 6
- podlisty: 1
- subrowy: 0
- razem: 24

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Automatyczny | `bool` | bazodanowe |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| DefinicjeZależne | `System.Collections.Generic.IEnumerable<Soneta.Kalend.DefinicjaLimitu>` | podlista |  |  |
| Kumulowany | `bool` | bazodanowe |  |  |
| KumulowanyMinus | `bool` | bazodanowe |  |  |
| KumulowanyPlus | `bool` |  |  |  |
| Limit | `int` | bazodanowe |  |  |
| LimitZUwzglednieniemNormy | `bool` | bazodanowe |  |  |
| Naliczanie | `Soneta.Kalend.NaliczanieLimitu` (enum) | bazodanowe |  |  |
| NaliczanieJakUrlop | `bool` | tylko-odczyt |  |  |
| NaliczanieNaGodziny | `bool` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NeutralName | `string` | tylko-odczyt |  |  |
| Opieka188 | `bool` | tylko-odczyt |  |  |
| OpiekunczyBezplatny | `bool` | tylko-odczyt |  |  |
| PierwszyUrlop | `bool` | bazodanowe |  |  |
| PowiazanyWniosekONieobecnosc | `Soneta.Core.DbTuples.DbTupleDefinition` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| Proporcjonalny | `bool` | bazodanowe |  |  |
| SilaWyzsza | `bool` | tylko-odczyt |  |  |
| TylkoOstrzezenie | `bool` | bazodanowe |  |  |
| Typ | `Soneta.Kalend.TypLimitu` (enum) | bazodanowe |  |  |
| WspolneZaokraglenie | `Soneta.Kalend.DefinicjaLimitu` | bazodanowe |  |  |
| WyswietlajNaWidzecieLimity | `bool` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### NaliczanieLimitu (`Soneta.Kalend.NaliczanieLimitu`)
- `NaDni` = 1 — Na dni pracy
- `WypoczynkowyNaDni` = 2
- `WypoczynkowyNaGodziny` = 3
- `WypoczynkowyPracTymcz` = 4 — Wypoczynkowy prac. tymcz.
- `NaDniKalendarzowe` = 5
- `NaGodziny` = 6
- `OpiekaNaDni` = 10
- `OpiekaNaGodziny` = 11
- `SilaWyzszaNaDni` = 12 — Siła wyższa (dni)
- `SilaWyzszaNaGodziny` = 13 — Siła wyższa (godz)
- `OpiekuńczyNaDni` = 14

### TypLimitu (`Soneta.Kalend.TypLimitu`)
- `Roczny` = 0 — Roczny
- `DowolnyWRoku` = 1
- `Dowolny` = 2
