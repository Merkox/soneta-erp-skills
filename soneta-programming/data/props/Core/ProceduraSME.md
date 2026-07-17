# Pola i właściwości klasy biznesowej: `Soneta.Core.ProceduraSME`
Nazwa tabeli: `ProcedurySME`
Tytuł: Procedury SME
Opis: Element szczegółowy kraju SME (KrajSME). Historyczna wersja procedury SME z okresem obowiązywania, flagą aktywności i progiem obrotu obowiązującym w danym okresie.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Kraj` → `KrajSME`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `Soneta.Types.FromTo` | bazodanowe | Okres obowiązywania |  |
| Aktywna | `bool` | bazodanowe | Aktywna procedura SME |  |
| Kraj | `Soneta.Core.KrajSME` | bazodanowe, guided-parent |  | Kraj SME |
| Parent | `Soneta.Business.Row` |  |  |  |
| ProgObrotu | `Soneta.Types.Currency` | bazodanowe | Próg obrotu |  |
