# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProOperacjaZleceniaPoprzedzajaca`
Nazwa tabeli: `ProOperacjeZlecP`
Tytuł: Operacje zleceń poprzedzające
Opis: Element szczegółowy operacji zlecenia (ProOperacjaZlecenia). Definiuje zależność kolejnościową między operacjami zlecenia, wskazując operację poprzedzającą wraz z procentowym przesunięciem startu i możliwością nakładkowania, wykorzystywaną przy harmonogramowaniu produkcji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Operacja` → `ProOperacjaZlecenia`

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 2
- subrowy: 0
- razem: 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| IloscPoprzedzajaca | `Amount` | tylko-odczyt | Ilość poprzedzająca | Ilość poprzedzająca dla operacji zlecenia poprzedzającej. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa operacji zlecenia poprzedzającej. |
| Nakladkowanie | `bool` | bazodanowe | Nakładkowanie | Nakładkowanie operacji zlecenia poprzedzającej. |
| Operacja | `Soneta.ProdukcjaPro.ProOperacjaZlecenia` | bazodanowe, guided-parent |  | Operacja dla operacji zlecenia poprzedzającej. |
| OperacjaPoprzedzajaca | `Soneta.ProdukcjaPro.ProOperacjaZlecenia` | bazodanowe | Operacja poprzedzająca | Operacja poprzedzająca dla operacji zlecenia. |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis operacji zlecenia poprzedzającej. |
| Przesuniecie | `Percent` | bazodanowe | Przesunięcie | Procentowe przesunięcie operacji dla operacji zlecenia poprzedzającej. |
| RelacjeMaterialWyrob | `System.Collections.Generic.List<Soneta.ProdukcjaPro.ProRelacjaMaterialWyrobOperacjiZlecenia>` | podlista | Relacje materiał wyrób | Relacje materiał wyrób dla operacji zlecenia poprzedzającej. |
