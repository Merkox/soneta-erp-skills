# Pola i właściwości klasy biznesowej: `Soneta.HR.CzynnikSzkodliwyDefinicjiStanowiska`
Nazwa tabeli: `CzynSzkodDefStan`
Tytuł: Czynniki szkodliwe defincji stanowisk
Opis: Element szczegółowy definicji stanowiska (DefinicjaStanowiska). Przypisuje czynniki szkodliwe występujące na stanowisku pracy, co jest wymagane przy kierowaniu na badania lekarskie i ocenie ryzyka zawodowego.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DefinicjaStanowiska` → `DefinicjaStanowiska`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaCzynnikowSzkodliwych | `Soneta.Kadry.DefinicjaCzynnikowSzkodliwych` | bazodanowe | Definicja czynników szkodliwych |  |
| DefinicjaStanowiska | `Soneta.HR.DefinicjaStanowiska` | bazodanowe, tylko-odczyt, guided-parent | Definicja stanowiska |  |
