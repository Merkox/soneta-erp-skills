# Pola i właściwości klasy biznesowej: `Soneta.Oceny.ArkuszDefinicjiOceny`
Nazwa tabeli: `ArkuszeDefOcen`
Tytuł: Arkusze definicji oceny
Opis: Element szczegółowy definicji oceny (ArkuszDefinicjiOceny). Przypisuje wzorzec arkusza do definicji oceny z wymaganą liczbą wypełnień, umożliwiając składanie oceny z wielu arkuszy (np. samoocena + ocena przełożonego).
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DefinicjaOceny` → `DefinicjaOceny`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaArkusza | `Soneta.Oceny.DefinicjaArkuszaOceny` | bazodanowe |  |  |
| DefinicjaOceny | `Soneta.Oceny.DefinicjaOceny` | bazodanowe, guided-parent |  |  |
| TypOceny | `Soneta.Oceny.TypOceny` | bazodanowe, enum |  |  |
| WymaganaLiczba | `int` | bazodanowe | Wymagana liczba |  |
| Wymagany | `bool` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypOceny (`Soneta.Oceny.TypOceny`)
- `Ocena` = 1
- `Ankieta` = 2
