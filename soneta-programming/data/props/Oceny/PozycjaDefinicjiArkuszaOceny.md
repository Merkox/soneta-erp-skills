# Pola i właściwości klasy biznesowej: `Soneta.Oceny.PozycjaDefinicjiArkuszaOceny`
Nazwa tabeli: `PozDefArkuszOcen`
Tytuł: Pozycje definicji arkusza oceny
Opis: Element szczegółowy definicji arkusza oceny (PozycjaDefinicjiArkuszaOceny). Przypisuje kryterium oceny do arkusza z określoną wagą, wymagalnością i opcjonalną zależnością od pytania nadrzędnego.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DefinicjaArkusza` → `DefinicjaArkuszaOceny`
Selektor: pole `TypOceny` (`Soneta.Oceny.TypOceny`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Oceny.DefinicjaElementuOceny` | bazodanowe |  |  |
| DefinicjaArkusza | `Soneta.Oceny.DefinicjaArkuszaOceny` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| DefinicjaPytaniaNadrzednego | `Soneta.Oceny.DefinicjaElementuOceny` | bazodanowe |  |  |
| Procent | `Percent` | tylko-odczyt |  |  |
| PytanieZalezne | `bool` | bazodanowe |  |  |
| TypOceny | `Soneta.Oceny.TypOceny` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| Waga | `decimal` | bazodanowe |  |  |
| WartoscPytaniaNadrzednego | `decimal` | bazodanowe |  |  |
| Wyliczana | `bool` | bazodanowe |  |  |
| Wymagana | `bool` | bazodanowe |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `TypOceny`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Ocena` | 1 | `Soneta.Oceny.PozycjaDefinicjiArkuszaOceny` |  |
| `Ankieta` | 2 | `Soneta.Ankiety.PozycjaDefinicjiArkuszaAnkiety` | Pozycja definicji arkusza ankiety |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypOceny (`Soneta.Oceny.TypOceny`)
- `Ocena` = 1
- `Ankieta` = 2
