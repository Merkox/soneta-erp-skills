# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProFantomWyrobu`
Nazwa tabeli: `ProFanWyrobow`
Tytuł: Fantomy wyrobów
Opis: Element szczegółowy fantomu wyrobu (ProRozliczenieWyrobu). Reprezentuje wyrób fantomowy powiązany z rozliczeniem wyrobu. Przechowuje informacje o towarze, ilości oraz wartości fantomu wyrobu wykorzystywanego w rozliczeniach produkcyjnych i strukturach fantomowych.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `RozliczenieWyrobu` → `ProRozliczenieWyrobu`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe |  | Data fantomu wyrobu. |
| FantomyMaterialow | `SubTable<Soneta.ProdukcjaPro.ProFantomMaterialu>` | podlista |  |  |
| Ilosc | `Amount` | bazodanowe | Ilość | Ilość fantomu wyrobu. |
| IloscDoRealizacji | `Amount` | bazodanowe | Ilość do realizacji | Ilość materiałów do realizacji dla fantomu wyrobu. |
| IloscZrealizowana | `Amount` | bazodanowe | Ilość zrealizowana | Ilość materiałów zrealizowana dla fantomu wyrobu. |
| RozliczenieWyrobu | `Soneta.ProdukcjaPro.ProRozliczenieWyrobu` | bazodanowe, guided-parent | Rozliczenie wyrobu | Rozliczenie wyrobu dla fantomu wyrobu. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar fantomu wyrobu. |
| Wartosc | `Currency` | bazodanowe | Wartość | Wartość fantomu wyrobu. |
