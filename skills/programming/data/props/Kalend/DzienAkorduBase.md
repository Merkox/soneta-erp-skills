# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DzienAkorduBase`
Nazwa tabeli: `DniAkordow`
Tytuł: Dni akordów
Opis: Element szczegółowy akordu (Akord). Pojedynczy dzień rozliczenia akordowego, zawierający datę, typ akordu, przepracowany czas, ilość wykonanej pracy oraz wartość w przypadku akordu grupowego.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Akord` → `Akord`
Selektor: pole `Typ` (`Soneta.Kadry.TypAkordu`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Akord | `Soneta.Kadry.Akord` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Czas | `Time` | bazodanowe |  |  |
| Data | `Date` | bazodanowe, tylko-odczyt |  |  |
| Ilosc | `double` | bazodanowe |  |  |
| Typ | `Soneta.Kadry.TypAkordu` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| Wartosc | `Currency` | bazodanowe |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Typ`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Prosty` | 1 | `Soneta.Kalend.DzienAkordu` | Dzień akordu |
| `Grupowy` | 2 | `Soneta.Kalend.DzienGrupowego` | Dzień akordu |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypAkordu (`Soneta.Kadry.TypAkordu`)
- `Prosty` = 1
- `Grupowy` = 2
