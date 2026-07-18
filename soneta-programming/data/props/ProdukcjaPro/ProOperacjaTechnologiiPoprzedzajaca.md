# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProOperacjaTechnologiiPoprzedzajaca`
Nazwa tabeli: `ProOperacjeTechP`
Tytuł: Operacje technologii poprzedzające
Opis: Element szczegółowy operacji technologii (ProOperacjaTechnologii). Definiuje zależność kolejnościową między operacjami w marszrucie, wskazując operację poprzedzającą wraz z procentowym przesunięciem startu i możliwością nakładkowania operacji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Operacja` → `ProOperacjaTechnologii`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| IloscPoprzedzajaca | `Amount` | tylko-odczyt | Ilość poprzedzająca | Ilość poprzedzająca dla operacji technologii poprzedzającej. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa operacji technologii poprzedzającej. |
| Nakladkowanie | `bool` | bazodanowe | Nakładkowanie | Nakładkowanie operacji technologii poprzedzającej. |
| Operacja | `Soneta.ProdukcjaPro.ProOperacjaTechnologii` | bazodanowe, guided-parent |  | Operacja dla operacji technologii poprzedzającej. |
| OperacjaPoprzedzajaca | `Soneta.ProdukcjaPro.ProOperacjaTechnologii` | bazodanowe | Operacja poprzedzająca | Operacja poprzedzająca dla operacji technologii. |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis operacji technologii poprzedzającej. |
| Przesuniecie | `Percent` | bazodanowe | Przesunięcie | Procentowe przesunięcie operacji dla operacji technologii poprzedzającej. |
| RelacjeMaterialWyrob | `System.Collections.Generic.List<Soneta.ProdukcjaPro.ProRelacjaMaterialWyrobOperacjiTechnologii>` | podlista | Relacje materiał wyrób | Relacje materiał wyrób dla operacji technologii poprzedzającej. |
