# Pola i właściwości klasy biznesowej: `Soneta.Oceny.ArkuszDefinicjiOceny`
Nazwa tabeli: `ArkuszeDefOcen`
Tytuł: Arkusze definicji oceny
Opis: Element szczegółowy definicji oceny (ArkuszDefinicjiOceny). Przypisuje wzorzec arkusza do definicji oceny z wymaganą liczbą wypełnień, umożliwiając składanie oceny z wielu arkuszy (np. samoocena + ocena przełożonego).
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DefinicjaOceny` → `DefinicjaOceny`
Selektor: pole `TypOceny` (`Soneta.Oceny.TypOceny`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaArkusza | `Soneta.Oceny.DefinicjaArkuszaOceny` | bazodanowe |  |  |
| DefinicjaOceny | `Soneta.Oceny.DefinicjaOceny` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| TypOceny | `Soneta.Oceny.TypOceny` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| WymaganaLiczba | `int` | bazodanowe | Wymagana liczba |  |
| Wymagany | `bool` |  |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `TypOceny`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Ocena` | 1 | `Soneta.Oceny.ArkuszDefinicjiOceny` |  |
| `Ankieta` | 2 | `Soneta.Ankiety.ArkuszDefinicjiAnkiety` |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypOceny (`Soneta.Oceny.TypOceny`)
- `Ocena` = 1
- `Ankieta` = 2
