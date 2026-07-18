# Pola i właściwości klasy biznesowej: `Soneta.HR.BadaniaLekarskieDefinicjiStanowiska`
Nazwa tabeli: `BadLekDefStan`
Tytuł: Badania lekarskie defincji stanowisk
Opis: Element szczegółowy definicji stanowiska (DefinicjaStanowiska). Określa rodzaje badań lekarskich wymaganych na stanowisku, wspierając kontrolę medycyny pracy i terminów ważności badań.
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
| DefinicjaBadania | `Soneta.Kadry.DefinicjaBadaniaLekarskiego` | bazodanowe | Definicja badania lekarskego |  |
| DefinicjaStanowiska | `Soneta.HR.DefinicjaStanowiska` | bazodanowe, tylko-odczyt, guided-parent | Definicja stanowiska |  |
