# Pola i właściwości klasy biznesowej: `Soneta.Kadry.DefinicjaAkordu`
Nazwa tabeli: `DefinicjeAkordow`
Tytuł: Definicje akordów
Opis: Definicja akordu określająca typ (indywidualny/grupowy), algorytm naliczania, element płacowy, jednostkę miary oraz progi wydajnościowe. Stanowi szablon akordowego systemu wynagradzania stosowany przy tworzeniu akordów pracowników.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IAkord`

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Akordy | `Soneta.Business.SubTable<Soneta.Kadry.Akord>` |  |  |  |
| Algorytm | `Soneta.Kadry.AlgorytmAkordu` | bazodanowe |  |  |
| Algorytm.DefinicjaStrefy | `Soneta.Kalend.DefinicjaStrefy` | bazodanowe |  |  |
| Algorytm.Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Algorytm.PomniejszaCzas | `bool` | bazodanowe |  |  |
| Algorytm.Progi | `Soneta.Business.SubTable` |  |  |  |
| Algorytm.Progresywny | `bool` | bazodanowe |  |  |
| Algorytm.PropDoStawki | `bool` | bazodanowe |  |  |
| Algorytm.Rozliczenie | `Soneta.Kadry.OkresRozliczeniaAkordu` | bazodanowe, enum |  |  |
| Algorytm.Typ | `Soneta.Kadry.TypAlgorytmuAkordu` | enum | Typ |  |
| Algorytm.Wartosc | `Soneta.Types.DoubleCy` |  |  |  |
| Algorytm.WgCzasu | `bool` | bazodanowe |  |  |
| Algorytm.WgDefinicjaStrefy | `Soneta.Business.Key` |  |  |  |
| Algorytm.WgElement | `Soneta.Business.Key` |  |  |  |
| Algorytm.WgProgu | `bool` | bazodanowe |  |  |
| Algorytm.Wspolczynnik | `double` | bazodanowe |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| Jednostka | `string` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Progi | `Soneta.Business.SubTable<Soneta.Kadry.ProgAkordu>` |  |  |  |
| Typ | `Soneta.Kadry.TypAkordu` | bazodanowe, enum |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### OkresRozliczeniaAkordu (`Soneta.Kadry.OkresRozliczeniaAkordu`)
- `Dziennie` = 0
- `Tygodniowo` = 1
- `Miesiecznie` = 2 — Miesięcznie

### TypAkordu (`Soneta.Kadry.TypAkordu`)
- `Prosty` = 1
- `Grupowy` = 2

### TypAlgorytmuAkordu (`Soneta.Kadry.TypAlgorytmuAkordu`)
- `Prosty` = 1
- `Grupowy` = 2
- `Progresywny` = 3
