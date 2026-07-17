# Pola i właściwości klasy biznesowej: `Soneta.Towary.ElementKompletu`
Nazwa tabeli: `ElemKompletow`
Tytuł: Elementy kompletów
Opis: Element szczegółowy towaru-kompletu (Towar). Definiuje składnik lub produkt wchodzący w skład kompletu produkcyjnego, określając towar, ilość, typ (składnik/produkt), magazyn oraz wartość. Umożliwia kompletację i dekompletację towarów złożonych z rozdzieleniem wartości proporcjonalnie na produkty.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Ilosc | `Soneta.Towary.Quantity` | bazodanowe | Ilość | Ilość elementu kompletu. |
| Komplet | `Soneta.Towary.Towar` | bazodanowe |  | Towar będący kompletem zawierającym składnik. |
| Lp | `int` | bazodanowe |  |  |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe |  | Magazyn, na którym znajduje się składnik bądź będzie dostarczony produkt. |
| ProporcjaWartosci | `bool` | bazodanowe | Proporcja wartości | Wskazuje że wartość składników ma być rozdzielona proporcjonalnie na produkty. |
| StanMagazynu | `Soneta.Magazyny.StanMagazynuWorker` |  |  |  |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar będący składnikiem lub produktem kompletu. |
| Typ | `Soneta.Towary.TypElementuKompletu` | bazodanowe, enum |  | Określa, czy element jest składnikiem, czy produktem. |
| Wartosc | `Soneta.Types.Currency` | bazodanowe | Wartość | Wartość elementu kompletu. |
| WartoscWCZakupu | `Soneta.Types.Currency` | bazodanowe | Wartość w c. zakupu | Wartość elementu kompletu w cenie zakupu. |
| Wartości | `Soneta.Towary.ElementKompletu.WartośćList` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypElementuKompletu (`Soneta.Towary.TypElementuKompletu`)
- `Składnik` = 1
- `Produkt` = 2
