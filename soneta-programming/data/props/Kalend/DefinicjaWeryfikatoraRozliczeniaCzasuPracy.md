# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DefinicjaWeryfikatoraRozliczeniaCzasuPracy`
Nazwa tabeli: `DefWerRozCzas`
Tytuł: Definicje weryfikatorów dla dokumentów rozliczenia czasu pracy
Opis: Konfigurowalna definicja weryfikatora dokumentu rozliczenia czasu pracy. Określa nazwę, priorytet, opis reguły oraz kod algorytmu sprawdzającego poprawność dokumentów rozliczenia nadgodzin.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 6
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 4
- subrowy: 1
- razem: 13

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `Soneta.Kalend.DefinicjaWeryfikatoraRozliczeniaCzasuPracy.AlgorytmBase` | tylko-odczyt |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| ClassName | `string` | tylko-odczyt |  |  |
| Code | `MemoText` | bazodanowe, podlista |  |  |
| DefinicjeRozliczenia | `SubTable<Soneta.Kalend.WeryfikatorRozliczeniaCzasuPracy>` | podlista |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
