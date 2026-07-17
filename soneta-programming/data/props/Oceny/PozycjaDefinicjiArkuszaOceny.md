# Pola i właściwości klasy biznesowej: `Soneta.Oceny.PozycjaDefinicjiArkuszaOceny`
Nazwa tabeli: `PozDefArkuszOcen`
Tytuł: Pozycje definicji arkusza oceny
Opis: Element szczegółowy definicji arkusza oceny (PozycjaDefinicjiArkuszaOceny). Przypisuje kryterium oceny do arkusza z określoną wagą, wymagalnością i opcjonalną zależnością od pytania nadrzędnego.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DefinicjaArkusza` → `DefinicjaArkuszaOceny`

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Oceny.DefinicjaElementuOceny` | bazodanowe |  |  |
| DefinicjaArkusza | `Soneta.Oceny.DefinicjaArkuszaOceny` | bazodanowe, guided-parent |  |  |
| DefinicjaPytaniaNadrzednego | `Soneta.Oceny.DefinicjaElementuOceny` | bazodanowe |  |  |
| Procent | `Soneta.Types.Percent` |  |  |  |
| PytanieZalezne | `bool` | bazodanowe |  |  |
| TypOceny | `Soneta.Oceny.TypOceny` | bazodanowe, enum |  |  |
| Waga | `decimal` | bazodanowe |  |  |
| WartoscPytaniaNadrzednego | `decimal` | bazodanowe |  |  |
| Wyliczana | `bool` | bazodanowe |  |  |
| Wymagana | `bool` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypOceny (`Soneta.Oceny.TypOceny`)
- `Ocena` = 1
- `Ankieta` = 2
