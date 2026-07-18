# Pola i właściwości klasy biznesowej: `Soneta.HR.GrupaZaszeregowaniaDefinicjiStanowiska`
Nazwa tabeli: `GrupZasDefStan`
Tytuł: Grupy zaszeregowania defincji stanowisk
Opis: Element szczegółowy definicji stanowiska (DefinicjaStanowiska). Przypisuje dopuszczalne grupy zaszeregowania do stanowiska, ograniczając zakres stawek wynagrodzenia dla pracowników na danym stanowisku.
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
| GrupaZaszeregowania | `Soneta.Kadry.GrupaZaszeregowania` | bazodanowe | Grupa zaszeregowania |  |
