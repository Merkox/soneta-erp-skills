# Pola i właściwości klasy biznesowej: `Soneta.Place.PlanowanaWypłata`
Nazwa tabeli: `PlanowaneWyplaty`
Tytuł: Planowane wypłaty
Opis: Element szczegółowy planowanej listy płac (PlanowanaListaPłac). Reprezentuje planowaną wypłatę dla konkretnego pracownika z prognozowaną kwotą do wypłaty.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `ListaPlac` → `PlanowanaListaPłac`
Implementuje interfejsy: `IZrodloOpisuAnalitycznego`

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` | bazodanowe |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Elementy | `Soneta.Business.SubTable<Soneta.Place.PlanowanyElementWypłaty>` |  |  |  |
| ListaPlac | `Soneta.Place.PlanowanaListaPłac` | bazodanowe, guided-parent |  |  |
| Lp | `int` | bazodanowe |  | Liczba porządkowa wypłaty na planownej liście płac. |
| Miesiąc | `Soneta.Types.YearMonth` |  |  |  |
| OpisAnalityczny | `Soneta.Business.SubTable` |  |  |  |
| PracHistoria | `Soneta.Kadry.PracHistoria` |  |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Wartosc | `Soneta.Types.Currency` | bazodanowe | Do wypłaty |  |
| Zatwierdzona | `bool` |  |  |  |
