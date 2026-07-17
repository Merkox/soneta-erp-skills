# Pola i właściwości klasy biznesowej: `Soneta.Kalend.ZbiegPracyIRodzicielstwa`
Nazwa tabeli: `ZbiegiPracyIRodz`
Tytuł: Zbiegi pracy i rodzicielstwa
Opis: Rejestracja zbiegu pracy z uprawnieniami rodzicielskimi (urlop macierzyński, wychowawczy). Przechowuje okres, wymiar etatu, powiązanie z członkiem rodziny oraz informacje niezbędne do rozliczenia zasiłków w przypadku łączenia pracy z urlopem rodzicielskim.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IBazaZrodlaWyplaty`

- pola bazodanowe: 10
- pola kalkulowane (z klas biznesowych): 21

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BlokadaOkresu | `bool` |  |  |  |
| CzescUrlopu | `int` | bazodanowe |  |  |
| CzlonekRodziny | `Soneta.Kadry.CzlonekRodziny` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaNieobecnosci` | bazodanowe |  |  |
| Elementy | `Soneta.Business.SubTable<Soneta.Place.WypElement>` |  | Elementy wynagrodzenia |  |
| ElementyAktywne | `System.Collections.Generic.ICollection<Soneta.Place.WypElement>` |  |  |  |
| IlośćDni | `int` |  |  |  |
| IsRozliczona | `bool` |  |  |  |
| Macierzynski | `Soneta.Kalend.UrlopMacierzyński` | bazodanowe |  |  |
| Macierzynski.CzescUrlopu | `int` |  |  |  |
| Macierzynski.CzlonekRodziny | `Soneta.Kadry.CzlonekRodziny` |  |  |  |
| Macierzynski.Limit | `int` |  |  |  |
| Macierzynski.Nieobecnosc | `Soneta.Kalend.INieobecnoscLubZbieg` |  |  |  |
| Macierzynski.PonownieUstalPodstawe | `bool` |  |  |  |
| Macierzynski.ProcentZasiłku | `Soneta.Types.Percent` |  |  |  |
| Macierzynski.Rozliczenie | `Soneta.Kalend.RozliczenieUrlopuMacierzyńskiego` | bazodanowe, enum |  |  |
| Macierzynski.ZawieszenieSkladkiFP | `bool` |  |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| PonownieUstalPodstawe | `bool` |  |  |  |
| PracHistoria | `Soneta.Kadry.PracHistoria` |  |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Rozliczenia | `Soneta.Business.SubTable` |  |  |  |
| RozliczonyOkres | `Soneta.Types.FromTo` |  |  |  |
| TypDni | `Soneta.Kalend.TypyDni` | enum |  |  |
| Wychowawczy | `Soneta.Kalend.UrlopWychowawczy` | bazodanowe |  |  |
| Wychowawczy.CzescUrlopu | `int` |  |  |  |
| Wychowawczy.CzlonekRodziny | `Soneta.Kadry.CzlonekRodziny` |  |  |  |
| Wychowawczy.Nieobecnosc | `Soneta.Kalend.INieobecnoscLubZbieg` |  |  |  |
| Wychowawczy.ZawieszenieSkladkiFP | `bool` |  |  |  |
| WymiarEtatu | `Soneta.Types.Fraction` | bazodanowe |  |  |
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
