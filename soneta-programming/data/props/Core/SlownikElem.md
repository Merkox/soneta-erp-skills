# Pola i właściwości klasy biznesowej: `Soneta.Core.SlownikElem`
Nazwa tabeli: `Slowniki`
Tytuł: Słownik
Opis: Słownik systemowy przechowujący elementy list wyboru (combo). Każdy element należy do kategorii słownikowej i może mieć kod, nazwę, wartość liczbową, flagę domyślności i blokady. Obsługuje hierarchię (elementy nadrzędne i podrzędne).
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Blokada | Blokuje element słownika przy wyborze. |
| Domyslny | `bool` | bazodanowe | Wartość domyślna | Wartość domyślna w ramach kategorii |
| Kategoria | `string` | bazodanowe | Nazwa słownika | Nazwa słownika, do którego należy dany element. |
| Kod | `string` | bazodanowe | Kod | Kod elementem słownika. |
| Liczba | `int` | bazodanowe | Liczba | Wartość liczbowa elementu słownika. |
| Nadrzedny | `Soneta.Core.SlownikElem` | bazodanowe |  | Określa nadrzędny obiekt słownikowy |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa elementu słownika. |
| Podrzędne | `Soneta.Business.SubTable<Soneta.Core.SlownikElem>` |  |  |  |
| Selektor | `Soneta.Core.SelektorSlownika` | bazodanowe, enum | Selektor słownika | Selektor słownika. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### SelektorSlownika (`Soneta.Core.SelektorSlownika`)
- `Standard` = 1
