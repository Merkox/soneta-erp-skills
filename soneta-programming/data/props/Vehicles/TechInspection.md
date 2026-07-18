# Pola i właściwości klasy biznesowej: `Soneta.Vehicles.TechInspection`
Nazwa tabeli: `TechInspections`
Tytuł: Bdania techniczne pojazdów
Opis: Rejestr badań technicznych pojazdów floty firmowej. Przechowuje dane o dacie wykonania i ważności badania, wyniku (pozytywny/negatywny), rodzaju ewentualnej usterki oraz powiązanym zdarzeniu flotowym.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Flaw | `Soneta.Vehicles.Enums.FlawType` (enum) | bazodanowe | Usterka |  |
| FleetEvent | `Soneta.Zadania.Zadanie` | bazodanowe | Zdarzenie |  |
| InspectionDate | `Date` | bazodanowe | Data wykonania badania |  |
| IsPositive | `bool` | bazodanowe | Pozytywny wynik badania |  |
| ValidityDate | `Date` | bazodanowe | Data ważności badania |  |
| Vehicle | `Soneta.Samochodowka.Pojazd` | bazodanowe, tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### FlawType (`Soneta.Vehicles.Enums.FlawType`)
- `None` = 0 — Brak
- `UD` = 1 — Usterka drobna
- `UP` = 2 — Usterka poważna
- `UN` = 3 — Usterka niebezpieczna
