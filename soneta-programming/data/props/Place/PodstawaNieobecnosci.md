# Pola i właściwości klasy biznesowej: `Soneta.Place.PodstawaNieobecnosci`
Nazwa tabeli: `PodstawyNieobec`
Opis: Element szczegółowy pracownika (Pracownik). Przechowuje miesięczną podstawę naliczania wynagrodzenia za czas nieobecności (chorobowe, urlopy), z uwzględnieniem norm czasu pracy i składek.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

- pola bazodanowe: 21
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| DataWyplaty | `Soneta.Types.Date` | bazodanowe | Data wypłaty |  |
| Kwartalne | `decimal` | bazodanowe |  |  |
| Miesieczne | `decimal` | bazodanowe | Miesięczne |  |
| Miesiąc | `Soneta.Types.YearMonth` |  |  |  |
| Norma | `Soneta.Types.Time` | bazodanowe |  |  |
| NormaDni | `int` | bazodanowe |  |  |
| Podstawa | `decimal` | bazodanowe |  | Podstawa naliczania chorobowego za wskazany miesiąc |
| PodstawaM | `decimal` | bazodanowe |  | Podstawa naliczania macierzyńskiego za wskazany miesiąc |
| PodstawaO | `decimal` | bazodanowe |  | Podstawa naliczania opiekuńczego za wskazany miesiąc |
| PodstawaR | `decimal` | bazodanowe |  | Podstawa naliczania rehabilitacyjnego za wskazany miesiąc |
| Praca | `Soneta.Types.Time` | bazodanowe |  |  |
| PracaDni | `int` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, guided-parent |  |  |
| ProcentSkladki | `Soneta.Types.Percent` | bazodanowe | Procent składki | Procent składki potrąconej |
| PrzeliczaneMinimalne | `decimal` | bazodanowe | Przeliczane (minimalne) |  |
| PrzeliczaneStawka | `decimal` | bazodanowe | Przeliczane (stawka) |  |
| Roczne | `decimal` | bazodanowe |  |  |
| Typ | `Soneta.Place.TypyPodstawNieobecnosci` | bazodanowe, enum |  |  |
| WNominalnej | `decimal` | bazodanowe | W nominalnej |  |
| WWyplaconejMale | `decimal` | bazodanowe | W wypłaconej (małe wahania) |  |
| WWyplaconejZnaczne | `decimal` | bazodanowe | W wypłaconej (znaczne wahania) |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypyPodstawNieobecnosci (`Soneta.Place.TypyPodstawNieobecnosci`)
- `Chorobowa` = 1 — Chorobowa
- `Wypoczynkowy` = 2
