# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProWyrobOperacjiZlecenia`
Nazwa tabeli: `ProWyrobyOZ`
Tytuł: Wyroby operacji zleceń
Opis: Element szczegółowy wyrobu operacji zlecenia (ProOperacjaZlecenia). Definiuje wyrób wytwarzany w ramach konkretnej operacji zlecenia produkcyjnego. Przechowuje informacje o towarze, ilościach planowanych i zameldowanych, cenach oraz wartościach powiązanych z wyrobem.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Operacja` → `ProOperacjaZlecenia`

- pola bazodanowe: 28
- pola kalkulowane (z klas biznesowych): 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Cena | `Soneta.Types.DoubleCy` | bazodanowe |  | Cena wyrobu operacji zlecenia. |
| Ilosc | `Soneta.Types.Amount` | bazodanowe | Ilość | Ilość wyrobu operacji zlecenia. |
| IloscDoPrzyjecia | `Soneta.Types.Amount` | bazodanowe | Ilość do przyjęcia | Ilość do przyjęcia wyrobu operacji zlecenia. |
| IloscDoPrzyjeciaPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość do przyjęcia przeliczona | Ilość do przyjęcia przeliczona na podstawową jednostkę miary dla wyrobu operacji zlecenia. |
| IloscDoRealizacji | `Soneta.Types.Amount` | bazodanowe | Ilość do realizacji | Ilość do realizacji wyrobu operacji zlecenia. |
| IloscDoRealizacjiPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość do realizacji przeliczona | Ilość do realizacji przeliczona na podstawową jednostkę miary dla wyrobu operacji zlecenia. |
| IloscDoUruchomienia | `Soneta.Types.Amount` |  | Ilość do uruchomienia | Ilość zleceń powiązanych do uruchomienia. |
| IloscDoZameldowania | `Soneta.Types.Amount` | bazodanowe | Ilość do zameldowania | Ilość do zameldowania wyrobu operacji zlecenia. |
| IloscDoZameldowaniaPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość do zameldowania przeliczona | Ilość do zameldowania przeliczona na podstawową jednostkę miary dla wyrobu operacji zlecenia. |
| IloscJednostkowa | `double` | bazodanowe | Ilość jednostkowa | Ilość jednostkowa wyrobu operacji zlecenia. |
| IloscMaterialow | `Soneta.Types.Amount` |  | Ilość materiałów | Powiązana ilość materiałów dla wyrobu operacji zlecenia. |
| IloscPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość przeliczona | Ilość przeliczona na podstawową jednostkę miary dla wyrobu operacji zlecenia. |
| IloscUruchomiona | `Soneta.Types.Amount` |  | Ilość uruchomiona | Ilość uruchomiona na zleceniach powiązanych. |
| IloscZameldowana | `Soneta.Types.Amount` | bazodanowe | Ilość zameldowana | Ilość zameldowana wyrobu operacji zlecenia. |
| IloscZameldowanaPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość zameldowana przeliczona | Ilość zameldowana przeliczona na podstawową jednostkę miary dla wyrobu operacji zlecenia. |
| IloscZrealizowana | `Soneta.Types.Amount` | bazodanowe | Ilość zrealizowana | Ilość zrealizowana wyrobu operacji zlecenia. |
| IloscZrealizowanaPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość zrealizowana przeliczona | Ilość zrealizowana przeliczona na podstawową jednostkę miary dla wyrobu operacji zlecenia. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa wyrobu operacji zlecenia. |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe |  | Magazyn wyrobu operacji zlecenia. |
| Operacja | `Soneta.ProdukcjaPro.ProOperacjaZlecenia` | bazodanowe, guided-parent |  | Operacja dla wyrobu operacji zlecenia. |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis wyrobu operacji zlecenia. |
| PochodziZMeldunku | `bool` | bazodanowe | Pochodzi z meldunku | Wyrób operacji zlecenia pochodzi z wyrobu meldunku. |
| Polprodukt | `Soneta.ProdukcjaPro.ProMaterialOperacjiZlecenia` |  | Półprodukt | Pierwszy powiązany półprodukt wyrobu operacji zlecenia. |
| PominAutomatyczneZlecenie | `bool` | bazodanowe | Pomiń automatyczne zlecenie | Pomijanie w algorytmie automatycznego generowania zlecenia powiązanego dla wyrobu operacji zlecenia. |
| PozycjeZamowien | `Soneta.Business.LpSubTable<Soneta.ProdukcjaPro.ProPozycjaZamowienia>` |  |  |  |
| RelacjeMaterialWyrob | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProRelacjaMaterialWyrobOperacjiZlecenia>` |  |  |  |
| RozliczFantomowo | `bool` | bazodanowe | Rozlicz fantomowo | Rozlicz fantomowo wyrob operacji zlecenia. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar wyrobu operacji zlecenia. |
| Typ | `Soneta.ProdukcjaPro.ProTypWyrobu` | bazodanowe, enum | Typ wyrobu | Typ wyrobu operacji zlecenia. |
| Wartosc | `Soneta.Types.Currency` | bazodanowe | Wartość | Wartość wyrobu operacji zlecenia. |
| WartoscZameldowana | `Soneta.Types.Currency` | bazodanowe | Wartość zameldowana | Wartość zameldowana wyrobu operacji zlecenia. |
| WartoscZrealizowana | `Soneta.Types.Currency` | bazodanowe | Wartość zrealizowana | Wartość zrealizowana wyrobu operacji zlecenia. |
| Wspolczynnik | `double` | bazodanowe | Współczynnik | Współczynnik wyrobu operacji zlecenia. |
| WyrobOperacjiTechnologii | `Soneta.ProdukcjaPro.ProWyrobOperacjiTechnologii` | bazodanowe | Wyrób operacji technologii | Wyrób operacji technologii dla wyrobu operacji zlecenia. |
| WyrobyMeldunkow | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProWyrobMeldunku>` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ProTypWyrobu (`Soneta.ProdukcjaPro.ProTypWyrobu`)
- `None` = 0
- `Polprodukt` = 1 — Półprodukt
- `Produkt` = 2
- `All` = 3 — Wszystkie
