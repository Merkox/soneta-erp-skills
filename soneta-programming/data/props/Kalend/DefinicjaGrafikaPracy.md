# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DefinicjaGrafikaPracy`
Nazwa tabeli: `DefGrafikowPracy`
Tytuł: Definicje grafików
Opis: Konfigurowalna definicja grafiku pracy. Określa zakres godzinowy dnia (od–do), definicję zakładki użytkownika oraz algorytm generowania grafiku dla harmonogramu pracy.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 10
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| DzienDo | `Soneta.Types.Time` | bazodanowe |  |  |
| DzienOd | `Soneta.Types.Time` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| Xml | `Soneta.Business.MemoText` | bazodanowe | Definicja zakładki użytkownika. |  |
