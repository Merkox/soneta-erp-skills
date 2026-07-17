# Pola i właściwości klasy biznesowej: `Soneta.HR.DokumentDefinicjiStanowiska`
Nazwa tabeli: `DokumentyDefStan`
Tytuł: Dokumenty defincji stanowisk
Opis: Element szczegółowy definicji stanowiska (DefinicjaStanowiska). Wiąże wymagane dokumenty z definicją stanowiska, np. certyfikaty lub zaświadczenia niezbędne do pełnienia danej roli.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DefinicjaStanowiska` → `DefinicjaStanowiska`

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaDokumentu | `Soneta.Core.DbTuples.DbTupleDefinition` | bazodanowe | Definicja dokumentu |  |
| DefinicjaStanowiska | `Soneta.HR.DefinicjaStanowiska` | bazodanowe, guided-parent | Definicja dokumentu |  |
