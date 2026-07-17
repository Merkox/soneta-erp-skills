# Pola i właściwości klasy biznesowej: `Soneta.BI.SerializationParam`
Nazwa tabeli: `SerializeParams`
Tytuł: Parametry utrwalania danych biznesowych
Opis: Parametry procesu utrwalania danych BI dla konkretnej tabeli serializacji. Przechowuje datę ostatniego utrwalenia, umożliwiając śledzenie aktualności zapisanych danych analitycznych i planowanie kolejnych cykli odświeżania.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Date | `System.DateTime` | bazodanowe | Data utrwalenia |  |
| SerializationTable | `System.Guid` | bazodanowe |  |  |
