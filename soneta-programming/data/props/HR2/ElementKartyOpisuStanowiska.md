# Pola i właściwości klasy biznesowej: `Soneta.HR2.ElementKartyOpisuStanowiska`
Nazwa tabeli: `ElementyKOS`
Tytuł: Elementy KOS
Opis: Element szczegółowy karty opisu stanowiska (KartaOpisuStanowiskaBase). Przechowuje treść opisową przypisaną do definicji elementu, np. zakres obowiązków lub wymagania na stanowisku.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Karta` → `KartaOpisuStanowiskaBase`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.HR2.DefinicjaElementuOpisuStanowiska` | bazodanowe |  |  |
| Karta | `Soneta.HR2.KartaOpisuStanowiskaBase` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| OpisJednaLinia | `string` | tylko-odczyt |  |  |
