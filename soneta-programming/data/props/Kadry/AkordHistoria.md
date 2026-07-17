# Pola i właściwości klasy biznesowej: `Soneta.Kadry.AkordHistoria`
Nazwa tabeli: `AkordHistorie`
Tytuł: Historia akordu
Opis: Element szczegółowy akordu (Akord). Wersja historyczna akordu pracownika rejestrująca zmiany okresu obowiązywania, jednostki miary i algorytmu naliczania w kolejnych okresach aktualności.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Akord` → `Akord`
Implementuje interfejsy: `IAkord`

- pola bazodanowe: 15
- pola kalkulowane (z klas biznesowych): 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Akord | `Soneta.Kadry.Akord` | bazodanowe, guided-parent |  |  |
| Aktualnosc | `Soneta.Types.FromTo` | bazodanowe |  |  |
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
| Definicja | `Soneta.Kadry.DefinicjaAkordu` |  |  |  |
| EfektywnyOkres | `Soneta.Types.FromTo` |  |  |  |
| Jednostka | `string` | bazodanowe |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| OkresZatrudnienia | `Soneta.Types.FromTo` |  |  |  |
| Parent | `Soneta.Business.Row` |  |  |  |
| Progi | `Soneta.Business.SubTable<Soneta.Kadry.ProgAkordu>` |  |  |  |
| Typ | `Soneta.Kadry.TypAkordu` | bazodanowe, enum |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` |  |  |  |

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
