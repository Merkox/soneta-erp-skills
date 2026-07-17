# Pola i właściwości klasy biznesowej: `Soneta.HR.ElementWzoruOcenyPracownika`
Nazwa tabeli: `ElemWzorowOcPrac`
Tytuł: Kryteria
Opis: Element szczegółowy wzoru oceny (WzorOcenyPracownika). Wiąże konkretne kryterium z wzorem oceny, określając jakie aspekty mają być oceniane w ramach danego szablonu.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Wzor` → `WzorOcenyPracownika`

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.HR.DefElementuOcenyPracownika` | bazodanowe |  |  |
| Wzor | `Soneta.HR.WzorOcenyPracownika` | bazodanowe, guided-parent | Wzór |  |
