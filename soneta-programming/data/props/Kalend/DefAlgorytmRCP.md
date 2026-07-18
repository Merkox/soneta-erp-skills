# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DefAlgorytmRCP`
Nazwa tabeli: `DefAlgorytmyRCP`
Tytuł: Definicje algorytmów RCP
Opis: Konfigurowalna definicja algorytmu przetwarzania danych z czytnika RCP. Określa priorytet, kod algorytmu, klasę bazową i interfejsy implementowane przez logikę przetwarzającą dane wejść/wyjść pracowników.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 8
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 2
- subrowy: 1
- razem: 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `MemoText` | bazodanowe, podlista |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| Interfejsy | `string` | bazodanowe | Interfejsy | Interfejsy jakie implementuje klasa tupla (z namespace) oddzielone przecinkiem |
| KlasaBazowa | `string` | bazodanowe | Klasa bazowa | Klasa bazowa po której dziedziczy klasa tupla (z namespace), która musi dziedziczyć po DbTuple |
| Nazwa | `string` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
