# Pola i właściwości klasy biznesowej: `Soneta.HR.WartośćElementuOcenyPracownika`
Nazwa tabeli: `WartElemOcenPrac`
Tytuł: Wartości elementu oceny
Opis: Element szczegółowy definicji kryterium oceny (DefElementuOcenyPracownika). Przechowuje dopuszczalne wartości liczbowe i opisowe dla danego kryterium, tworząc skalę ocen.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Definicja` → `DefElementuOcenyPracownika`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.HR.DefElementuOcenyPracownika` | bazodanowe, guided-parent |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Wartosc | `decimal` | bazodanowe | Wartość |  |
