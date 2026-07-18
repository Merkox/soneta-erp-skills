# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProMaterialOperacjiTechnologii`
Nazwa tabeli: `ProMaterialyOT`
Tytuł: Materiały operacji technologii
Opis: Element szczegółowy operacji wzorcowej (IProOperacjaWzorcowa). Definiuje surowiec lub komponent wymagany w operacji technologicznej z normą ilościową, ceną, magazynem źródłowym, narzutem oraz parametrami automatycznego generowania zleceń i zapotrzebowań.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Operacja` → `IProOperacjaWzorcowa`

- pola bazodanowe (zapisywalne): 22
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 3
- podlisty: 5
- subrowy: 0
- razem: 31

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CechaDostepnosci | `FeatureDefinition` | bazodanowe | Cecha dostępności | Cecha dostępności materiału operacji technologii. |
| CechaIlosci | `FeatureDefinition` | bazodanowe | Cecha ilości | Cecha ilości materiału operacji technologii. |
| CechaTowaru | `FeatureDefinition` | bazodanowe | Cecha towaru | Cecha towaru materiału operacji technologii. |
| Cena | `DoubleCy` | bazodanowe |  | Cena materiału operacji technologii. |
| GenerujZapotrzebowanie | `bool` | bazodanowe | Generuj zapotrzebowanie | Generowanie zapotrzebowania dla materiału operacji technologii. |
| Ilosc | `Amount` | bazodanowe | Ilość | Ilość materiału operacji technologii. |
| IloscJednostkowa | `double` | bazodanowe | Ilość jednostkowa | Ilość jednostkowa materiału operacji technologii. |
| IloscPrzeliczona | `Amount` | bazodanowe | Ilość przeliczona | Ilość przeliczona na podstawową jednostkę miary dla materiału operacji technologii. |
| IloscStala | `bool` | bazodanowe | Ilość stała | Ilość stała materiału operacji technologii. |
| IloscWyrobow | `Amount` | tylko-odczyt | Ilość wyrobów | Powiązana ilość wyrobów dla materiału operacji tecnologii. |
| Krotnosc | `double` | bazodanowe | Krotność | Krotność ilości stałej materiału operacji technologii. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa materiału operacji technologii. |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe |  | Magazyn materiału operacji technologii. |
| MaterialyOperacjiZlecen | `SubTable<Soneta.ProdukcjaPro.ProMaterialOperacjiZlecenia>` | podlista |  |  |
| Narzut | `Percent` | bazodanowe |  | Narzut materiału operacji technologii. |
| Odpady | `SubTable<Soneta.ProdukcjaPro.ProOdpadOperacjiTechnologii>` | podlista |  |  |
| Operacja | `Soneta.ProdukcjaPro.IProOperacjaWzorcowa` | bazodanowe, guided-parent |  | Operacja dla materiału operacji technologii. |
| OperacjaTechnologii | `Soneta.ProdukcjaPro.ProOperacjaTechnologii` | tylko-odczyt | Operacja technologii | Operacja technologii dla materiału operacji technologii. |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis materiału operacji technologii. |
| Polprodukt | `Soneta.ProdukcjaPro.ProWyrobOperacjiTechnologii` | tylko-odczyt | Półprodukt | Pierwszy powiązany półprodukt materiału operacji technologii. |
| PominAutomatyczneZlecenie | `bool` | bazodanowe | Pomiń automatyczne zlecenie | Pomijanie w algorytmie automatycznego generowania zlecenia powiązanego dla materiału operacji technologii. |
| PominWKalkulacji | `bool` | bazodanowe | Pomiń w kalkulacji | Pomijanie w kalkulacji materiału operacji technologii. |
| PozycjaZestawieniaMaterialow | `Soneta.ProdukcjaPro.ProPozycjaZestawieniaMaterialow` | bazodanowe | Pozycja zestawienia | Pozycja zestawienia materiałów dla materiału operacji technologii. |
| RelacjeMaterialWyrob | `LpSubTable<Soneta.ProdukcjaPro.ProRelacjaMaterialWyrobOperacjiTechnologii>` | podlista |  |  |
| RodzajCeny | `Soneta.ProdukcjaPro.ProRodzajCeny` (enum) | bazodanowe | Rodzaj ceny | Rodzaj ceny materiału operacji technologii. |
| RozliczFantomowo | `bool` | bazodanowe | Rozlicz fantomowo | Rozlicz fantomowo materiał operacji technologii. |
| TechnologiaMaterialu | `Soneta.ProdukcjaPro.ProTechnologia` |  | Technologia materiału | Powiązana technologia materiału. |
| TechnologieMaterialu | `LpSubTable<Soneta.ProdukcjaPro.ProTechnologiaMaterialuOperacjiTechnologii>` | podlista |  |  |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar materiału operacji technologii. |
| Typ | `Soneta.ProdukcjaPro.ProTypMaterialu` (enum) | bazodanowe | Typ materiału | Typ materiału operacji technologii. |
| Wartosc | `Currency` | bazodanowe | Wartość | Wartość materiału operacji technologii. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ProRodzajCeny (`Soneta.ProdukcjaPro.ProRodzajCeny`)
- `None` = 0
- `OstatniaCenaPrzyjecia` = 1 — Ostatnia cena przyjęcia
- `CenaTechnologiczna` = 2 — Cena technologiczna
- `CenaWyrobu` = 4 — Cena wyrobu (z operacji poprzedzającej)
- `CenaMaterialu` = 8 — Cena materiału
- `CenaStala` = 16 — Cena stała
- `CenaReczna` = 32 — Cena podana ręcznie
- `All` = 63 — Wszystkie

### ProTypMaterialu (`Soneta.ProdukcjaPro.ProTypMaterialu`)
- `None` = 0
- `Surowiec` = 1
- `Prefabrykat` = 2
- `Polprodukt` = 4 — Półprodukt (z operacji poprzedzającej)
- `All` = 7 — Wszystkie
