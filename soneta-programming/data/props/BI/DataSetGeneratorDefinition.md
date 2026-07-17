# Pola i właściwości klasy biznesowej: `Soneta.BI.DataSetGeneratorDefinition`
Nazwa tabeli: `DataSetGenDefs`
Tytuł: Definicja generatora danych biznesowych
Opis: Element szczegółowy definicji zestawu danych (DataSetDefinition). Definiuje nazwany generator odpowiedzialny za wypełnianie zestawu danych poprzez wykonanie algorytmu (kodu). Jeden zestaw danych może mieć wiele generatorów realizujących różne etapy przetwarzania.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Code | `Soneta.Business.MemoText` | bazodanowe |  |  |
| DataSet | `Soneta.BI.DataSetDefinition` | bazodanowe | Definicja zestawu danych |  |
| DatabasesCode | `string` |  | Nazwy baz danych | Kod definiujący nazwy baz danych |
| GenerateCode | `string` |  | Kod algorytmu metody Generate | Kod algorytmu generowania rekordów |
| Info | `string` |  |  |  |
| Name | `string` | bazodanowe | Nazwa |  |
| ParamCode | `string` |  | Kod paremetrów generatora | Kod parametrów generowania rekordów |
