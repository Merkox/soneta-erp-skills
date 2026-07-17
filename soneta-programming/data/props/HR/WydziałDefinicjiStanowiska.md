# Pola i właściwości klasy biznesowej: `Soneta.HR.WydziałDefinicjiStanowiska`
Nazwa tabeli: `WydzialyDefStan`
Tytuł: Jednostki organizacyjne defincji stanowisk
Opis: Element szczegółowy definicji stanowiska (DefinicjaStanowiska). Wskazuje jednostki organizacyjne, w których dane stanowisko występuje, wraz z planowaną liczbą etatów i okresem obowiązywania.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DefinicjaStanowiska` → `DefinicjaStanowiska`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaStanowiska | `Soneta.HR.DefinicjaStanowiska` | bazodanowe, guided-parent | Definicja stanowiska |  |
| Ilosc | `Soneta.Types.Fraction` | bazodanowe | Ilość |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |
