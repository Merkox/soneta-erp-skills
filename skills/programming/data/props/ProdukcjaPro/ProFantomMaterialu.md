# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProFantomMaterialu`
Nazwa tabeli: `ProFanMaterialow`
Tytuł: Fantomy materiałów
Opis: Element szczegółowy fantomu materiału (ProRozliczenieMaterialu). Reprezentuje materiał fantomowy powiązany z rozliczeniem materiału lub fantomem wyrobu. Przechowuje informacje o towarze, ilości oraz wartości fantomu materiału wykorzystywanego w rozliczeniach produkcyjnych i kalkulacji kosztów.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `RozliczenieMaterialu` → `ProRozliczenieMaterialu`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe |  | Data fantomu materiału. |
| FantomWyrobu | `Soneta.ProdukcjaPro.ProFantomWyrobu` | bazodanowe | Fantom wyrobu | Fantom wyrobu dla fantomu materiału. |
| Ilosc | `Amount` | bazodanowe | Ilość | Ilość fantomu materiału. |
| RozliczenieMaterialu | `Soneta.ProdukcjaPro.ProRozliczenieMaterialu` | bazodanowe, guided-parent | Rozliczenie materiału | Rozliczenie materiału dla fantomu materiału. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar fantomu materiału. |
| Wartosc | `Currency` | bazodanowe | Wartość | Wartość fantomu materiału. |
