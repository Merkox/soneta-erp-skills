# Pola i właściwości klasy biznesowej: `Soneta.Core.Config.Windykacja`
Nazwa tabeli: `Windykacje`
Opis: Element szczegółowy należności (IRozliczalny) rejestrujący historię windykacji dokumentu. Przechowuje informacje o kolejnych etapach windykacji, w tym stan windykacji, daty, terminy, notatki oraz powiązanie ze sprawą windykacyjną i dokumentem rozliczeniowym.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dokument` → `IRozliczalny`

- pola bazodanowe (zapisywalne): 11
- pola kalkulowane (zapisywalne): 2
- pola tylko-odczyt: 2
- podlisty: 1
- subrowy: 0
- razem: 16

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CofanieDoBufora | `bool` |  |  |  |
| Data | `Date` | bazodanowe |  |  |
| DokRozlicz | `IRow` | bazodanowe | Dokument rozliczeniowy |  |
| Dokument | `IRow` | bazodanowe, guided-parent |  |  |
| Name | `string` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Node | `Soneta.Config.CfgNode` | tylko-odczyt |  |  |
| Notatka | `MemoText` | bazodanowe, podlista |  |  |
| Opis | `string` | bazodanowe |  |  |
| Session | `Session` | tylko-odczyt |  | Główny obiekt sesji zawierający wszystkie inne obiekty biznesowe. |
| Sprawa | `IRow` | bazodanowe |  |  |
| Stan | `IRow` | bazodanowe |  |  |
| Termin | `Date` | bazodanowe |  |  |
| Typ | `Soneta.Kasa.TypEtapu` (enum) | bazodanowe |  |  |
| Zadanie | `IRow` | bazodanowe |  |  |
| Zrodlo | `IRow` | bazodanowe |  |  |

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
