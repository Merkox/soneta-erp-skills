# Pola i właściwości klasy biznesowej: `Soneta.Kalend.LimitNieobecnosci`
Nazwa tabeli: `LimNieobecnosci`
Tytuł: Limity nieobecności
Opis: Element szczegółowy pracownika (Pracownik). Przechowuje indywidualny limit nieobecności pracownika w danym okresie, w tym wartości bazowe, korekty, wykorzystanie oraz przeliczenia godzinowe dla urlopu wypoczynkowego.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

- pola bazodanowe: 19
- pola kalkulowane (z klas biznesowych): 24

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Kalend.DefinicjaLimitu` | bazodanowe |  |  |
| Ekwiwalent | `int` | bazodanowe |  | Ilość dni wypłaconych w ekwiwalencie |
| EkwiwalentGodz | `Soneta.Types.Time` | bazodanowe |  | Ilość godzin wypłaconych w ekwiwalencie |
| Godzinowy | `Soneta.Kalend.LimitNieobecnosci` |  |  |  |
| Godziny | `bool` |  |  |  |
| Korekta | `int` | bazodanowe |  | Korekta wartości limitu ze względu na urlopy bezpłatne trwające dłużej niż 1 miesiąc |
| KorektaMies | `int` | bazodanowe |  | Korekta długości okresu (ilości miesięcy) ze względu na urlopy bezpłatne trwające dłużej niż 1 miesiąc |
| KumulowanyMinus | `bool` | bazodanowe |  |  |
| KumulowanyPlus | `bool` |  |  |  |
| Limit | `int` | bazodanowe |  |  |
| LimitDni | `int` |  |  |  |
| LimitGodz | `Soneta.Types.Time` | bazodanowe |  | Limit w godzinach wynikający z kodeksu pracy |
| LimitZależny | `Soneta.Kalend.LimitNieobecnosci` |  |  |  |
| Naliczanie | `Soneta.Kalend.NaliczanieLimitu` | bazodanowe, enum |  |  |
| NaliczanieJakUrlop | `bool` |  |  |  |
| Next | `Soneta.Kalend.LimitNieobecnosci` |  |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| OkresWażności | `Soneta.Types.FromTo` |  |  |  |
| PierwszyUrlop | `bool` | bazodanowe |  |  |
| PodstawaGodz | `decimal` | bazodanowe |  | Limit urlopu po uwzględnieniu wymiaru etatu |
| Pozostalo | `int` |  |  |  |
| PozostaloDni | `double` |  | Pozostało dni |  |
| PozostaloDniLabel | `string` |  |  |  |
| PozostaloGodz | `Soneta.Types.Time` |  | Pozostało godz. |  |
| PracHistoria | `Soneta.Kadry.PracHistoria` |  |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, guided-parent |  |  |
| Prev | `Soneta.Kalend.LimitNieobecnosci` |  |  |  |
| Prosty | `Soneta.Kalend.LimitNieobecnosci` |  |  |  |
| Przeniesienie | `int` |  |  |  |
| PrzeniesienieDni | `double` |  |  |  |
| PrzeniesienieGodz | `Soneta.Types.Time` |  |  |  |
| Razem | `int` |  |  |  |
| RazemGodz | `Soneta.Types.Time` |  |  |  |
| Typ | `Soneta.Kalend.TypLimituNieobecności` | bazodanowe, enum |  |  |
| UrlopDni | `Soneta.Kalend.LimitNieobecnosci` |  |  |  |
| UrlopGodz | `Soneta.Kalend.LimitNieobecnosci` |  |  |  |
| Wykorzystane | `int` | bazodanowe |  | Ilość wykorzystanych dni urlopu |
| WykorzystaneGodz | `Soneta.Types.Time` | bazodanowe |  | Ilość wykorzystanych godzin urlopu |
| WykorzystanyPoprzGodz | `Soneta.Types.Time` | bazodanowe |  | Limit urlopu wypoczynkowego wykorzystanego u poprzednich pracodawców przypadający na bieżące zatrudnienie (godz.) |
| ZaleglyDni | `double` |  | Zaległy dni |  |
| ZaleglyGodz | `Soneta.Types.Time` |  | Zaległy godz |  |
| Zmiana | `int` | bazodanowe |  | Zmiana wartości limitu wprowadzona przez użytkownika |
| ZmianaGodz | `Soneta.Types.Time` | bazodanowe |  | Zmiana wartości limitu/godz wprowadzona przez użytkownika |

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
