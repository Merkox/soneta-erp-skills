# Pola i właściwości klasy biznesowej: `Soneta.Kadry.AkordHistoria`
Nazwa tabeli: `AkordHistorie`
Tytuł: Historia akordu
Opis: Element szczegółowy akordu (Akord). Wersja historyczna akordu pracownika rejestrująca zmiany okresu obowiązywania, jednostki miary i algorytmu naliczania w kolejnych okresach aktualności.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Akord` → `Akord`
Historia: Tak — zapis historyczny tabeli `Akord`
Implementuje interfejsy: `IAkord`
Selektor: pole `Typ` (`Soneta.Kadry.TypAkordu`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Akord | `Soneta.Kadry.Akord` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Aktualnosc | `FromTo` | bazodanowe, podlista |  |  |
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
| Definicja | `Soneta.Kadry.DefinicjaAkordu` |  |  |  |
| EfektywnyOkres | `FromTo` | podlista |  |  |
| Jednostka | `string` | bazodanowe |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| OkresZatrudnienia | `FromTo` | podlista |  |  |
| Parent | `Row` | tylko-odczyt |  |  |
| Progi | `SubTable<Soneta.Kadry.ProgAkordu>` | podlista |  |  |
| Typ | `Soneta.Kadry.TypAkordu` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` |  |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Typ`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Prosty` | 1 | `Soneta.Kadry.AkordProstyHistoria` | Akord |
| `Grupowy` | 2 | `Soneta.Kadry.AkordGrupowyHistoria` | Akord grupowy |

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
