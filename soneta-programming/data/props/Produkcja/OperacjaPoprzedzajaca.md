# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.OperacjaPoprzedzajaca`
Nazwa tabeli: `OperacjePoprzed`
Tytuł: Operacje poprzedzające, od których zależy możliwość wykonanania operacji
Opis: Relacja zależności między operacjami produkcyjnymi definiująca kolejność wykonywania. Wskazuje operację poprzedzającą, której zakończenie warunkuje rozpoczęcie operacji następującej, wraz z maksymalnym dopuszczalnym opóźnieniem. Służy do budowania grafu zależności i planowania harmonogramu produkcji.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| MaxOpoznienie | `Amount` | bazodanowe | Opóźnienie | Maksymalny czas opóźnienia. |
| Operacja | `Soneta.Produkcja.Operacja` | bazodanowe |  | Operacja następująca. |
| Poprzedzajaca | `Soneta.Produkcja.Operacja` | bazodanowe | Poprzedzająca | Operacja poprzedzająca. |
