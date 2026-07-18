# Pola i właściwości klasy biznesowej: `Soneta.Kalend.PlanowanaNieobecność`
Nazwa tabeli: `PlanNieobecnosci`
Tytuł: Planowane nieobecności
Opis: Planowana nieobecność pracownika (np. urlop zaplanowany z wyprzedzeniem). Przechowuje okres, definicję nieobecności oraz stan akceptacji planu, umożliwiając weryfikację limitów przed faktycznym zarejestrowaniem nieobecności.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 3
- podlisty: 2
- subrowy: 0
- razem: 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Kalend.DefinicjaNieobecnosci` | bazodanowe |  |  |
| IlośćDni | `int` |  |  |  |
| Nieobecności | `View` | podlista |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| Stan | `Soneta.Kalend.StanPlanowanejNieobecności` (enum) | bazodanowe, tylko-odczyt |  |  |
| TypDni | `Soneta.Kalend.TypyDni` (enum) | tylko-odczyt |  |  |

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
