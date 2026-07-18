# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DefinicjaGrafikaPracy`
Nazwa tabeli: `DefGrafikowPracy`
Tytuł: Definicje grafików
Opis: Konfigurowalna definicja grafiku pracy. Określa zakres godzinowy dnia (od–do), definicję zakładki użytkownika oraz algorytm generowania grafiku dla harmonogramu pracy.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 7
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 3
- subrowy: 1
- razem: 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `MemoText` | bazodanowe, podlista |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| DzienDo | `Time` | bazodanowe |  |  |
| DzienOd | `Time` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| Xml | `MemoText` | bazodanowe, podlista | Definicja zakładki użytkownika. |  |
