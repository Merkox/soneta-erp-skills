# Pola i właściwości klasy biznesowej: `Soneta.Place.PlanowanaWypłata`
Nazwa tabeli: `PlanowaneWyplaty`
Tytuł: Planowane wypłaty
Opis: Element szczegółowy planowanej listy płac (PlanowanaListaPłac). Reprezentuje planowaną wypłatę dla konkretnego pracownika z prognozowaną kwotą do wypłaty.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `ListaPlac` → `PlanowanaListaPłac`
Implementuje interfejsy: `IZrodloOpisuAnalitycznego`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` | bazodanowe, tylko-odczyt |  |  |
| Data | `Date` | bazodanowe, tylko-odczyt |  |  |
| Elementy | `SubTable<Soneta.Place.PlanowanyElementWypłaty>` | podlista |  |  |
| ListaPlac | `Soneta.Place.PlanowanaListaPłac` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Lp | `int` | bazodanowe |  | Liczba porządkowa wypłaty na planownej liście płac. |
| Miesiąc | `YearMonth` | tylko-odczyt |  |  |
| OpisAnalityczny | `SubTable` | podlista |  |  |
| PracHistoria | `Soneta.Kadry.PracHistoria` | tylko-odczyt |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| Wartosc | `Currency` | bazodanowe | Do wypłaty |  |
| Zatwierdzona | `bool` | tylko-odczyt |  |  |
