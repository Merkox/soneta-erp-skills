# Pola i właściwości klasy biznesowej: `Soneta.Samochodowka.Przejazd`
Nazwa tabeli: `Przejazdy`
Opis: Rejestr przejazdów służbowych w ramach ewidencji przebiegu pojazdu (kilometrówka). Zapisuje datę, pojazd, trasę, stawkę za kilometr i wyliczoną wartość przejazdu. Stanowi podstawę do rozliczenia kosztów używania pojazdów prywatnych do celów służbowych.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 11
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AsString | `string` |  |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  | Data przejazdu |
| DefinicjaTrasy | `Soneta.Samochodowka.DefinicjaTrasy` | bazodanowe |  | Definicja trasy przejazdu |
| Pojazd | `Soneta.Samochodowka.Pojazd` | bazodanowe |  | Pojazd, którym wykonujemy przejazd |
| Rozliczenie | `Soneta.Samochodowka.RozliczenieEP` | bazodanowe |  | Rozliczenie związane z danym przejazdem |
| Stawka | `double` | bazodanowe |  | Stawka za km |
| Trasa | `Soneta.Samochodowka.Trasa` | bazodanowe |  | Parametry trasy przejazdu |
| Trasa.Cel | `string` | bazodanowe |  | Opis trasy |
| Trasa.Dlugosc | `decimal` | bazodanowe |  | Długość trasy |
| Trasa.Opis | `string` | bazodanowe |  | Opis trasy |
| Trasa.Typ | `Soneta.Samochodowka.TypTrasy` | bazodanowe, enum |  | Typ trasy |
| Wartosc | `decimal` | bazodanowe |  | Wartość przejazdu |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypTrasy (`Soneta.Samochodowka.TypTrasy`)
- `Brak` = 0
- `Lokalna` = 1
- `Krajowa` = 2
- `Międzynarodowa` = 3
