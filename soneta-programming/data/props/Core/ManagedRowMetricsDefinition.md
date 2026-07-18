# Pola i właściwości klasy biznesowej: `Soneta.Core.ManagedRowMetricsDefinition`
Nazwa tabeli: `ManRowMetricDefs`
Tytuł: Definicje zapisów w metryce dokumentu
Opis: Definicja wzorca wpisu w metryce (historii zmian) dokumentu. Określa nazwę wpisu, treść szablonową i flagę blokady. Metryki dokumentują przebieg przetwarzania dokumentu w procesie workflow.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Tresc | `string` | bazodanowe | Treść | Treść wpisu |
