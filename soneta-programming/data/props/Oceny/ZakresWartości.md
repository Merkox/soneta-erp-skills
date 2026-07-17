# Pola i właściwości klasy biznesowej: `Soneta.Oceny.ZakresWartości`
Nazwa tabeli: `ZakresyWartosci`
Tytuł: Zakresy wartości
Opis: Definicja zakresu liczbowego dopuszczalnych wartości oceny. Określa przedział wartości od-do (całkowite lub dziesiętne) dla danego typu oceny, zapewniając walidację wprowadzanych wyników.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Calkowite | `bool` | bazodanowe |  |  |
| Indywidualny | `bool` | bazodanowe | Szablon indywidualny |  |
| Info | `string` |  |  |  |
| Max | `decimal` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| TypOceny | `Soneta.Oceny.TypOceny` | bazodanowe, enum |  |  |
| WartoscDo | `decimal` | bazodanowe | Wartość do |  |
| WartoscDoInt | `int` |  | Wartość do |  |
| WartoscOd | `decimal` | bazodanowe | Wartość od |  |
| WartoscOdInt | `int` |  | Wartość od |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypOceny (`Soneta.Oceny.TypOceny`)
- `Ocena` = 1
- `Ankieta` = 2
