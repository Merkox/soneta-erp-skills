# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProMaterialMeldunku`
Nazwa tabeli: `ProMaterialyM`
Tytuł: Materiały meldunków
Opis: Element szczegółowy materiału meldunku (ProMeldunek). Opisuje materiał zużyty w ramach meldunku produkcyjnego z informacjami o towarze, typie, magazynie oraz ilościach planowanych i rzeczywistych. Umożliwia porównanie planowanego i faktycznego zużycia materiałów wraz z ich wyceną.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Meldunek` → `ProMeldunek`

- pola bazodanowe: 27
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CenaPlanowana | `Soneta.Types.DoubleCy` | bazodanowe | Cena planowana | Cena planowana materiału meldunku. |
| Dostawy | `Soneta.Business.LpSubTable<Soneta.ProdukcjaPro.ProDostawaMaterialuMeldunku>` |  |  |  |
| Ilosc | `Soneta.Types.Amount` | bazodanowe | Ilość | Ilość materiału meldunku. |
| IloscDoRealizacji | `Soneta.Types.Amount` | bazodanowe | Ilość do realizacji | Ilość do realizacji materiału meldunku. |
| IloscDoRealizacjiPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość do realizacji przeliczona | Ilość do realizacji przeliczona na podstawową jednostkę miary dla materiału meldunku. |
| IloscJednostkowa | `double` | bazodanowe | Ilość jednostkowa | Ilość jednostkowa materiału meldunku. |
| IloscJednostkowaPlanowana | `double` | bazodanowe | Ilość jednostkowa planowana | Ilość jednostkowa planowana materiału meldunku. |
| IloscPlanowana | `Soneta.Types.Amount` | bazodanowe | Ilość planowana | Ilość planowana materiału meldunku. |
| IloscPlanowanaPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość planowana przeliczona | Ilość planowana przeliczona na podstawową jednostkę miary dla materiału meldunku. |
| IloscPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość przeliczona | Ilość przeliczona na podstawową jednostkę miary dla materiału meldunku. |
| IloscStala | `bool` | bazodanowe | Ilość stała | Ilość stała materiału meldunku. |
| IloscStalaPlanowana | `bool` | bazodanowe | Ilość stała planowana | Ilość stała planowana materiału meldunku. |
| IloscZrealizowana | `Soneta.Types.Amount` | bazodanowe | Ilość zrealizowana | Ilość zrealizowana materiału meldunku. |
| IloscZrealizowanaPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość zrealizowana przeliczona | Ilość zrealizowana przeliczona na podstawową jednostkę miary dla materiału meldunku. |
| Krotnosc | `double` | bazodanowe | Krotność | Krotność ilości stałej materiału meldunku. |
| KrotnoscPlanowana | `double` | bazodanowe | Krotność planowana | Krotność ilości stałej planowanej materiału meldunku. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa materiału meldunku. |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe |  | Magazyn materiału meldunku. |
| MaterialOperacjiZlecenia | `Soneta.ProdukcjaPro.ProMaterialOperacjiZlecenia` | bazodanowe | Materiał operacji zlecenia | Materiał operacji zlecenia dla materiału meldunku. |
| Meldunek | `Soneta.ProdukcjaPro.ProMeldunek` | bazodanowe, guided-parent |  | Meldunek dla materiału meldunku. |
| NarzutPlanowany | `Soneta.Types.Percent` | bazodanowe | Narzut planowany | Narzut planowany materiału meldunku |
| Odpady | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProOdpadMeldunku>` |  |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis materiału meldunku. |
| PominWKalkulacji | `bool` | bazodanowe | Pomiń w kalkulacji | Pomijanie w kalkulacji materiału meldunku. |
| RozliczFantomowo | `bool` |  | Rozlicz fantomowo | Rozlicz fantomowo materiał meldunku. |
| Rozliczenia | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProRozliczenieMaterialu>` |  |  |  |
| RozliczenieIlosciowe | `Soneta.ProdukcjaPro.ProRozliczenieIlosciowe` | enum | Rozliczenie ilościowe | Rozliczenie ilościowe materiału meldunku. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar materiału meldunku. |
| Typ | `Soneta.ProdukcjaPro.ProTypMaterialu` | bazodanowe, enum | Typ materiału | Typ materiału meldunku. |
| Wartosc | `Soneta.Types.Currency` | bazodanowe | Wartość | Wartość materiału meldunku. |
| WartoscPlanowana | `Soneta.Types.Currency` | bazodanowe | Wartość planowana | Wartość planowana materiału meldunku. |
| WartoscZrealizowana | `Soneta.Types.Currency` | bazodanowe | Wartość zrealizowana | Wartość zrealizowana materiału meldunku. |

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
