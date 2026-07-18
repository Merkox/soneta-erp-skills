# Pola i właściwości klasy biznesowej: `Soneta.Kalend.LimitNieobecnosci`
Nazwa tabeli: `LimNieobecnosci`
Tytuł: Limity nieobecności
Opis: Element szczegółowy pracownika (Pracownik). Przechowuje indywidualny limit nieobecności pracownika w danym okresie, w tym wartości bazowe, korekty, wykorzystanie oraz przeliczenia godzinowe dla urlopu wypoczynkowego.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`
Selektor: pole `Typ` (`Soneta.Kalend.TypLimituNieobecności`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Kalend.DefinicjaLimitu` | bazodanowe, tylko-odczyt |  |  |
| Ekwiwalent | `int` | bazodanowe, tylko-odczyt |  | Ilość dni wypłaconych w ekwiwalencie |
| EkwiwalentGodz | `Time` | bazodanowe, tylko-odczyt |  | Ilość godzin wypłaconych w ekwiwalencie |
| Godzinowy | `Soneta.Kalend.LimitNieobecnosci` | tylko-odczyt |  |  |
| Godziny | `bool` | tylko-odczyt |  |  |
| Korekta | `int` | bazodanowe, tylko-odczyt |  | Korekta wartości limitu ze względu na urlopy bezpłatne trwające dłużej niż 1 miesiąc |
| KorektaMies | `int` | bazodanowe, tylko-odczyt |  | Korekta długości okresu (ilości miesięcy) ze względu na urlopy bezpłatne trwające dłużej niż 1 miesiąc |
| KumulowanyMinus | `bool` | bazodanowe |  |  |
| KumulowanyPlus | `bool` |  |  |  |
| Limit | `int` | bazodanowe |  |  |
| LimitDni | `int` | tylko-odczyt |  |  |
| LimitGodz | `Time` | bazodanowe, tylko-odczyt |  | Limit w godzinach wynikający z kodeksu pracy |
| LimitZależny | `Soneta.Kalend.LimitNieobecnosci` | tylko-odczyt |  |  |
| Naliczanie | `Soneta.Kalend.NaliczanieLimitu` (enum) | bazodanowe, tylko-odczyt |  |  |
| NaliczanieJakUrlop | `bool` | tylko-odczyt |  |  |
| Next | `Soneta.Kalend.LimitNieobecnosci` | tylko-odczyt |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| OkresWażności | `FromTo` | podlista |  |  |
| PierwszyUrlop | `bool` | bazodanowe |  |  |
| PodstawaGodz | `decimal` | bazodanowe, tylko-odczyt |  | Limit urlopu po uwzględnieniu wymiaru etatu |
| Pozostalo | `int` | tylko-odczyt |  |  |
| PozostaloDni | `double` | tylko-odczyt | Pozostało dni |  |
| PozostaloDniLabel | `string` | tylko-odczyt |  |  |
| PozostaloGodz | `Time` | tylko-odczyt | Pozostało godz. |  |
| PracHistoria | `Soneta.Kadry.PracHistoria` | tylko-odczyt |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Prev | `Soneta.Kalend.LimitNieobecnosci` | tylko-odczyt |  |  |
| Prosty | `Soneta.Kalend.LimitNieobecnosci` | tylko-odczyt |  |  |
| Przeniesienie | `int` | tylko-odczyt |  |  |
| PrzeniesienieDni | `double` | tylko-odczyt |  |  |
| PrzeniesienieGodz | `Time` | tylko-odczyt |  |  |
| Razem | `int` | tylko-odczyt |  |  |
| RazemGodz | `Time` | tylko-odczyt |  |  |
| Typ | `Soneta.Kalend.TypLimituNieobecności` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| UrlopDni | `Soneta.Kalend.LimitNieobecnosci` | tylko-odczyt |  |  |
| UrlopGodz | `Soneta.Kalend.LimitNieobecnosci` | tylko-odczyt |  |  |
| Wykorzystane | `int` | bazodanowe, tylko-odczyt |  | Ilość wykorzystanych dni urlopu |
| WykorzystaneGodz | `Time` | bazodanowe, tylko-odczyt |  | Ilość wykorzystanych godzin urlopu |
| WykorzystanyPoprzGodz | `Time` | bazodanowe, tylko-odczyt |  | Limit urlopu wypoczynkowego wykorzystanego u poprzednich pracodawców przypadający na bieżące zatrudnienie (godz.) |
| ZaleglyDni | `double` | tylko-odczyt | Zaległy dni |  |
| ZaleglyGodz | `Time` | tylko-odczyt | Zaległy godz |  |
| Zmiana | `int` | bazodanowe |  | Zmiana wartości limitu wprowadzona przez użytkownika |
| ZmianaGodz | `Time` | bazodanowe |  | Zmiana wartości limitu/godz wprowadzona przez użytkownika |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Typ`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Standardowy` | 1 | `Soneta.Kalend.LimitNieobecnosciStd` |  |
| `UrlopWypoczynkowy` | 2 | `Soneta.Kalend.LimitUrlopuWypoczynkowego` |  |

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

### TypLimituNieobecności (`Soneta.Kalend.TypLimituNieobecności`)
- `Standardowy` = 1
- `UrlopWypoczynkowy` = 2
