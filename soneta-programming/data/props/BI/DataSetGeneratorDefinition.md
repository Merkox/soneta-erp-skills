# Pola i właściwości klasy biznesowej: `Soneta.BI.DataSetGeneratorDefinition`
Nazwa tabeli: `DataSetGenDefs`
Tytuł: Definicja generatora danych biznesowych
Opis: Element szczegółowy definicji zestawu danych (DataSetDefinition). Definiuje nazwany generator odpowiedzialny za wypełnianie zestawu danych poprzez wykonanie algorytmu (kodu). Jeden zestaw danych może mieć wiele generatorów realizujących różne etapy przetwarzania.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 3
- pola tylko-odczyt: 2
- podlisty: 1
- subrowy: 0
- razem: 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Code | `MemoText` | bazodanowe, podlista |  |  |
| DataSet | `Soneta.BI.DataSetDefinition` | bazodanowe, tylko-odczyt | Definicja zestawu danych |  |
| DatabasesCode | `string` |  | Nazwy baz danych | Kod definiujący nazwy baz danych |
| GenerateCode | `string` |  | Kod algorytmu metody Generate | Kod algorytmu generowania rekordów |
| Info | `string` | tylko-odczyt |  |  |
| Name | `string` | bazodanowe | Nazwa |  |
| ParamCode | `string` |  | Kod paremetrów generatora | Kod parametrów generowania rekordów |
