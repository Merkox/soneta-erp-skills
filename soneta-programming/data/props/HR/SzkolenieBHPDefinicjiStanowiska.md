# Pola i właściwości klasy biznesowej: `Soneta.HR.SzkolenieBHPDefinicjiStanowiska`
Nazwa tabeli: `SzkolBHPDefStan`
Tytuł: Szkolenia BHP defincji stanowisk
Opis: Element szczegółowy definicji stanowiska (DefinicjaStanowiska). Wskazuje szkolenia BHP wymagane na danym stanowisku, co umożliwia automatyczną kontrolę terminowości obowiązkowych szkoleń.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DefinicjaStanowiska` → `DefinicjaStanowiska`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaStanowiska | `Soneta.HR.DefinicjaStanowiska` | bazodanowe, tylko-odczyt, guided-parent | Definicja stanowiska |  |
| DefinicjaSzkolenia | `Soneta.Kadry.DefinicjaSzkoleniaBHP` | bazodanowe | Definicja szkolenia |  |
