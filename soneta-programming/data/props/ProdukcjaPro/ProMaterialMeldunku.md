# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProMaterialMeldunku`
Nazwa tabeli: `ProMaterialyM`
Tytuł: Materiały meldunków
Opis: Element szczegółowy materiału meldunku (ProMeldunek). Opisuje materiał zużyty w ramach meldunku produkcyjnego z informacjami o towarze, typie, magazynie oraz ilościach planowanych i rzeczywistych. Umożliwia porównanie planowanego i faktycznego zużycia materiałów wraz z ich wyceną.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Meldunek` → `ProMeldunek`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CenaPlanowana | `DoubleCy` | bazodanowe | Cena planowana | Cena planowana materiału meldunku. |
| Dostawy | `LpSubTable<Soneta.ProdukcjaPro.ProDostawaMaterialuMeldunku>` | podlista |  |  |
| Ilosc | `Amount` | bazodanowe | Ilość | Ilość materiału meldunku. |
| IloscDoRealizacji | `Amount` | bazodanowe | Ilość do realizacji | Ilość do realizacji materiału meldunku. |
| IloscDoRealizacjiPrzeliczona | `Amount` | bazodanowe | Ilość do realizacji przeliczona | Ilość do realizacji przeliczona na podstawową jednostkę miary dla materiału meldunku. |
| IloscJednostkowa | `double` | bazodanowe | Ilość jednostkowa | Ilość jednostkowa materiału meldunku. |
| IloscJednostkowaPlanowana | `double` | bazodanowe | Ilość jednostkowa planowana | Ilość jednostkowa planowana materiału meldunku. |
| IloscPlanowana | `Amount` | bazodanowe | Ilość planowana | Ilość planowana materiału meldunku. |
| IloscPlanowanaPrzeliczona | `Amount` | bazodanowe | Ilość planowana przeliczona | Ilość planowana przeliczona na podstawową jednostkę miary dla materiału meldunku. |
| IloscPrzeliczona | `Amount` | bazodanowe | Ilość przeliczona | Ilość przeliczona na podstawową jednostkę miary dla materiału meldunku. |
| IloscStala | `bool` | bazodanowe | Ilość stała | Ilość stała materiału meldunku. |
| IloscStalaPlanowana | `bool` | bazodanowe | Ilość stała planowana | Ilość stała planowana materiału meldunku. |
| IloscZrealizowana | `Amount` | bazodanowe | Ilość zrealizowana | Ilość zrealizowana materiału meldunku. |
| IloscZrealizowanaPrzeliczona | `Amount` | bazodanowe | Ilość zrealizowana przeliczona | Ilość zrealizowana przeliczona na podstawową jednostkę miary dla materiału meldunku. |
| Krotnosc | `double` | bazodanowe | Krotność | Krotność ilości stałej materiału meldunku. |
| KrotnoscPlanowana | `double` | bazodanowe | Krotność planowana | Krotność ilości stałej planowanej materiału meldunku. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa materiału meldunku. |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe |  | Magazyn materiału meldunku. |
| MaterialOperacjiZlecenia | `Soneta.ProdukcjaPro.ProMaterialOperacjiZlecenia` | bazodanowe | Materiał operacji zlecenia | Materiał operacji zlecenia dla materiału meldunku. |
| Meldunek | `Soneta.ProdukcjaPro.ProMeldunek` | bazodanowe, guided-parent |  | Meldunek dla materiału meldunku. |
| NarzutPlanowany | `Percent` | bazodanowe | Narzut planowany | Narzut planowany materiału meldunku |
| Odpady | `SubTable<Soneta.ProdukcjaPro.ProOdpadMeldunku>` | podlista |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis materiału meldunku. |
| PominWKalkulacji | `bool` | bazodanowe | Pomiń w kalkulacji | Pomijanie w kalkulacji materiału meldunku. |
| RozliczFantomowo | `bool` | tylko-odczyt | Rozlicz fantomowo | Rozlicz fantomowo materiał meldunku. |
| Rozliczenia | `SubTable<Soneta.ProdukcjaPro.ProRozliczenieMaterialu>` | podlista |  |  |
| RozliczenieIlosciowe | `Soneta.ProdukcjaPro.ProRozliczenieIlosciowe` (enum) | tylko-odczyt | Rozliczenie ilościowe | Rozliczenie ilościowe materiału meldunku. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar materiału meldunku. |
| Typ | `Soneta.ProdukcjaPro.ProTypMaterialu` (enum) | bazodanowe | Typ materiału | Typ materiału meldunku. |
| Wartosc | `Currency` | bazodanowe | Wartość | Wartość materiału meldunku. |
| WartoscPlanowana | `Currency` | bazodanowe | Wartość planowana | Wartość planowana materiału meldunku. |
| WartoscZrealizowana | `Currency` | bazodanowe | Wartość zrealizowana | Wartość zrealizowana materiału meldunku. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ProRozliczenieIlosciowe (`Soneta.ProdukcjaPro.ProRozliczenieIlosciowe`)
- `None` = 0
- `Brak` = 1
- `Czesciowe` = 2 — Częściowe
- `Pelne` = 4 — Pełne
- `Nadmiarowe` = 8
- `All` = 15 — Wszystkie

### ProTypMaterialu (`Soneta.ProdukcjaPro.ProTypMaterialu`)
- `None` = 0
- `Surowiec` = 1
- `Prefabrykat` = 2
- `Polprodukt` = 4 — Półprodukt (z operacji poprzedzającej)
- `All` = 7 — Wszystkie
