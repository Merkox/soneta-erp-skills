# Pola i właściwości klasy biznesowej: `Soneta.HR.WydziałDefinicjiStanowiska`
Nazwa tabeli: `WydzialyDefStan`
Tytuł: Jednostki organizacyjne defincji stanowisk
Opis: Element szczegółowy definicji stanowiska (DefinicjaStanowiska). Wskazuje jednostki organizacyjne, w których dane stanowisko występuje, wraz z planowaną liczbą etatów i okresem obowiązywania.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DefinicjaStanowiska` → `DefinicjaStanowiska`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaStanowiska | `Soneta.HR.DefinicjaStanowiska` | bazodanowe, tylko-odczyt, guided-parent | Definicja stanowiska |  |
| Ilosc | `Fraction` | bazodanowe | Ilość |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |
