# Pola i właściwości klasy biznesowej: `Soneta.Delegacje.KwotaNaliczeniaDelegacji`
Nazwa tabeli: `KwotaNalDeleg`
Tytuł: Kwoty naliczenia delegacji
Opis: Element szczegółowy NaliczenieDelegacji (NaliczenieDelegacji). Przechowuje kwotę naliczenia delegacji w konkretnej walucie obcej wraz z kursem przeliczeniowym. Umożliwia rozliczenie delegacji wielowalutowych oraz decyzję o generowaniu płatności bezpośrednio w walucie systemowej.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Naliczenie` → `NaliczenieDelegacji`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Kurs | `double` | bazodanowe |  | Kurs do przeliczenia kwoty w walucie |
| Kwota | `Soneta.Types.Currency` | bazodanowe |  | Kwota naliczenia delegacji w walucie |
| KwotaDoRozliczenia | `Soneta.Types.Currency` |  |  |  |
| Naliczenie | `Soneta.Delegacje.NaliczenieDelegacji` | bazodanowe, guided-parent |  | Kwota w walucie do naliczenia delegacji. |
| RozliczPln | `bool` | bazodanowe |  | Czy płatności mają być od razu generowane w walucie systemowej. |
| SymbolWaluty | `string` | bazodanowe |  | Waluta naliczenia delegacji |
