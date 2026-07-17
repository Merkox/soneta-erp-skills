# Pola i właściwości klasy biznesowej: `Soneta.HR.GrupaZaszeregowaniaDefinicjiStanowiska`
Nazwa tabeli: `GrupZasDefStan`
Tytuł: Grupy zaszeregowania defincji stanowisk
Opis: Element szczegółowy definicji stanowiska (DefinicjaStanowiska). Przypisuje dopuszczalne grupy zaszeregowania do stanowiska, ograniczając zakres stawek wynagrodzenia dla pracowników na danym stanowisku.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DefinicjaStanowiska` → `DefinicjaStanowiska`

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaStanowiska | `Soneta.HR.DefinicjaStanowiska` | bazodanowe, guided-parent | Definicja stanowiska |  |
| GrupaZaszeregowania | `Soneta.Kadry.GrupaZaszeregowania` | bazodanowe | Grupa zaszeregowania |  |
