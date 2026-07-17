# Pola i właściwości klasy biznesowej: `Soneta.HR2.RekrutacjaAplikacja`
Nazwa tabeli: `RekrutAplikacje`
Tytuł: Aplikacje
Opis: Aplikacja kandydata na konkretne stanowisko w ramach procesu rekrutacji. Rejestruje stan aplikacji, planowaną datę zatrudnienia oraz powiązanie z ofertą pracy, wydziałem i definicją stanowiska.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IŹródłoRekrutacji`

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Oferta | `Soneta.HR2.OfertaPracy` | bazodanowe |  | Oferta pracy na podstawie której aplikacja została wprowadzona do systemu |
| PlanowanaDataZatrudnienia | `Soneta.Types.Date` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Stan | `Soneta.HR2.StanAplikacji` | bazodanowe, enum |  |  |
| Stanowisko | `Soneta.HR.DefinicjaStanowiska` | bazodanowe |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StanAplikacji (`Soneta.HR2.StanAplikacji`)
- `Wprowadzona` = 1
- `Zakończona` = 2
- `Anulowana` = 3
