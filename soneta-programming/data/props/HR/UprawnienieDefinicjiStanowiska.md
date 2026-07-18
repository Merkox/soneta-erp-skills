# Pola i właściwości klasy biznesowej: `Soneta.HR.UprawnienieDefinicjiStanowiska`
Nazwa tabeli: `UprawnDefStan`
Tytuł: Uprawnienia defincji stanowisk
Opis: Element szczegółowy definicji stanowiska (DefinicjaStanowiska). Przypisuje wymagane uprawnienia do stanowiska, co pozwala kontrolować, czy pracownik posiada niezbędne kwalifikacje.
Tabela konfiguracyjna: Nie
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
| DefinicjaUprawnienia | `Soneta.HR.DefinicjaUprawnienia` | bazodanowe | Definicja uprawnienia |  |
