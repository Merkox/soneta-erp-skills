# Pola i właściwości klasy biznesowej: `Soneta.Core.ProceduraVAT`
Nazwa tabeli: `ProceduryVAT`
Tytuł: Słownik procedur VAT
Opis: Słownik procedur VAT używanych w JPK_V7M i dokumentach ewidencji. Każda procedura posiada typ, symbol, nazwę, flagę blokady oraz algorytmy (handlowy i ewidencji) określające automatyczne stosowanie procedury na dokumentach.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 12
- pola kalkulowane (z klas biznesowych): 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AlgorytmEwidencji | `Soneta.Core.AlgorytmWlWyl` | bazodanowe | Algorytm ewidencji | Algorytm ewidencji |
| AlgorytmHandlowy | `Soneta.Core.AlgorytmWlWyl` | bazodanowe | Algorytm handlowy | Algorytm handlowy |
| AlgorytmHandlowy.AktywnyAlgorytm | `Soneta.Core.AktywnyAlgorytm` | enum |  |  |
| AlgorytmHandlowy.Kod | `Soneta.Business.MemoText` | bazodanowe | Kod użytkownika |  |
| AlgorytmHandlowy.Wlaczony | `bool` | bazodanowe | Włączony |  |
| Blokada | `bool` | bazodanowe | Blokada | Procedura zablokowana |
| DefaultFileName | `string` |  |  |  |
| DefaultIdentifier | `string` |  |  |  |
| DefaultProject | `Soneta.Business.Compiler.RuntimeProject` |  |  |  |
| Documents | `System.Collections.Generic.IEnumerable<Soneta.Business.Compiler.IRuntimeDocument>` |  |  |  |
| Nazwa | `Soneta.Business.MemoText` | bazodanowe | Nazwa | Nazwa |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| SupportsCodeE | `bool` |  |  |  |
| SupportsCodeH | `bool` |  |  |  |
| Symbol | `string` | bazodanowe | Symbol | Symbol |
| Typ | `Soneta.Core.TypProceduryVAT` | bazodanowe, enum | Typ | Typ słownika |

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
