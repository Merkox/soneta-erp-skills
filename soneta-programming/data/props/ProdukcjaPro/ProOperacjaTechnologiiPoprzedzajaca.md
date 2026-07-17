# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProOperacjaTechnologiiPoprzedzajaca`
Nazwa tabeli: `ProOperacjeTechP`
Tytuł: Operacje technologii poprzedzające
Opis: Element szczegółowy operacji technologii (ProOperacjaTechnologii). Definiuje zależność kolejnościową między operacjami w marszrucie, wskazując operację poprzedzającą wraz z procentowym przesunięciem startu i możliwością nakładkowania operacji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Operacja` → `ProOperacjaTechnologii`

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| IloscPoprzedzajaca | `Soneta.Types.Amount` |  | Ilość poprzedzająca | Ilość poprzedzająca dla operacji technologii poprzedzającej. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa operacji technologii poprzedzającej. |
| Nakladkowanie | `bool` | bazodanowe | Nakładkowanie | Nakładkowanie operacji technologii poprzedzającej. |
| Operacja | `Soneta.ProdukcjaPro.ProOperacjaTechnologii` | bazodanowe, guided-parent |  | Operacja dla operacji technologii poprzedzającej. |
| OperacjaPoprzedzajaca | `Soneta.ProdukcjaPro.ProOperacjaTechnologii` | bazodanowe | Operacja poprzedzająca | Operacja poprzedzająca dla operacji technologii. |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis operacji technologii poprzedzającej. |
| Przesuniecie | `Soneta.Types.Percent` | bazodanowe | Przesunięcie | Procentowe przesunięcie operacji dla operacji technologii poprzedzającej. |
| RelacjeMaterialWyrob | `System.Collections.Generic.List<Soneta.ProdukcjaPro.ProRelacjaMaterialWyrobOperacjiTechnologii>` |  | Relacje materiał wyrób | Relacje materiał wyrób dla operacji technologii poprzedzającej. |
