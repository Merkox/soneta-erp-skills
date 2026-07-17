# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DefinicjaWeryfikatoraRozliczeniaCzasuPracy`
Nazwa tabeli: `DefWerRozCzas`
Tytuł: Definicje weryfikatorów dla dokumentów rozliczenia czasu pracy
Opis: Konfigurowalna definicja weryfikatora dokumentu rozliczenia czasu pracy. Określa nazwę, priorytet, opis reguły oraz kod algorytmu sprawdzającego poprawność dokumentów rozliczenia nadgodzin.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `Soneta.Kalend.DefinicjaWeryfikatoraRozliczeniaCzasuPracy.AlgorytmBase` |  |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| ClassName | `string` |  |  |  |
| Code | `Soneta.Business.MemoText` | bazodanowe |  |  |
| DefinicjeRozliczenia | `Soneta.Business.SubTable<Soneta.Kalend.WeryfikatorRozliczeniaCzasuPracy>` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
