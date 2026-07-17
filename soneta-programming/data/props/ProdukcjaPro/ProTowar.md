# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProTowar`
Nazwa tabeli: `ProTowary`
Tytuł: Towary produkcyjne
Opis: Element szczegółowy towaru (Towar). Rozszerza kartotekę towarową o parametry produkcyjne, takie jak typ materiału, typ wyrobu, cena stała oraz flaga generowania zapotrzebowań, wykorzystywane przy planowaniu i kalkulacji produkcji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Towar` → `Towar`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CenaStala | `Soneta.Types.DoubleCy` | bazodanowe | Cena stała | Cena stała towaru. |
| GenerujZapotrzebowanie | `bool` | bazodanowe | Generuj zapotrzebowanie | Generowanie zapotrzebowania dla towaru. |
| Towar | `Soneta.Towary.Towar` | bazodanowe, guided-parent |  | Towar. |
| TypMaterialu | `Soneta.ProdukcjaPro.ProTypMaterialu` | bazodanowe, enum | Typ materiału | Typ materiału dla towaru. |
| TypWyrobu | `Soneta.ProdukcjaPro.ProTypWyrobu` | bazodanowe, enum | Typ wyrobu | Typ wyrobu dla towaru. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ProTypMaterialu (`Soneta.ProdukcjaPro.ProTypMaterialu`)
- `None` = 0
- `Surowiec` = 1
- `Prefabrykat` = 2
- `Polprodukt` = 4 — Półprodukt (z operacji poprzedzającej)
- `All` = 7 — Wszystkie

### ProTypWyrobu (`Soneta.ProdukcjaPro.ProTypWyrobu`)
- `None` = 0
- `Polprodukt` = 1 — Półprodukt
- `Produkt` = 2
- `All` = 3 — Wszystkie
