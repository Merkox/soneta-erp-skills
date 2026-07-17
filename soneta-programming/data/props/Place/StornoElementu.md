# Pola i właściwości klasy biznesowej: `Soneta.Place.StornoElementu`
Nazwa tabeli: `StornaElementow`
Tytuł: Storna elementów
Opis: Element szczegółowy elementu wypłaty (WypElement). Rejestruje operację storna powiązującą element stornowany z elementem stornującym, umożliwiając korekty wcześniej naliczonych wypłat.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Stornowany` → `WypElement`

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Automatyczne | `bool` | bazodanowe |  |  |
| MiesiacZUS | `Soneta.Types.YearMonth` |  | Miesiąc ZUS |  |
| MiesiacZUSDzien | `Soneta.Types.Date` | bazodanowe | Miesiąc deklaracji ZUS | Miesiąc w którym zostaną rozliczone składki ZUS |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| RodzajStorna | `Soneta.Place.RodzajStornaElementu` | bazodanowe, enum |  |  |
| StanStorna | `Soneta.Place.StanStornaElementu` | bazodanowe, enum |  |  |
| Stornowany | `Soneta.Place.WypElement` | bazodanowe, guided-parent |  |  |
| Stornujacy | `Soneta.Place.WypElement` | bazodanowe |  |  |
| ZmianaMiesiącaPIT | `bool` |  |  |  |
| ZmianaMiesiącaZUS | `bool` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajStornaElementu (`Soneta.Place.RodzajStornaElementu`)
- `NieDotyczy` = 0 — Nie dotyczy
- `Anulowanie` = 1
- `Przeliczenie` = 2

### StanStornaElementu (`Soneta.Place.StanStornaElementu`)
- `NieDotyczy` = 0 — Nie dotyczy
- `DoStornowania` = 1
- `Wystornowany` = 2
- `Stornujący` = 3
- `WycofaneStorno` = 10
