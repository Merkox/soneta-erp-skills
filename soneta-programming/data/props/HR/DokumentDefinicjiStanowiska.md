# Pola i właściwości klasy biznesowej: `Soneta.HR.DokumentDefinicjiStanowiska`
Nazwa tabeli: `DokumentyDefStan`
Tytuł: Dokumenty defincji stanowisk
Opis: Element szczegółowy definicji stanowiska (DefinicjaStanowiska). Wiąże wymagane dokumenty z definicją stanowiska, np. certyfikaty lub zaświadczenia niezbędne do pełnienia danej roli.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DefinicjaStanowiska` → `DefinicjaStanowiska`

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaDokumentu | `Soneta.Core.DbTuples.DbTupleDefinition` | bazodanowe | Definicja dokumentu |  |
| DefinicjaStanowiska | `Soneta.HR.DefinicjaStanowiska` | bazodanowe, tylko-odczyt, guided-parent | Definicja dokumentu |  |
