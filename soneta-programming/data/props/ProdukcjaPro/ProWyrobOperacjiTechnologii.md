# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProWyrobOperacjiTechnologii`
Nazwa tabeli: `ProWyrobyOT`
Tytuł: Wyroby operacji technologii
Opis: Element szczegółowy operacji wzorcowej (IProOperacjaWzorcowa). Definiuje wyrób lub półprodukt powstający w wyniku operacji technologicznej z normą ilościową, typem wyrobu, magazynem docelowym, współczynnikiem uzysku, ceną i parametrami automatycznego generowania zleceń.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Operacja` → `IProOperacjaWzorcowa`

- pola bazodanowe (zapisywalne): 13
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 3
- podlisty: 3
- subrowy: 0
- razem: 19

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Cena | `DoubleCy` | bazodanowe |  | Cena wyrobu operacji technologii. |
| Ilosc | `Amount` | bazodanowe | Ilość | Ilość wyrobu operacji technologii. |
| IloscJednostkowa | `double` | bazodanowe | Ilość jednostkowa | Ilość jednostkowa wyrobu operacji technologii. |
| IloscMaterialow | `Amount` | tylko-odczyt | Ilość materiałów | Powiązana ilość materiałów dla wyrobu operacji technologii. |
| IloscPrzeliczona | `Amount` | bazodanowe | Ilość przeliczona | Ilość przeliczona na podstawową jednostkę miary dla wyrobu operacji technologii. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa wyrobu operacji technologii. |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe |  | Magazyn wyrobu operacji technologii. |
| Operacja | `Soneta.ProdukcjaPro.IProOperacjaWzorcowa` | bazodanowe, guided-parent |  | Operacja dla wyrobu operacji technologii. |
| OperacjaTechnologii | `Soneta.ProdukcjaPro.ProOperacjaTechnologii` | tylko-odczyt | Operacja technologii | Operacja technologii dla wyrobu operacji technologii. |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis wyrobu operacji technologii. |
| Polprodukt | `Soneta.ProdukcjaPro.ProMaterialOperacjiTechnologii` | tylko-odczyt | Półprodukt | Pierwszy powiązany półprodukt wyrobu operacji technologii. |
| PominAutomatyczneZlecenie | `bool` | bazodanowe | Pomiń automatyczne zlecenie | Pomijanie w algorytmie automatycznego generowania zlecenia powiązanego dla wyrobu operacji technologii. |
| RelacjeMaterialWyrob | `SubTable<Soneta.ProdukcjaPro.ProRelacjaMaterialWyrobOperacjiTechnologii>` | podlista |  |  |
| RozliczFantomowo | `bool` | bazodanowe | Rozlicz fantomowo | Rozlicz fantomowo wyrob operacji technologii. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar wyrobu operacji technologii. |
| Typ | `Soneta.ProdukcjaPro.ProTypWyrobu` (enum) | bazodanowe | Typ wyrobu | Typ wyrobu operacji technologii. |
| Wartosc | `Currency` | bazodanowe | Wartość | Wartość wyrobu operacji technologii. |
| Wspolczynnik | `double` | bazodanowe | Współczynnik | Współczynnik wyrobu operacji technologii. |
| WyrobyOperacjiZlecen | `SubTable<Soneta.ProdukcjaPro.ProWyrobOperacjiZlecenia>` | podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ProTypWyrobu (`Soneta.ProdukcjaPro.ProTypWyrobu`)
- `None` = 0
- `Polprodukt` = 1 — Półprodukt
- `Produkt` = 2
- `All` = 3 — Wszystkie
