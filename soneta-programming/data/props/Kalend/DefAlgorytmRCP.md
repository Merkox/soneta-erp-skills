# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DefAlgorytmRCP`
Nazwa tabeli: `DefAlgorytmyRCP`
Tytuł: Definicje algorytmów RCP
Opis: Konfigurowalna definicja algorytmu przetwarzania danych z czytnika RCP. Określa priorytet, kod algorytmu, klasę bazową i interfejsy implementowane przez logikę przetwarzającą dane wejść/wyjść pracowników.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 10
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| Interfejsy | `string` | bazodanowe | Interfejsy | Interfejsy jakie implementuje klasa tupla (z namespace) oddzielone przecinkiem |
| KlasaBazowa | `string` | bazodanowe | Klasa bazowa | Klasa bazowa po której dziedziczy klasa tupla (z namespace), która musi dziedziczyć po DbTuple |
| Nazwa | `string` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
