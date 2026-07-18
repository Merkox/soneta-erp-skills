# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProWyrobOperacjiZlecenia`
Nazwa tabeli: `ProWyrobyOZ`
Tytuł: Wyroby operacji zleceń
Opis: Element szczegółowy wyrobu operacji zlecenia (ProOperacjaZlecenia). Definiuje wyrób wytwarzany w ramach konkretnej operacji zlecenia produkcyjnego. Przechowuje informacje o towarze, ilościach planowanych i zameldowanych, cenach oraz wartościach powiązanych z wyrobem.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Operacja` → `ProOperacjaZlecenia`

- pola bazodanowe (zapisywalne): 27
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 4
- podlisty: 4
- subrowy: 0
- razem: 35

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Cena | `DoubleCy` | bazodanowe |  | Cena wyrobu operacji zlecenia. |
| Ilosc | `Amount` | bazodanowe | Ilość | Ilość wyrobu operacji zlecenia. |
| IloscDoPrzyjecia | `Amount` | bazodanowe | Ilość do przyjęcia | Ilość do przyjęcia wyrobu operacji zlecenia. |
| IloscDoPrzyjeciaPrzeliczona | `Amount` | bazodanowe | Ilość do przyjęcia przeliczona | Ilość do przyjęcia przeliczona na podstawową jednostkę miary dla wyrobu operacji zlecenia. |
| IloscDoRealizacji | `Amount` | bazodanowe | Ilość do realizacji | Ilość do realizacji wyrobu operacji zlecenia. |
| IloscDoRealizacjiPrzeliczona | `Amount` | bazodanowe | Ilość do realizacji przeliczona | Ilość do realizacji przeliczona na podstawową jednostkę miary dla wyrobu operacji zlecenia. |
| IloscDoUruchomienia | `Amount` | tylko-odczyt | Ilość do uruchomienia | Ilość zleceń powiązanych do uruchomienia. |
| IloscDoZameldowania | `Amount` | bazodanowe | Ilość do zameldowania | Ilość do zameldowania wyrobu operacji zlecenia. |
| IloscDoZameldowaniaPrzeliczona | `Amount` | bazodanowe | Ilość do zameldowania przeliczona | Ilość do zameldowania przeliczona na podstawową jednostkę miary dla wyrobu operacji zlecenia. |
| IloscJednostkowa | `double` | bazodanowe | Ilość jednostkowa | Ilość jednostkowa wyrobu operacji zlecenia. |
| IloscMaterialow | `Amount` | tylko-odczyt | Ilość materiałów | Powiązana ilość materiałów dla wyrobu operacji zlecenia. |
| IloscPrzeliczona | `Amount` | bazodanowe | Ilość przeliczona | Ilość przeliczona na podstawową jednostkę miary dla wyrobu operacji zlecenia. |
| IloscUruchomiona | `Amount` | tylko-odczyt | Ilość uruchomiona | Ilość uruchomiona na zleceniach powiązanych. |
| IloscZameldowana | `Amount` | bazodanowe | Ilość zameldowana | Ilość zameldowana wyrobu operacji zlecenia. |
| IloscZameldowanaPrzeliczona | `Amount` | bazodanowe | Ilość zameldowana przeliczona | Ilość zameldowana przeliczona na podstawową jednostkę miary dla wyrobu operacji zlecenia. |
| IloscZrealizowana | `Amount` | bazodanowe | Ilość zrealizowana | Ilość zrealizowana wyrobu operacji zlecenia. |
| IloscZrealizowanaPrzeliczona | `Amount` | bazodanowe | Ilość zrealizowana przeliczona | Ilość zrealizowana przeliczona na podstawową jednostkę miary dla wyrobu operacji zlecenia. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa wyrobu operacji zlecenia. |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe |  | Magazyn wyrobu operacji zlecenia. |
| Operacja | `Soneta.ProdukcjaPro.ProOperacjaZlecenia` | bazodanowe, guided-parent |  | Operacja dla wyrobu operacji zlecenia. |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis wyrobu operacji zlecenia. |
| PochodziZMeldunku | `bool` | bazodanowe | Pochodzi z meldunku | Wyrób operacji zlecenia pochodzi z wyrobu meldunku. |
| Polprodukt | `Soneta.ProdukcjaPro.ProMaterialOperacjiZlecenia` | tylko-odczyt | Półprodukt | Pierwszy powiązany półprodukt wyrobu operacji zlecenia. |
| PominAutomatyczneZlecenie | `bool` | bazodanowe | Pomiń automatyczne zlecenie | Pomijanie w algorytmie automatycznego generowania zlecenia powiązanego dla wyrobu operacji zlecenia. |
| PozycjeZamowien | `LpSubTable<Soneta.ProdukcjaPro.ProPozycjaZamowienia>` | podlista |  |  |
| RelacjeMaterialWyrob | `SubTable<Soneta.ProdukcjaPro.ProRelacjaMaterialWyrobOperacjiZlecenia>` | podlista |  |  |
| RozliczFantomowo | `bool` | bazodanowe | Rozlicz fantomowo | Rozlicz fantomowo wyrob operacji zlecenia. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar wyrobu operacji zlecenia. |
| Typ | `Soneta.ProdukcjaPro.ProTypWyrobu` (enum) | bazodanowe | Typ wyrobu | Typ wyrobu operacji zlecenia. |
| Wartosc | `Currency` | bazodanowe | Wartość | Wartość wyrobu operacji zlecenia. |
| WartoscZameldowana | `Currency` | bazodanowe | Wartość zameldowana | Wartość zameldowana wyrobu operacji zlecenia. |
| WartoscZrealizowana | `Currency` | bazodanowe | Wartość zrealizowana | Wartość zrealizowana wyrobu operacji zlecenia. |
| Wspolczynnik | `double` | bazodanowe | Współczynnik | Współczynnik wyrobu operacji zlecenia. |
| WyrobOperacjiTechnologii | `Soneta.ProdukcjaPro.ProWyrobOperacjiTechnologii` | bazodanowe | Wyrób operacji technologii | Wyrób operacji technologii dla wyrobu operacji zlecenia. |
| WyrobyMeldunkow | `SubTable<Soneta.ProdukcjaPro.ProWyrobMeldunku>` | podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ProTypWyrobu (`Soneta.ProdukcjaPro.ProTypWyrobu`)
- `None` = 0
- `Polprodukt` = 1 — Półprodukt
- `Produkt` = 2
- `All` = 3 — Wszystkie
