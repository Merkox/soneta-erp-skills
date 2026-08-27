# Pola i właściwości klasy biznesowej: `Soneta.Core.SlownikElem`
Nazwa tabeli: `Slowniki`
Tytuł: Słownik
Opis: Słownik systemowy przechowujący elementy list wyboru (combo). Każdy element należy do kategorii słownikowej i może mieć kod, nazwę, wartość liczbową, flagę domyślności i blokady. Obsługuje hierarchię (elementy nadrzędne i podrzędne).
Tabela konfiguracyjna: Tak
Guided: root
Selektor: pole `Selektor` (`Soneta.Core.SelektorSlownika`) — wiele typów w jednej tabeli, podtypów: 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Blokada | Blokuje element słownika przy wyborze. |
| Domyslny | `bool` | bazodanowe | Wartość domyślna | Wartość domyślna w ramach kategorii |
| Kategoria | `string` | bazodanowe, tylko-odczyt | Nazwa słownika | Nazwa słownika, do którego należy dany element. |
| Kod | `string` | bazodanowe | Kod | Kod elementem słownika. |
| Liczba | `int` | bazodanowe | Liczba | Wartość liczbowa elementu słownika. |
| Nadrzedny | `Soneta.Core.SlownikElem` | bazodanowe |  | Określa nadrzędny obiekt słownikowy |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa elementu słownika. |
| Podrzędne | `SubTable<Soneta.Core.SlownikElem>` | podlista |  |  |
| Selektor | `Soneta.Core.SelektorSlownika` (enum) | bazodanowe, tylko-odczyt, selektor | Selektor słownika | Selektor słownika. |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Selektor`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Standard` | 1 | `Soneta.Core.SlownikElem` |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### SelektorSlownika (`Soneta.Core.SelektorSlownika`)
- `Standard` = 1
