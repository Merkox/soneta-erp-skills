# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DefinicjaStrefy`
Nazwa tabeli: `DefinicjeStref`
Tytuł: Definicje stref
Opis: Konfigurowalna definicja strefy czasu pracy. Określa typ strefy (praca, przerwa, dyżur itp.), sposób rozliczenia, współczynnik wynagrodzenia, wpływ na nadgodziny oraz widoczność w pulpitach pracowniczych.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IŹródłoKoloruElementu`

- pola bazodanowe (zapisywalne): 16
- pola kalkulowane (zapisywalne): 3
- pola tylko-odczyt: 2
- podlisty: 1
- subrowy: 2
- razem: 24

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BackColor | `int` |  |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| ForeColor | `int` |  |  |  |
| KierunekMagazynuNadgodzin | `Soneta.Kalend.KierunekMagazynuNadgodzin` (enum) | tylko-odczyt |  |  |
| Kod | `string` | bazodanowe |  |  |
| Kolory | `SubTable<Soneta.Kalend.KolorElementu>` | podlista |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Net | `Soneta.Kalend.DefinicjaStrefyNet` (subrow) | bazodanowe |  |  |
| Net.WidocznaWNet | `bool` | bazodanowe |  | Czy definicja jest dostępna z poziomu pulpitów |
| OznaczaNieobecnosc | `bool` | bazodanowe |  |  |
| PodstawaNadgodzin | `Soneta.Kalend.TypPodstawyNadgodzin` (enum) | bazodanowe |  | Określa sposób uwzględniania czasu pracy w podstawie nadgodzin |
| Postojowe | `Soneta.Kalend.TypPostojowego` (enum) | bazodanowe |  |  |
| Praca | `Soneta.Kalend.CzasPracy` (subrow) | bazodanowe |  |  |
| Praca.Czas | `Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Time` |  |  |  |
| Praca.OdGodziny | `Time` | bazodanowe |  |  |
| PracaZdalna | `bool` | bazodanowe |  |  |
| Przestój | `bool` | tylko-odczyt |  |  |
| Rozliczana | `bool` | bazodanowe |  |  |
| Rozliczenie | `Soneta.Kalend.TypRozliczenia` (enum) | bazodanowe |  |  |
| Typ | `Soneta.Kalend.TypStrefy` (enum) | bazodanowe |  | Informacja o sposobie wpływania na dobowy czas pracy |
| Ukryta | `bool` | bazodanowe |  | Definicja niedostępna dla operatora definiującego dzień |
| Wchodzi | `bool` | bazodanowe |  | Uwzględniania w dobowym planie pracy. Strefy z flagą praca nie mogą na siebie nachodzić i są uwzględniane podczas importu RCP |
| Wspolczynnik | `Percent` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KierunekMagazynuNadgodzin (`Soneta.Kalend.KierunekMagazynuNadgodzin`)
- `RozliczenieNadgodzin` = -1
- `NieDotyczy` = 0 — Razem
- `NadgodzinyDoRozliczenia` = 1

### TypPodstawyNadgodzin (`Soneta.Kalend.TypPodstawyNadgodzin`)
- `Domyślnie` = 0 — Domyślnie
- `NieWliczaj` = 1
- `NieNaliczaj` = 2

### TypPostojowego (`Soneta.Kalend.TypPostojowego`)
- `NieDotyczy` = 0
- `Postojowe` = 1 — Przestój (KP)
- `PrzestójEkonomiczny` = 2

### TypRozliczenia (`Soneta.Kalend.TypRozliczenia`)
- `NieDotyczy` = 0
- `WBieżącymMiesiącu` = 1 — W bieżącym miesiącu
- `WKolejnychMiesiącach` = 2 — W kolejnych miesiącach
- `ZPoprzednichMiesięcy` = 3 — Z poprzednich miesięcy
- `WypłataNadgodzin` = 4

### TypStrefy (`Soneta.Kalend.TypStrefy`)
- `NieWplywa` = 0 — Nie wpływa
- `Zwieksza` = 1 — Zwiększa
- `Zmniejsza` = 2
