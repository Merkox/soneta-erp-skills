# Pola i właściwości klasy biznesowej: `Soneta.Core.Config.Windykacja`
Nazwa tabeli: `Windykacje`
Opis: Element szczegółowy należności (IRozliczalny) rejestrujący historię windykacji dokumentu. Przechowuje informacje o kolejnych etapach windykacji, w tym stan windykacji, daty, terminy, notatki oraz powiązanie ze sprawą windykacyjną i dokumentem rozliczeniowym.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dokument` → `IRozliczalny`

- pola bazodanowe: 12
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CofanieDoBufora | `bool` |  |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| DokRozlicz | `Soneta.Business.IRow` | bazodanowe | Dokument rozliczeniowy |  |
| Dokument | `Soneta.Business.IRow` | bazodanowe, guided-parent |  |  |
| Name | `string` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Node | `Soneta.Config.CfgNode` |  |  |  |
| Notatka | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| Session | `Soneta.Business.Session` |  |  | Główny obiekt sesji zawierający wszystkie inne obiekty biznesowe. |
| Sprawa | `Soneta.Business.IRow` | bazodanowe |  |  |
| Stan | `Soneta.Business.IRow` | bazodanowe |  |  |
| Termin | `Soneta.Types.Date` | bazodanowe |  |  |
| Typ | `Soneta.Kasa.TypEtapu` | bazodanowe, enum |  |  |
| Zadanie | `Soneta.Business.IRow` | bazodanowe |  |  |
| Zrodlo | `Soneta.Business.IRow` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypEtapu (`Soneta.Kasa.TypEtapu`)
- `Inne` = 0 — Inne
- `Wezwanie` = 1
- `NotaOdsetkowa` = 2
- `Wizyta` = 3
- `Sąd` = 4
- `Email` = 5
- `Sms` = 6
- `Telefon` = 7
- `Komornik` = 8
