# Pola i właściwości klasy biznesowej: `Soneta.Core.ProceduraVAT`
Nazwa tabeli: `ProceduryVAT`
Tytuł: Słownik procedur VAT
Opis: Słownik procedur VAT używanych w JPK_V7M i dokumentach ewidencji. Każda procedura posiada typ, symbol, nazwę, flagę blokady oraz algorytmy (handlowy i ewidencji) określające automatyczne stosowanie procedury na dokumentach.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 6
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 7
- podlisty: 4
- subrowy: 3
- razem: 20

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AlgorytmEwidencji | `Soneta.Core.AlgorytmWlWyl` (subrow) | bazodanowe | Algorytm ewidencji | Algorytm ewidencji |
| AlgorytmHandlowy | `Soneta.Core.AlgorytmWlWyl` (subrow) | bazodanowe | Algorytm handlowy | Algorytm handlowy |
| AlgorytmHandlowy.AktywnyAlgorytm | `Soneta.Core.AktywnyAlgorytm` (enum) | tylko-odczyt |  |  |
| AlgorytmHandlowy.Kod | `MemoText` | bazodanowe, podlista | Kod użytkownika |  |
| AlgorytmHandlowy.Wlaczony | `bool` | bazodanowe | Włączony |  |
| Blokada | `bool` | bazodanowe | Blokada | Procedura zablokowana |
| DefaultFileName | `string` | tylko-odczyt |  |  |
| DefaultIdentifier | `string` | tylko-odczyt |  |  |
| DefaultProject | `Compiler.RuntimeProject` | tylko-odczyt |  |  |
| Documents | `System.Collections.Generic.IEnumerable<Compiler.IRuntimeDocument>` | podlista |  |  |
| Nazwa | `MemoText` | bazodanowe, podlista | Nazwa | Nazwa |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| SupportsCodeE | `bool` | tylko-odczyt |  |  |
| SupportsCodeH | `bool` | tylko-odczyt |  |  |
| Symbol | `string` | bazodanowe | Symbol | Symbol |
| Typ | `Soneta.Core.TypProceduryVAT` (enum) | bazodanowe, tylko-odczyt | Typ | Typ słownika |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AktywnyAlgorytm (`Soneta.Core.AktywnyAlgorytm`)
- `None` = 0 — Brak
- `CompiledIn` = 1 — Standardowy
- `User` = 2 — Użytkownika

### TypProceduryVAT (`Soneta.Core.TypProceduryVAT`)
- `Brak` = 0
- `GrupaTowarowaVAT` = 1 — Grupa towarowa VAT
- `TypDokumentuSprzedazVAT` = 2 — Typ dokumentu sprzedaży VAT
- `TypDokumentuZakupVAT` = 3 — Typ dokumentu zakupu VAT
- `ProceduraSprzedazVAT` = 4 — Procedura sprzedaży VAT
- `ProceduraZakupVAT` = 5 — Procedura zakupu VAT
