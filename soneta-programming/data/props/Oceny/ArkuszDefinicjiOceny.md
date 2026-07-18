# Pola i właściwości klasy biznesowej: `Soneta.Oceny.ArkuszDefinicjiOceny`
Nazwa tabeli: `ArkuszeDefOcen`
Tytuł: Arkusze definicji oceny
Opis: Element szczegółowy definicji oceny (ArkuszDefinicjiOceny). Przypisuje wzorzec arkusza do definicji oceny z wymaganą liczbą wypełnień, umożliwiając składanie oceny z wielu arkuszy (np. samoocena + ocena przełożonego).
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DefinicjaOceny` → `DefinicjaOceny`

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaArkusza | `Soneta.Oceny.DefinicjaArkuszaOceny` | bazodanowe |  |  |
| DefinicjaOceny | `Soneta.Oceny.DefinicjaOceny` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| TypOceny | `Soneta.Oceny.TypOceny` (enum) | bazodanowe, tylko-odczyt |  |  |
| WymaganaLiczba | `int` | bazodanowe | Wymagana liczba |  |
| Wymagany | `bool` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypOceny (`Soneta.Oceny.TypOceny`)
- `Ocena` = 1
- `Ankieta` = 2
