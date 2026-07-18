# Pola i właściwości klasy biznesowej: `Soneta.Kalend.ZbiegPracyIRodzicielstwa`
Nazwa tabeli: `ZbiegiPracyIRodz`
Tytuł: Zbiegi pracy i rodzicielstwa
Opis: Rejestracja zbiegu pracy z uprawnieniami rodzicielskimi (urlop macierzyński, wychowawczy). Przechowuje okres, wymiar etatu, powiązanie z członkiem rodziny oraz informacje niezbędne do rozliczenia zasiłków w przypadku łączenia pracy z urlopem rodzicielskim.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IBazaZrodlaWyplaty`

- pola bazodanowe (zapisywalne): 6
- pola kalkulowane (zapisywalne): 7
- pola tylko-odczyt: 11
- podlisty: 5
- subrowy: 2
- razem: 31

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BlokadaOkresu | `bool` | tylko-odczyt |  |  |
| CzescUrlopu | `int` | bazodanowe |  |  |
| CzlonekRodziny | `Soneta.Kadry.CzlonekRodziny` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaNieobecnosci` | bazodanowe |  |  |
| Elementy | `SubTable<Soneta.Place.WypElement>` | podlista | Elementy wynagrodzenia |  |
| ElementyAktywne | `System.Collections.Generic.ICollection<Soneta.Place.WypElement>` | podlista |  |  |
| IlośćDni | `int` |  |  |  |
| IsRozliczona | `bool` | tylko-odczyt |  |  |
| Macierzynski | `Soneta.Kalend.UrlopMacierzyński` (subrow) | bazodanowe |  |  |
| Macierzynski.CzescUrlopu | `int` |  |  |  |
| Macierzynski.CzlonekRodziny | `Soneta.Kadry.CzlonekRodziny` |  |  |  |
| Macierzynski.Limit | `int` | tylko-odczyt |  |  |
| Macierzynski.Nieobecnosc | `Soneta.Kalend.INieobecnoscLubZbieg` | tylko-odczyt |  |  |
| Macierzynski.PonownieUstalPodstawe | `bool` | tylko-odczyt |  |  |
| Macierzynski.ProcentZasiłku | `Percent` | tylko-odczyt |  |  |
| Macierzynski.Rozliczenie | `Soneta.Kalend.RozliczenieUrlopuMacierzyńskiego` (enum) | bazodanowe |  |  |
| Macierzynski.ZawieszenieSkladkiFP | `bool` |  |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| PonownieUstalPodstawe | `bool` | tylko-odczyt |  |  |
| PracHistoria | `Soneta.Kadry.PracHistoria` | tylko-odczyt |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| Rozliczenia | `SubTable` | podlista |  |  |
| RozliczonyOkres | `FromTo` | podlista |  |  |
| TypDni | `Soneta.Kalend.TypyDni` (enum) | tylko-odczyt |  |  |
| Wychowawczy | `Soneta.Kalend.UrlopWychowawczy` (subrow) | bazodanowe |  |  |
| Wychowawczy.CzescUrlopu | `int` |  |  |  |
| Wychowawczy.CzlonekRodziny | `Soneta.Kadry.CzlonekRodziny` |  |  |  |
| Wychowawczy.Nieobecnosc | `Soneta.Kalend.INieobecnoscLubZbieg` | tylko-odczyt |  |  |
| Wychowawczy.ZawieszenieSkladkiFP | `bool` |  |  |  |
| WymiarEtatu | `Fraction` | bazodanowe |  |  |
| ZawieszenieSkladkiFP | `bool` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RozliczenieUrlopuMacierzyńskiego (`Soneta.Kalend.RozliczenieUrlopuMacierzyńskiego`)
- `NieDotyczy` = 0
- `UrlopMacierzyński100` = 1 — Urlop macierzyński (100%)
- `UrlopMacierzyński80` = 2 — Urlop macierzyński (80%)
- `UrlopMacierzyński0` = 3 — Urlop macierzyński (bez zasiłku)
- `UrlopMacierzyński815` = 4 — Urlop macierzyński (81,50%)
- `UrlopRodzicielski80` = 10 — Urlop rodzicielski (80%)
- `UrlopRodzicielski60` = 11 — Urlop rodzicielski (60%)
- `UrlopRodzicielski100` = 12 — Urlop rodzicielski (100%)
- `UrlopRodzicielski0` = 13 — Urlop rodzicielski (bez zasiłku)
- `UrlopRodzicielski815` = 14 — Urlop rodzicielski (81,50%)
- `UrlopRodzicielski70` = 15 — Urlop rodzicielski (70%)
- `UrlopRodzicielski70do9tyg` = 16 — Urlop rodzicielski (70% do 9 tygodni)
- `UrlopRodzicielski70ZaZyciem` = 17 — Urlop rodzicielski (70% ustawa "Za życiem")
- `UrlopRodzicielski815ZaZyciem` = 18 — Urlop rodzicielski (81,5% ustawa "Za życiem")

### TypyDni (`Soneta.Kalend.TypyDni`)
- `Pracy` = 0 — Pracy
- `Kalendarzowe` = 1
