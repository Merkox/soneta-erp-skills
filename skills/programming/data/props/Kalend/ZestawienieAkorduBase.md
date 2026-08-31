# Pola i właściwości klasy biznesowej: `Soneta.Kalend.ZestawienieAkorduBase`
Nazwa tabeli: `ZestawAkordow`
Tytuł: Zestawienia akordów
Opis: Element szczegółowy akordu (Akord). Okresowe zestawienie rozliczenia akordowego, agregujące czas pracy, ilość i wartość w ramach okresu rozliczeniowego dla danego typu akordu.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Akord` → `Akord`
Selektor: pole `Typ` (`Soneta.Kadry.TypAkordu`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Akord | `Soneta.Kadry.Akord` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Czas | `Time` | bazodanowe |  |  |
| Ilosc | `double` | bazodanowe |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Typ | `Soneta.Kadry.TypAkordu` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| Wartosc | `Currency` | bazodanowe |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Typ`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Prosty` | 1 | `Soneta.Kalend.ZestawienieAkordu` | Zestawienie akordu |
| `Grupowy` | 2 | `Soneta.Kalend.ZestawienieGrupowego` | Zestawienie akordu |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypAkordu (`Soneta.Kadry.TypAkordu`)
- `Prosty` = 1
- `Grupowy` = 2
