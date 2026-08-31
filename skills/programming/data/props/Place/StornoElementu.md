# Pola i właściwości klasy biznesowej: `Soneta.Place.StornoElementu`
Nazwa tabeli: `StornaElementow`
Tytuł: Storna elementów
Opis: Element szczegółowy elementu wypłaty (WypElement). Rejestruje operację storna powiązującą element stornowany z elementem stornującym, umożliwiając korekty wcześniej naliczonych wypłat.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Stornowany` → `WypElement`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Automatyczne | `bool` | bazodanowe, tylko-odczyt |  |  |
| MiesiacZUS | `YearMonth` | tylko-odczyt | Miesiąc ZUS |  |
| MiesiacZUSDzien | `Date` | bazodanowe, tylko-odczyt | Miesiąc deklaracji ZUS | Miesiąc w którym zostaną rozliczone składki ZUS |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| RodzajStorna | `Soneta.Place.RodzajStornaElementu` (enum) | bazodanowe, tylko-odczyt |  |  |
| StanStorna | `Soneta.Place.StanStornaElementu` (enum) | bazodanowe, tylko-odczyt |  |  |
| Stornowany | `Soneta.Place.WypElement` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Stornujacy | `Soneta.Place.WypElement` | bazodanowe, tylko-odczyt |  |  |
| ZmianaMiesiącaPIT | `bool` | tylko-odczyt |  |  |
| ZmianaMiesiącaZUS | `bool` | tylko-odczyt |  |  |

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
