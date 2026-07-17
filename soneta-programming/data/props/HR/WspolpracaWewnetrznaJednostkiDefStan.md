# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Stanowiska.Relacje.WspolpracaWewnetrznaJednostkiDefStan`
Nazwa tabeli: `WspWeJnDefSt`
Tytuł: Współpraca wewnętrzna definicji stanowisk z jednostkami organizacyjnymi
Opis: Element szczegółowy definicji stanowiska (DefinicjaStanowiska). Przypisuje jednostki organizacyjne, z którymi dane stanowisko współpracuje wewnętrznie w określonym okresie, na potrzeby analizy przepływów organizacyjnych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaStanowiska | `Soneta.HR.DefinicjaStanowiska` | bazodanowe | Definicja stanowiska |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |
