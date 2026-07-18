# Pola i właściwości klasy biznesowej: `Soneta.Towary.ElementKompletu`
Nazwa tabeli: `ElemKompletow`
Tytuł: Elementy kompletów
Opis: Element szczegółowy towaru-kompletu (Towar). Definiuje składnik lub produkt wchodzący w skład kompletu produkcyjnego, określając towar, ilość, typ (składnik/produkt), magazyn oraz wartość. Umożliwia kompletację i dekompletację towarów złożonych z rozdzieleniem wartości proporcjonalnie na produkty.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 8
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 3
- podlisty: 0
- subrowy: 0
- razem: 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Ilosc | `Soneta.Towary.Quantity` | bazodanowe | Ilość | Ilość elementu kompletu. |
| Komplet | `Soneta.Towary.Towar` | bazodanowe, tylko-odczyt |  | Towar będący kompletem zawierającym składnik. |
| Lp | `int` | bazodanowe |  |  |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe |  | Magazyn, na którym znajduje się składnik bądź będzie dostarczony produkt. |
| ProporcjaWartosci | `bool` | bazodanowe | Proporcja wartości | Wskazuje że wartość składników ma być rozdzielona proporcjonalnie na produkty. |
| StanMagazynu | `Soneta.Magazyny.StanMagazynuWorker` | tylko-odczyt |  |  |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar będący składnikiem lub produktem kompletu. |
| Typ | `Soneta.Towary.TypElementuKompletu` (enum) | bazodanowe |  | Określa, czy element jest składnikiem, czy produktem. |
| Wartosc | `Currency` | bazodanowe | Wartość | Wartość elementu kompletu. |
| WartoscWCZakupu | `Currency` | bazodanowe | Wartość w c. zakupu | Wartość elementu kompletu w cenie zakupu. |
| Wartości | `Soneta.Towary.ElementKompletu.WartośćList` | tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypElementuKompletu (`Soneta.Towary.TypElementuKompletu`)
- `Składnik` = 1
- `Produkt` = 2
