# Pola i właściwości klasy biznesowej: `Soneta.Kalend.PlanowanaNieobecność`
Nazwa tabeli: `PlanNieobecnosci`
Tytuł: Planowane nieobecności
Opis: Planowana nieobecność pracownika (np. urlop zaplanowany z wyprzedzeniem). Przechowuje okres, definicję nieobecności oraz stan akceptacji planu, umożliwiając weryfikację limitów przed faktycznym zarejestrowaniem nieobecności.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Kalend.DefinicjaNieobecnosci` | bazodanowe |  |  |
| IlośćDni | `int` |  |  |  |
| Nieobecności | `Soneta.Business.View` |  |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Stan | `Soneta.Kalend.StanPlanowanejNieobecności` | bazodanowe, enum |  |  |
| TypDni | `Soneta.Kalend.TypyDni` | enum |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StanPlanowanejNieobecności (`Soneta.Kalend.StanPlanowanejNieobecności`)
- `Oczekująca` = 1
- `Wprowadzona` = 2
- `Korygowana` = 3
- `Zatwierdzona` = 4
- `Anulowana` = 5

### TypyDni (`Soneta.Kalend.TypyDni`)
- `Pracy` = 0 — Pracy
- `Kalendarzowe` = 1
