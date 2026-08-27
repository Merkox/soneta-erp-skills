# Pola i właściwości klasy biznesowej: `Soneta.Core.ProceduraSME`
Nazwa tabeli: `ProcedurySME`
Tytuł: Procedury SME
Opis: Element szczegółowy kraju SME (KrajSME). Historyczna wersja procedury SME z okresem obowiązywania, flagą aktywności i progiem obrotu obowiązującym w danym okresie.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Kraj` → `KrajSME`
Historia: Tak — zapis historyczny tabeli `KrajSME`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `FromTo` | bazodanowe, podlista | Okres obowiązywania |  |
| Aktywna | `bool` | bazodanowe | Aktywna procedura SME |  |
| Kraj | `Soneta.Core.KrajSME` | bazodanowe, tylko-odczyt, guided-parent |  | Kraj SME |
| Parent | `Row` | tylko-odczyt |  |  |
| ProgObrotu | `Currency` | bazodanowe | Próg obrotu |  |
