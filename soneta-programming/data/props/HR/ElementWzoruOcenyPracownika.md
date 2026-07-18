# Pola i właściwości klasy biznesowej: `Soneta.HR.ElementWzoruOcenyPracownika`
Nazwa tabeli: `ElemWzorowOcPrac`
Tytuł: Kryteria
Opis: Element szczegółowy wzoru oceny (WzorOcenyPracownika). Wiąże konkretne kryterium z wzorem oceny, określając jakie aspekty mają być oceniane w ramach danego szablonu.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Wzor` → `WzorOcenyPracownika`

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.HR.DefElementuOcenyPracownika` | bazodanowe |  |  |
| Wzor | `Soneta.HR.WzorOcenyPracownika` | bazodanowe, tylko-odczyt, guided-parent | Wzór |  |
