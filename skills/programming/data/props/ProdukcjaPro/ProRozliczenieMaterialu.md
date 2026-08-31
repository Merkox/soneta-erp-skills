# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProRozliczenieMaterialu`
Nazwa tabeli: `ProRozMaterialow`
Tytuł: Rozliczenia materiałów
Opis: Element szczegółowy rozliczenia materiału (ProOperacjaZlecenia). Powiązuje materiał meldunku z pozycją dokumentu handlowego w celu rozliczenia zużycia. Przechowuje informacje o towarze, ilości, ilości przeliczonej oraz wartości rozliczenia.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Operacja` → `ProOperacjaZlecenia`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DostawaMaterialu | `Soneta.ProdukcjaPro.ProDostawaMaterialuMeldunku` | bazodanowe | Dostawa materiału meldunku | Dostawa materiału meldunku dla rozliczenia materiału. |
| FantomyMaterialow | `SubTable<Soneta.ProdukcjaPro.ProFantomMaterialu>` | podlista |  |  |
| Ilosc | `Amount` | bazodanowe | Ilość | Ilość rozliczenia materiału. |
| IloscPrzeliczona | `double` | bazodanowe | Ilość przeliczona | Ilość przeliczona rozliczenia materiału. |
| MaterialMeldunku | `Soneta.ProdukcjaPro.ProMaterialMeldunku` | bazodanowe | Materiał meldunku | Materiał meldunku dla rozliczenia materiału. |
| Obroty | `System.Collections.Generic.List<Soneta.Magazyny.Obrot>` | podlista |  | Obroty rozliczenia materiału meldunku. |
| Operacja | `Soneta.ProdukcjaPro.ProOperacjaZlecenia` | bazodanowe, guided-parent | Operacja | Operacja rozliczenia materiału. |
| PozycjaDokumentuHandlowego | `Soneta.Handel.PozycjaDokHandlowego` | bazodanowe | Pozycja dokumentu handlowego | Pozycja dokumentu handlowego rozliczenia materiału. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar rozliczenia materiału. |
| Wartosc | `Currency` | bazodanowe | Wartość | Wartość rozliczenia materiału. |
