# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProOperacjaZleceniaPoprzedzajaca`
Nazwa tabeli: `ProOperacjeZlecP`
Tytuł: Operacje zleceń poprzedzające
Opis: Element szczegółowy operacji zlecenia (ProOperacjaZlecenia). Definiuje zależność kolejnościową między operacjami zlecenia, wskazując operację poprzedzającą wraz z procentowym przesunięciem startu i możliwością nakładkowania, wykorzystywaną przy harmonogramowaniu produkcji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Operacja` → `ProOperacjaZlecenia`

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| IloscPoprzedzajaca | `Soneta.Types.Amount` |  | Ilość poprzedzająca | Ilość poprzedzająca dla operacji zlecenia poprzedzającej. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa operacji zlecenia poprzedzającej. |
| Nakladkowanie | `bool` | bazodanowe | Nakładkowanie | Nakładkowanie operacji zlecenia poprzedzającej. |
| Operacja | `Soneta.ProdukcjaPro.ProOperacjaZlecenia` | bazodanowe, guided-parent |  | Operacja dla operacji zlecenia poprzedzającej. |
| OperacjaPoprzedzajaca | `Soneta.ProdukcjaPro.ProOperacjaZlecenia` | bazodanowe | Operacja poprzedzająca | Operacja poprzedzająca dla operacji zlecenia. |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis operacji zlecenia poprzedzającej. |
| Przesuniecie | `Soneta.Types.Percent` | bazodanowe | Przesunięcie | Procentowe przesunięcie operacji dla operacji zlecenia poprzedzającej. |
| RelacjeMaterialWyrob | `System.Collections.Generic.List<Soneta.ProdukcjaPro.ProRelacjaMaterialWyrobOperacjiZlecenia>` |  | Relacje materiał wyrób | Relacje materiał wyrób dla operacji zlecenia poprzedzającej. |
