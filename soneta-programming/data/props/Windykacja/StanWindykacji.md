# Pola i właściwości klasy biznesowej: `Soneta.Windykacja.StanWindykacji`
Nazwa tabeli: `StanyWindykacji`
Tytuł: Definicje etapu sprawy
Opis: Słownik stanów (etapów) windykacji definiujący możliwe kroki w procesie windykacyjnym. Każdy etap określa typ rozrachunku, rodzaj źródła windykacji, czas trwania oraz opcjonalny algorytm akcji wykonywanej automatycznie przy przejściu do danego etapu.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 11
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 4
- podlisty: 3
- subrowy: 1
- razem: 19

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AutomatycznePrzejscie | `bool` | bazodanowe | Przejdź do kolejnego etapu |  |
| Blokada | `bool` | bazodanowe |  |  |
| Code | `MemoText` | bazodanowe, podlista |  | Algorytm (C#) akcji |
| DefaultFileName | `string` | tylko-odczyt |  |  |
| DefaultIdentifier | `string` | tylko-odczyt |  |  |
| DefaultProject | `Compiler.RuntimeProject` | tylko-odczyt |  |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  |  |
| Documents | `System.Collections.Generic.IEnumerable<Compiler.IRuntimeDocument>` | podlista |  |  |
| Lp | `int` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Rodzaj | `Soneta.Windykacja.RodzajŹródłaWindykacji` (enum) | bazodanowe |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| Termin | `int` | bazodanowe | Czas trwania |  |
| Typ | `Soneta.Kasa.TypRozrachunku` (enum) | bazodanowe, tylko-odczyt |  |  |
| TypEtapu | `Soneta.Kasa.TypEtapu` (enum) | bazodanowe |  |  |

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
