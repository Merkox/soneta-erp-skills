# Pola i właściwości klasy biznesowej: `Soneta.BI.SerializationParam`
Nazwa tabeli: `SerializeParams`
Tytuł: Parametry utrwalania danych biznesowych
Opis: Parametry procesu utrwalania danych BI dla konkretnej tabeli serializacji. Przechowuje datę ostatniego utrwalenia, umożliwiając śledzenie aktualności zapisanych danych analitycznych i planowanie kolejnych cykli odświeżania.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Date | `System.DateTime` | bazodanowe | Data utrwalenia |  |
| SerializationTable | `System.Guid` | bazodanowe, tylko-odczyt |  |  |
