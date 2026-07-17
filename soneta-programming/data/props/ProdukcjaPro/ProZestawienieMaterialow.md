# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProZestawienieMaterialow`
Nazwa tabeli: `ProZestawieniaM`
Tytuł: Zestawienia materiałów
Opis: Zestawienia materiałowe (BOM) definiujące skład surowców i komponentów potrzebnych do wytworzenia wyrobu. Służą jako wzorce struktury materiałowej wykorzystywane w technologiach i zleceniach produkcyjnych.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Zablokowanie zestawienia materiałów. |
| Ilosc | `double` | bazodanowe | Ilość | Ilość zestawienia materiałów. |
| Kod | `string` | bazodanowe |  | Kod zestawienia materiałów. |
| Krotnosc | `double` | bazodanowe | Krotność | Krotność zestawienia materiałów. |
| Nazwa | `string` | bazodanowe |  | Nazwa zestawienia materiałów. |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis zestawienia materiałów. |
| Pozycje | `Soneta.Business.LpSubTable<Soneta.ProdukcjaPro.ProPozycjaZestawieniaMaterialow>` |  |  |  |
| Wydzial | `Soneta.ProdukcjaPro.ProWydzial` | bazodanowe | Wydział | Wydział zestawienia materiałów. |
