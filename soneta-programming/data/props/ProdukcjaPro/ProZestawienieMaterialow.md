# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProZestawienieMaterialow`
Nazwa tabeli: `ProZestawieniaM`
Tytuł: Zestawienia materiałów
Opis: Zestawienia materiałowe (BOM) definiujące skład surowców i komponentów potrzebnych do wytworzenia wyrobu. Służą jako wzorce struktury materiałowej wykorzystywane w technologiach i zleceniach produkcyjnych.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 6
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 2
- subrowy: 0
- razem: 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Zablokowanie zestawienia materiałów. |
| Ilosc | `double` | bazodanowe | Ilość | Ilość zestawienia materiałów. |
| Kod | `string` | bazodanowe |  | Kod zestawienia materiałów. |
| Krotnosc | `double` | bazodanowe | Krotność | Krotność zestawienia materiałów. |
| Nazwa | `string` | bazodanowe |  | Nazwa zestawienia materiałów. |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis zestawienia materiałów. |
| Pozycje | `LpSubTable<Soneta.ProdukcjaPro.ProPozycjaZestawieniaMaterialow>` | podlista |  |  |
| Wydzial | `Soneta.ProdukcjaPro.ProWydzial` | bazodanowe | Wydział | Wydział zestawienia materiałów. |
