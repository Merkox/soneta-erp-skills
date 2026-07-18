# Pola i właściwości klasy biznesowej: `Soneta.HR.WartośćElementuOcenyPracownika`
Nazwa tabeli: `WartElemOcenPrac`
Tytuł: Wartości elementu oceny
Opis: Element szczegółowy definicji kryterium oceny (DefElementuOcenyPracownika). Przechowuje dopuszczalne wartości liczbowe i opisowe dla danego kryterium, tworząc skalę ocen.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Definicja` → `DefElementuOcenyPracownika`

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.HR.DefElementuOcenyPracownika` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Wartosc | `decimal` | bazodanowe | Wartość |  |
