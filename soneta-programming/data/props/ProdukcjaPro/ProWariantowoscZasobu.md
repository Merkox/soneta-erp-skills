# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProWariantowoscZasobu`
Nazwa tabeli: `ProWarZasobow`
Tytuł: Wariantowość zasobów produkcyjnych
Opis: Element szczegółowy zasobu produkcyjnego (ProZasob). Definiuje warianty czasów i stawek zasobu zależne od wytwarzanego towaru lub wykonywanej operacji, umożliwiając zróżnicowanie norm czasowych i kosztowych dla różnych kontekstów produkcyjnych.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Zasob` → `ProZasob`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CzasTj | `TimeSec` | bazodanowe | Czas tj | Czas jednostkowy wariantowości zasobu. |
| CzasTpz | `TimeSec` | bazodanowe | Czas tpz | Czas przygotowawczo-zakończeniowy wariantowości zasobu. |
| DefinicjaOperacji | `Soneta.ProdukcjaPro.ProDefinicjaOperacji` | bazodanowe | Definicja operacji | Definicja operacji wariantowości zasobu. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa wariantowości zasobu. |
| Stawka | `Soneta.ProdukcjaPro.ProStawka` | bazodanowe |  | Stawka wariantowości zasobu. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar wariantowości zasobu. |
| Zasob | `Soneta.ProdukcjaPro.ProZasob` | bazodanowe, guided-parent | Zasób | Zasób wariantowości zasobu. |
