# Pola i właściwości klasy biznesowej: `Soneta.Windykacja.StanWindykacji`
Nazwa tabeli: `StanyWindykacji`
Tytuł: Definicje etapu sprawy
Opis: Słownik stanów (etapów) windykacji definiujący możliwe kroki w procesie windykacyjnym. Każdy etap określa typ rozrachunku, rodzaj źródła windykacji, czas trwania oraz opcjonalny algorytm akcji wykonywanej automatycznie przy przejściu do danego etapu.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AutomatycznePrzejscie | `bool` | bazodanowe | Przejdź do kolejnego etapu |  |
| Blokada | `bool` | bazodanowe |  |  |
| Code | `Soneta.Business.MemoText` | bazodanowe |  | Algorytm (C#) akcji |
| DefaultFileName | `string` |  |  |  |
| DefaultIdentifier | `string` |  |  |  |
| DefaultProject | `Soneta.Business.Compiler.RuntimeProject` |  |  |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  |  |
| Documents | `System.Collections.Generic.IEnumerable<Soneta.Business.Compiler.IRuntimeDocument>` |  |  |  |
| Lp | `int` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Rodzaj | `Soneta.Windykacja.RodzajŹródłaWindykacji` | bazodanowe, enum |  |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| Termin | `int` | bazodanowe | Czas trwania |  |
| Typ | `Soneta.Kasa.TypRozrachunku` | bazodanowe, enum |  |  |
| TypEtapu | `Soneta.Kasa.TypEtapu` | bazodanowe, enum |  |  |

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

### TypRozrachunku (`Soneta.Kasa.TypRozrachunku`)
- `Należność` = 10
- `Zobowiązanie` = 11
- `Wpłata` = 20
- `Wypłata` = 21

### RodzajŹródłaWindykacji (`Soneta.Windykacja.RodzajŹródłaWindykacji`)
- `Brak` = 0
- `WezwanieDoZapłaty` = 1
- `NotaOdsetkowa` = 2
