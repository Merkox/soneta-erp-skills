# Pola i właściwości klasy biznesowej: `Soneta.Place.PodstawaNieobecnosci`
Nazwa tabeli: `PodstawyNieobec`
Opis: Element szczegółowy pracownika (Pracownik). Przechowuje miesięczną podstawę naliczania wynagrodzenia za czas nieobecności (chorobowe, urlopy), z uwzględnieniem norm czasu pracy i składek.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`
Selektor: pole `Typ` (`Soneta.Place.TypyPodstawNieobecnosci`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe, tylko-odczyt |  |  |
| DataWyplaty | `Date` | bazodanowe | Data wypłaty |  |
| Kwartalne | `decimal` | bazodanowe |  |  |
| Miesieczne | `decimal` | bazodanowe | Miesięczne |  |
| Miesiąc | `YearMonth` |  |  |  |
| Norma | `Time` | bazodanowe |  |  |
| NormaDni | `int` | bazodanowe |  |  |
| Podstawa | `decimal` | bazodanowe |  | Podstawa naliczania chorobowego za wskazany miesiąc |
| PodstawaM | `decimal` | bazodanowe |  | Podstawa naliczania macierzyńskiego za wskazany miesiąc |
| PodstawaO | `decimal` | bazodanowe |  | Podstawa naliczania opiekuńczego za wskazany miesiąc |
| PodstawaR | `decimal` | bazodanowe |  | Podstawa naliczania rehabilitacyjnego za wskazany miesiąc |
| Praca | `Time` | bazodanowe |  |  |
| PracaDni | `int` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| ProcentSkladki | `Percent` | bazodanowe | Procent składki | Procent składki potrąconej |
| PrzeliczaneMinimalne | `decimal` | bazodanowe | Przeliczane (minimalne) |  |
| PrzeliczaneStawka | `decimal` | bazodanowe | Przeliczane (stawka) |  |
| Roczne | `decimal` | bazodanowe |  |  |
| Typ | `Soneta.Place.TypyPodstawNieobecnosci` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| WNominalnej | `decimal` | bazodanowe | W nominalnej |  |
| WWyplaconejMale | `decimal` | bazodanowe | W wypłaconej (małe wahania) |  |
| WWyplaconejZnaczne | `decimal` | bazodanowe | W wypłaconej (znaczne wahania) |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Typ`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Chorobowa` | 1 | `Soneta.Place.PodstawaChorobowego` |  |
| `Wypoczynkowy` | 2 | `Soneta.Place.PodstawaWypoczynkowego` |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypyPodstawNieobecnosci (`Soneta.Place.TypyPodstawNieobecnosci`)
- `Chorobowa` = 1 — Chorobowa
- `Wypoczynkowy` = 2
