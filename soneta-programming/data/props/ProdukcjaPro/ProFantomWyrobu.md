# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProFantomWyrobu`
Nazwa tabeli: `ProFanWyrobow`
Tytuł: Fantomy wyrobów
Opis: Element szczegółowy fantomu wyrobu (ProRozliczenieWyrobu). Reprezentuje wyrób fantomowy powiązany z rozliczeniem wyrobu. Przechowuje informacje o towarze, ilości oraz wartości fantomu wyrobu wykorzystywanego w rozliczeniach produkcyjnych i strukturach fantomowych.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `RozliczenieWyrobu` → `ProRozliczenieWyrobu`

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  | Data fantomu wyrobu. |
| FantomyMaterialow | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProFantomMaterialu>` |  |  |  |
| Ilosc | `Soneta.Types.Amount` | bazodanowe | Ilość | Ilość fantomu wyrobu. |
| IloscDoRealizacji | `Soneta.Types.Amount` | bazodanowe | Ilość do realizacji | Ilość materiałów do realizacji dla fantomu wyrobu. |
| IloscZrealizowana | `Soneta.Types.Amount` | bazodanowe | Ilość zrealizowana | Ilość materiałów zrealizowana dla fantomu wyrobu. |
| RozliczenieWyrobu | `Soneta.ProdukcjaPro.ProRozliczenieWyrobu` | bazodanowe, guided-parent | Rozliczenie wyrobu | Rozliczenie wyrobu dla fantomu wyrobu. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar fantomu wyrobu. |
| Wartosc | `Soneta.Types.Currency` | bazodanowe | Wartość | Wartość fantomu wyrobu. |
