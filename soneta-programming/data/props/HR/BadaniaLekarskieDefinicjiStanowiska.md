# Pola i właściwości klasy biznesowej: `Soneta.HR.BadaniaLekarskieDefinicjiStanowiska`
Nazwa tabeli: `BadLekDefStan`
Tytuł: Badania lekarskie defincji stanowisk
Opis: Element szczegółowy definicji stanowiska (DefinicjaStanowiska). Określa rodzaje badań lekarskich wymaganych na stanowisku, wspierając kontrolę medycyny pracy i terminów ważności badań.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DefinicjaStanowiska` → `DefinicjaStanowiska`

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaBadania | `Soneta.Kadry.DefinicjaBadaniaLekarskiego` | bazodanowe | Definicja badania lekarskego |  |
| DefinicjaStanowiska | `Soneta.HR.DefinicjaStanowiska` | bazodanowe, guided-parent | Definicja stanowiska |  |
