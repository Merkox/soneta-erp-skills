# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DefinicjaNieobecnosci`
Nazwa tabeli: `DefNieobecnosci`
Tytuł: Definicje nieobecności
Opis: Konfigurowalna definicja nieobecności. Określa typ nieobecności (urlop, choroba, macierzyński itp.), sposób rozliczenia, powiązanie z limitem i elementem wypłaty, wpływ na PFRON, staż pracy, składki oraz wyświetlanie w pulpitach pracowniczych.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IŹródłoKoloruElementu`

- pola bazodanowe: 33
- pola kalkulowane (z klas biznesowych): 10

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| DlaEtatu | `bool` | bazodanowe |  |  |
| DlaUmowy | `bool` | bazodanowe |  |  |
| Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| ElementZbieg | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| GenerujPowiadomienieDoZ15 | `bool` | bazodanowe |  |  |
| Kod | `string` | bazodanowe |  |  |
| KodRGA | `Soneta.Kadry.KodRGA` | bazodanowe, enum |  |  |
| KodRSA | `Soneta.Place.KodRSA` | bazodanowe |  |  |
| Kolory | `Soneta.Business.SubTable<Soneta.Kalend.KolorElementu>` |  |  |  |
| Limit | `Soneta.Kalend.DefinicjaLimitu` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NeutralName | `string` |  |  |  |
| NieobecnoscPomniejszaOkresRJR | `bool` | bazodanowe |  |  |
| PFRON | `Soneta.Kalend.WpływaNaPFRON` | bazodanowe, enum |  |  |
| Planowana | `bool` | bazodanowe |  |  |
| PomnOkresSzWarunkiSzCharakter | `Soneta.Kalend.PomnOkresSzWarunkiSzCharakter` | bazodanowe, enum |  |  |
| PomniejszaCzasPracy | `bool` |  |  |  |
| PomniejszaCzasPracyUmowy | `bool` | bazodanowe |  |  |
| PomniejszaLimitUrlopu | `bool` | bazodanowe |  |  |
| PomniejszaLimitUrlopu2023 | `Soneta.Kalend.PomniejszaLimitUrlopu` | bazodanowe, enum |  |  |
| PomniejszaLimitUrlopuTymczasowy | `bool` | bazodanowe |  |  |
| PomniejszaStaz | `bool` |  |  |  |
| PomniejszaStazPracy | `Soneta.Kalend.PomniejszeniaStażuPracy` | bazodanowe, enum |  |  |
| PomniejszaWynagrodzenie | `bool` | bazodanowe |  |  |
| PrzerwaSzWarunkiSzCharakter | `bool` |  |  |  |
| Przyczyna | `Soneta.Kalend.PrzyczynaNieobecnosci` | bazodanowe, enum |  |  |
| Rozliczenie | `Soneta.Kalend.RozliczenieNieobecnosci` | bazodanowe, enum |  |  |
| SOD | `Soneta.Kalend.WpływaNaSOD` | bazodanowe, enum | SODiR (WE) |  |
| SOD2010 | `Soneta.Kalend.WpływaNaSOD` | enum | SODiR (ustawa i WE) |  |
| SODUstawa | `Soneta.Kalend.WpływaNaSOD` | bazodanowe, enum | SODiR (ustawa) |  |
| Skrot | `string` | bazodanowe |  |  |
| SposobPomniejszania | `Soneta.Kalend.SposobyPomniejszania` | bazodanowe, enum |  |  |
| SposóbPomniejszaniaLimituUrlopu | `Soneta.Kalend.SposobyPomniejszaniaLimituUrlopu` | enum |  |  |
| Typ | `Soneta.Kalend.TypNieobecnosci` | bazodanowe, enum |  |  |
| TypDni | `Soneta.Kalend.TypyDni` | enum |  |  |
| TypOkresu | `Soneta.Kalend.TypOkresuNieobecności` | bazodanowe, enum |  |  |
| UrlopNaDni | `bool` | bazodanowe |  |  |
| Weryfikuj | `bool` | bazodanowe |  |  |
| WniosekUrlopowy | `bool` | bazodanowe |  |  |
| WymaganeUbezpieczenie | `Soneta.Place.WymaganeUbezpieczenie` | enum |  |  |
| ZawieszenieSkladkiFP | `bool` |  | Zawieszenie składki na FP |  |
| ZawieszenieSkladkiFPMies | `int` | bazodanowe | Zawieszenie składki na FP (mies.) |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KodRGA (`Soneta.Kadry.KodRGA`)
- `NieWchodzi` = 0 — 0 - nie wchodzi
- `UrlopWypoczynkowy` = 1 — 1 - urlop wypoczynkowy
- `UrlopSzkoleniowy` = 2 — 2 - urlop szkoleniowy
- `DelegacjaSluzbowa` = 3 — 3 - delegacja służbowa
- `BadaniaLekarskie` = 4 — 4 - usprawiedliwiona nieobecność w pracy z powodu okresowych badań lekarskich
- `InneUsprawiedliwione` = 5 — 5 - inne usprawiedliwione nieobecności

### PomnOkresSzWarunkiSzCharakter (`Soneta.Kalend.PomnOkresSzWarunkiSzCharakter`)
- `Domyślnie` = 0
- `Pomniejsza` = 1
- `NiePomniejsza` = 2

### PomniejszaLimitUrlopu (`Soneta.Kalend.PomniejszaLimitUrlopu`)
- `Nie` = 0
- `Tak` = 1
- `PomniejszaWarunkowo` = 2

### PomniejszeniaStażuPracy (`Soneta.Kalend.PomniejszeniaStażuPracy`)
- `NiePomniejsza` = 0 — Nie pomniejsza
- `ZawszePomniejsza` = 1
- `PomniejszaDoDniaZakończenia` = 2

### PrzyczynaNieobecnosci (`Soneta.Kalend.PrzyczynaNieobecnosci`)
- `NieDotyczy` = 0
- `NieusprawiedliwionaNiepłatna` = 1
- `SłużbaWojskowa` = 10
- `UrlopBezpłatny` = 11
- `UsprawiedliwionaNiepłatna` = 12
- `UrlopOpiekuńczyBezZasiłku` = 13
- `UsprawiedliwionaPłatna` = 20
- `UrlopWypoczynkowy` = 21
- `UrlopOkolicznościowy` = 22
- `BadanieLekarskie` = 23
- `DelegacjaSłużbowa` = 24
- `ZwolnienieSiłaWyższa` = 25 — Zwolnienie - siła wyższa
- `UrlopRadcowski` = 26
- `UrlopWychowawczy` = 30
- `UrlopWychowawczyZUS` = 31 — Urlop wychowawczy (płaci ZUS)
- `UrlopMacierzyński` = 40
- `UrlopRehabilitacyjny` = 41
- `UrlopOpiekuńczy` = 42
- `ZwolnienieChorobowe` = 43
- `UrlopRodzicielski` = 44
- `UrlopOjcowski` = 45
- `UrlopMacierzyńskiUzupełniający` = 46

### RozliczenieNieobecnosci (`Soneta.Kalend.RozliczenieNieobecnosci`)
- `Brak` = 0 — Brak
- `JakWybranyElement` = 1
- `JakZwolnienieChorobowe` = 2
- `JakUrlopOpiekuńczy` = 3
- `JakUrlopRehabilitacyjny` = 6
- `JakUrlopMacierzyński` = 7

### SposobyPomniejszania (`Soneta.Kalend.SposobyPomniejszania`)
- `NiePomniejsza` = 0 — Nie pomniejsza
- `Domyślnie` = 1
- `JakNieusprawiedliwiona` = 10
- `JakUsprawiedliwionaBezpłatna` = 11
- `JakUsprawiedliwionaPłatna` = 12
- `JakUrlopWychowawczy` = 13
- `JakUrlopMacierzyński` = 20
- `JakUrlopRehabilitacyjny` = 21
- `JakUrlopOpiekuńczy` = 22
- `JakZwolnienieChorobowe` = 23

### SposobyPomniejszaniaLimituUrlopu (`Soneta.Kalend.SposobyPomniejszaniaLimituUrlopu`)
- `NiePomniejsza` = 0 — Nie pomniejsza
- `Pomniejsza` = 1
- `JakWychowawczy` = 2

### TypNieobecnosci (`Soneta.Kalend.TypNieobecnosci`)
- `Nieusprawiedliwiona` = 1
- `UsprawiedliwionaBezpłatna` = 2
- `UsprawiedliwionaPłatna` = 3
- `UrlopWychowawczy` = 4
- `NieobecnośćZUS` = 5 — Nieobecność ZUS
- `Storno` = 99

### TypOkresuNieobecności (`Soneta.Kalend.TypOkresuNieobecności`)
- `WDniach` = 0 — W dniach
- `WDniachLubWGodzinach` = 1 — W dniach lub w godzinach

### TypyDni (`Soneta.Kalend.TypyDni`)
- `Pracy` = 0 — Pracy
- `Kalendarzowe` = 1

### WpływaNaPFRON (`Soneta.Kalend.WpływaNaPFRON`)
- `NieWpływa` = 0
- `Zawsze` = 1 — Tylko pełnosprawni
- `Warunkowo` = 2 — Wszyscy
- `Niepełnosprawni` = 3 — Tylko niepełnosprawni

### WpływaNaSOD (`Soneta.Kalend.WpływaNaSOD`)
- `NieWpływa` = 0
- `Pełnosprawni` = 1 — Tylko pełnosprawni
- `Wszyscy` = 2
- `Niepełnosprawni` = 3 — Tylko niepełnosprawni

### WymaganeUbezpieczenie (`Soneta.Place.WymaganeUbezpieczenie`)
- `NieWymaga` = 0 — Nie wymaga
- `Dowolne` = 1
- `Chorobowe` = 2
- `Wypadkowe` = 3
