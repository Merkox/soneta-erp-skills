# Pola i właściwości klasy biznesowej: `Soneta.HR.SzkolenieBHPDefinicjiStanowiska`
Nazwa tabeli: `SzkolBHPDefStan`
Tytuł: Szkolenia BHP defincji stanowisk
Opis: Element szczegółowy definicji stanowiska (DefinicjaStanowiska). Wskazuje szkolenia BHP wymagane na danym stanowisku, co umożliwia automatyczną kontrolę terminowości obowiązkowych szkoleń.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DefinicjaStanowiska` → `DefinicjaStanowiska`

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaStanowiska | `Soneta.HR.DefinicjaStanowiska` | bazodanowe, guided-parent | Definicja stanowiska |  |
| DefinicjaSzkolenia | `Soneta.Kadry.DefinicjaSzkoleniaBHP` | bazodanowe | Definicja szkolenia |  |
