# Pola i właściwości klasy biznesowej: `Soneta.HR.UprawnienieDefinicjiStanowiska`
Nazwa tabeli: `UprawnDefStan`
Tytuł: Uprawnienia defincji stanowisk
Opis: Element szczegółowy definicji stanowiska (DefinicjaStanowiska). Przypisuje wymagane uprawnienia do stanowiska, co pozwala kontrolować, czy pracownik posiada niezbędne kwalifikacje.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `DefinicjaStanowiska` → `DefinicjaStanowiska`

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaStanowiska | `Soneta.HR.DefinicjaStanowiska` | bazodanowe, guided-parent | Definicja stanowiska |  |
| DefinicjaUprawnienia | `Soneta.HR.DefinicjaUprawnienia` | bazodanowe | Definicja uprawnienia |  |
