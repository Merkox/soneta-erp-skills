# Pola i właściwości klasy biznesowej: `Soneta.Kadry.DefinicjaAkordu`
Nazwa tabeli: `DefinicjeAkordow`
Tytuł: Definicje akordów
Opis: Definicja akordu określająca typ (indywidualny/grupowy), algorytm naliczania, element płacowy, jednostkę miary oraz progi wydajnościowe. Stanowi szablon akordowego systemu wynagradzania stosowany przy tworzeniu akordów pracowników.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IAkord`
Selektor: pole `Typ` (`Soneta.Kadry.TypAkordu`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Akordy | `SubTable<Soneta.Kadry.Akord>` | podlista |  |  |
| Algorytm | `Soneta.Kadry.AlgorytmAkordu` (subrow) | bazodanowe |  |  |
| Algorytm.DefinicjaStrefy | `Soneta.Kalend.DefinicjaStrefy` | bazodanowe |  |  |
| Algorytm.Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Algorytm.PomniejszaCzas | `bool` | bazodanowe |  |  |
| Algorytm.Progi | `SubTable` | podlista |  |  |
| Algorytm.Progresywny | `bool` | bazodanowe |  |  |
| Algorytm.PropDoStawki | `bool` | bazodanowe |  |  |
| Algorytm.Rozliczenie | `Soneta.Kadry.OkresRozliczeniaAkordu` (enum) | bazodanowe |  |  |
| Algorytm.Typ | `Soneta.Kadry.TypAlgorytmuAkordu` (enum) | tylko-odczyt | Typ |  |
| Algorytm.Wartosc | `DoubleCy` |  |  |  |
| Algorytm.WgCzasu | `bool` | bazodanowe |  |  |
| Algorytm.WgDefinicjaStrefy | `Key` | podlista |  |  |
| Algorytm.WgElement | `Key` | podlista |  |  |
| Algorytm.WgProgu | `bool` | bazodanowe |  |  |
| Algorytm.Wspolczynnik | `double` | bazodanowe |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| Jednostka | `string` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Progi | `SubTable<Soneta.Kadry.ProgAkordu>` | podlista |  |  |
| Typ | `Soneta.Kadry.TypAkordu` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Typ`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Prosty` | 1 | `Soneta.Kadry.DefinicjaAkorduProstego` |  |
| `Grupowy` | 2 | `Soneta.Kadry.DefinicjaAkorduGrupowego` |  |

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
