# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProPozycjaZestawieniaMaterialow`
Nazwa tabeli: `ProPZestawienM`
Tytuł: Pozycje zestawień materiałów
Opis: Element szczegółowy zestawienia materiałów (ProZestawienieMaterialow). Opisuje pojedynczy surowiec lub komponent w zestawieniu materiałowym (BOM) z określeniem towaru, ilości, jednostki miary, magazynu, rodzaju ceny i narzutu kosztowego.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Zestawienie` → `ProZestawienieMaterialow`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Ilosc | `Amount` | bazodanowe | Ilość | Ilość pozycji zestawienia materiałów. |
| IloscJednostkowa | `double` | bazodanowe | Ilość jednostkowa | Ilość jednostkowa pozycji zestawienia materiałów. |
| IloscPrzeliczona | `Amount` | bazodanowe | Ilość przeliczona | Ilość przeliczona na podstawową jednostkę miary dla pozycji zestawienia materiałów. |
| IloscStala | `bool` | bazodanowe | Ilość stała | Ilość stała pozycji zestawienia materiałów. |
| Krotnosc | `double` | bazodanowe | Krotność | Krotność ilości stałej pozycji zestawienia materiałów. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa pozycji zestawienia materiałów. |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe |  | Magazyn pozycji zestawienia materiałów. |
| Narzut | `Percent` | bazodanowe |  | Narzut pozycji zestawienia materiałów. |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis pozycji zestawienia materiałów. |
| PominWKalkulacji | `bool` | bazodanowe | Pomiń w kalkulacji | Parametr pomijania w kalkulacji pozycji zestawienia materiałów. |
| RodzajCeny | `Soneta.ProdukcjaPro.ProRodzajCeny` (enum) | bazodanowe | Rodzaj ceny | Rodzaj ceny pozycji zestawienia materiałów. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar pozycji zestawienia materiałów. |
| Typ | `Soneta.ProdukcjaPro.ProTypMaterialu` (enum) | bazodanowe | Typ materiału | Typ materiału pozycji zestawienia materiałów. |
| Zestawienie | `Soneta.ProdukcjaPro.ProZestawienieMaterialow` | bazodanowe, guided-parent |  | Zestawienie materiałów dla pozycji zestawienia materiałów. |

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
