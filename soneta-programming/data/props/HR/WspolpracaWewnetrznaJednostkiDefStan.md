# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Stanowiska.Relacje.WspolpracaWewnetrznaJednostkiDefStan`
Nazwa tabeli: `WspWeJnDefSt`
Tytuł: Współpraca wewnętrzna definicji stanowisk z jednostkami organizacyjnymi
Opis: Element szczegółowy definicji stanowiska (DefinicjaStanowiska). Przypisuje jednostki organizacyjne, z którymi dane stanowisko współpracuje wewnętrznie w określonym okresie, na potrzeby analizy przepływów organizacyjnych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 1
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaStanowiska | `Soneta.HR.DefinicjaStanowiska` | bazodanowe, tylko-odczyt | Definicja stanowiska |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |
