# Pola i właściwości klasy biznesowej: `Soneta.HR.SzkolenieBHPDefinicjiStanowiska`
Nazwa tabeli: `SzkolBHPDefStan`
Tytuł: Szkolenia BHP defincji stanowisk
Opis: Element szczegółowy definicji stanowiska (DefinicjaStanowiska). Wskazuje szkolenia BHP wymagane na danym stanowisku, co umożliwia automatyczną kontrolę terminowości obowiązkowych szkoleń.
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
| DefinicjaStanowiska | `Soneta.HR.DefinicjaStanowiska` | bazodanowe, tylko-odczyt, guided-parent | Definicja stanowiska |  |
| DefinicjaSzkolenia | `Soneta.Kadry.DefinicjaSzkoleniaBHP` | bazodanowe | Definicja szkolenia |  |
