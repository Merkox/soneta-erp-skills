# Pola i właściwości klasy biznesowej: `Soneta.HR.WydziałDefinicjiStanowiska`
Nazwa tabeli: `WydzialyDefStan`
Tytuł: Jednostki organizacyjne defincji stanowisk
Opis: Element szczegółowy definicji stanowiska (DefinicjaStanowiska). Wskazuje jednostki organizacyjne, w których dane stanowisko występuje, wraz z planowaną liczbą etatów i okresem obowiązywania.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DefinicjaStanowiska` → `DefinicjaStanowiska`

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 1
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaStanowiska | `Soneta.HR.DefinicjaStanowiska` | bazodanowe, tylko-odczyt, guided-parent | Definicja stanowiska |  |
| Ilosc | `Fraction` | bazodanowe | Ilość |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |
