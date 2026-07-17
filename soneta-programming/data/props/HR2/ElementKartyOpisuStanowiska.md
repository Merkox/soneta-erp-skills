# Pola i właściwości klasy biznesowej: `Soneta.HR2.ElementKartyOpisuStanowiska`
Nazwa tabeli: `ElementyKOS`
Tytuł: Elementy KOS
Opis: Element szczegółowy karty opisu stanowiska (KartaOpisuStanowiskaBase). Przechowuje treść opisową przypisaną do definicji elementu, np. zakres obowiązków lub wymagania na stanowisku.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Karta` → `KartaOpisuStanowiskaBase`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.HR2.DefinicjaElementuOpisuStanowiska` | bazodanowe |  |  |
| Karta | `Soneta.HR2.KartaOpisuStanowiskaBase` | bazodanowe, guided-parent |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| OpisJednaLinia | `string` |  |  |  |
