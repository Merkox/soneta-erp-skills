# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProMaterialOperacjiZlecenia`
Nazwa tabeli: `ProMaterialyOZ`
Tytuł: Materiały operacji zleceń
Opis: Element szczegółowy operacji zlecenia (ProOperacjaZlecenia). Definiuje zapotrzebowanie materiałowe operacji zlecenia z ilościami planowanymi, zameldowanymi, zrealizowanymi i do rozchodowania, ceną, narzutem oraz powiązaniem z technologią i zestawieniem materiałowym.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Operacja` → `ProOperacjaZlecenia`

- pola bazodanowe (zapisywalne): 37
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 4
- podlisty: 6
- subrowy: 0
- razem: 48

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Cena | `DoubleCy` | bazodanowe |  | Cena materiału operacji zlecenia. |
| GenerujZapotrzebowanie | `bool` | bazodanowe | Generuj zapotrzebowanie | Generowanie zapotrzebowania dla materiału operacji zlecenia. |
| Ilosc | `Amount` | bazodanowe | Ilość | Ilość materiału operacji zlecenia. |
| IloscDoRealizacji | `Amount` | bazodanowe | Ilość do realizacji | Ilość do realizacji materiału operacji zlecenia. |
| IloscDoRealizacjiPrzeliczona | `Amount` | bazodanowe | Ilość do realizacji przeliczona | Ilość do realizacji przeliczona na podstawową jednostkę miary dla materiału operacji zlecenia. |
| IloscDoRozchodowania | `Amount` | bazodanowe | Ilość do rozchodowania | Ilość do rozchodowania materiału operacji zlecenia. |
| IloscDoRozchodowaniaPrzeliczona | `Amount` | bazodanowe | Ilość do rozchodowania przeliczona | Ilość do rozchodowania przeliczona na podstawową jednostkę miary dla materiału operacji zlecenia. |
| IloscDoUruchomienia | `Amount` | tylko-odczyt | Ilość do uruchomienia | Ilość zleceń powiązanych do uruchomienia. |
| IloscDoZameldowania | `Amount` | bazodanowe | Ilość do zameldowania | Ilość do zameldowania materiału operacji zlecenia. |
| IloscDoZameldowaniaPrzeliczona | `Amount` | bazodanowe | Ilość do zameldowania przeliczona | Ilość do zameldowania przeliczona na podstawową jednostkę miary dla materiału operacji zlecenia. |
| IloscDoZaopatrzenia | `Amount` | bazodanowe | Ilość do zaopatrzenia | Ilość do zaopatrzenia materiału operacji zlecenia. |
| IloscDoZaopatrzeniaPrzeliczona | `Amount` | bazodanowe | Ilość do zaopatrzenia przeliczona | Ilość do zaopatrzenia przeliczona na podstawową jednostkę miary dla materiału operacji zlecenia. |
| IloscJednostkowa | `double` | bazodanowe | Ilość jednostkowa | Ilość jednostkowa materiału operacji zlecenia. |
| IloscPrzeliczona | `Amount` | bazodanowe | Ilość przeliczona | Ilość przeliczona na podstawową jednostkę miary dla materiału operacji zlecenia. |
| IloscStala | `bool` | bazodanowe | Ilość stała | Ilość stała materiału operacji zlecenia. |
| IloscUruchomiona | `Amount` | tylko-odczyt | Ilość uruchomiona | Ilość uruchomiona na zleceniach powiązanych. |
| IloscWyrobow | `Amount` | tylko-odczyt | Ilość wyrobów | Powiązana ilość wyrobów dla materiału operacji zlecenia. |
| IloscZameldowana | `Amount` | bazodanowe | Ilość zameldowana | Ilość zameldowana materiału operacji zlecenia. |
| IloscZameldowanaPrzeliczona | `Amount` | bazodanowe | Ilość zameldowana przeliczona | Ilość zameldowana przeliczona na podstawową jednostkę miary dla materiału operacji zlecenia. |
| IloscZapotrzebowan | `Amount` | bazodanowe | Ilość zapotrzebowań | Ilość zapotrzebowań materiału operacji zlecenia. |
| IloscZapotrzebowanPrzeliczona | `Amount` | bazodanowe | Ilość zapotrzebowań przeliczona | Ilość zapotrzebowań przeliczona na podstawową jednostkę miary dla materiału operacji zlecenia. |
| IloscZrealizowana | `Amount` | bazodanowe | Ilość zrealizowana | Ilość zrealizowana materiału operacji zlecenia. |
| IloscZrealizowanaPrzeliczona | `Amount` | bazodanowe | Ilość zrealizowana przeliczona | Ilość zrealizowana przeliczona na podstawową jednostkę miary dla materiału operacji zlecenia. |
| Krotnosc | `double` | bazodanowe | Krotność | Krotność ilości stałej materiału operacji zlecenia. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa materiału operacji zlecenia. |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe |  | Magazyn materiału operacji zlecenia. |
| MaterialOperacjiTechnologii | `Soneta.ProdukcjaPro.ProMaterialOperacjiTechnologii` | bazodanowe | Materiał operacji technologii | Materiał operacji technologii dla materiału operacji zlecenia. |
| MaterialyMeldunkow | `SubTable<Soneta.ProdukcjaPro.ProMaterialMeldunku>` | podlista |  |  |
| Narzut | `Percent` | bazodanowe |  | Narzut materiału operacji zlecenia. |
| Odpady | `SubTable<Soneta.ProdukcjaPro.ProOdpadOperacjiZlecenia>` | podlista |  |  |
| Operacja | `Soneta.ProdukcjaPro.ProOperacjaZlecenia` | bazodanowe, guided-parent |  | Operacja dla materiału operacji zlecenia. |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis materiału operacji zlecenia. |
| PochodziZMeldunku | `bool` | bazodanowe | Pochodzi z meldunku | Materiał operacji zlecenia pochodzi z materiału meldunku. |
| Polprodukt | `Soneta.ProdukcjaPro.ProWyrobOperacjiZlecenia` | tylko-odczyt | Półprodukt | Pierwszy powiązany półprodukt materiału operacji zlecenia. |
| PominAutomatyczneZlecenie | `bool` | bazodanowe | Pomiń automatyczne zlecenie | Pomijanie w algorytmie automatycznego generowania zlecenia powiązanego dla materiału operacji zlecenia. |
| PominWKalkulacji | `bool` | bazodanowe | Pomiń w kalkulacji | Pomijanie w kalkulacji materiału operacji zlecenia. |
| PozycjaZestawieniaMaterialow | `Soneta.ProdukcjaPro.ProPozycjaZestawieniaMaterialow` | bazodanowe | Pozycja zestawienia | Pozycja zestawienia materiałów dla materiału operacji zlecenia. |
| RelacjeMaterialWyrob | `LpSubTable<Soneta.ProdukcjaPro.ProRelacjaMaterialWyrobOperacjiZlecenia>` | podlista |  |  |
| RodzajCeny | `Soneta.ProdukcjaPro.ProRodzajCeny` (enum) | bazodanowe | Rodzaj ceny | Rodzaj ceny materiału operacji zlecenia. |
| RozliczFantomowo | `bool` | bazodanowe | Rozlicz fantomowo | Rozlicz fantomowo materiał operacji zlecenia. |
| RozliczeniaZapotrzebowan | `LpSubTable<Soneta.ProdukcjaPro.ProRozliczenieZapotrzebowania>` | podlista |  |  |
| TechnologiaMaterialu | `Soneta.ProdukcjaPro.ProTechnologia` |  | Technologia materiału | Powiązana technologia materiału. |
| TechnologieMaterialu | `LpSubTable<Soneta.ProdukcjaPro.ProTechnologiaMaterialuOperacjiZlecenia>` | podlista |  |  |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar materiału operacji zlecenia. |
| Typ | `Soneta.ProdukcjaPro.ProTypMaterialu` (enum) | bazodanowe | Typ materiału | Typ materiału operacji zlecenia. |
| Wartosc | `Currency` | bazodanowe | Wartość | Wartość materiału operacji zlecenia. |
| WartoscZameldowana | `Currency` | bazodanowe | Wartość zameldowana | Wartość zameldowana materiału operacji zlecenia. |
| WartoscZrealizowana | `Currency` | bazodanowe | Wartość zrealizowana | Wartość zrealizowana materiału operacji zlecenia. |

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
