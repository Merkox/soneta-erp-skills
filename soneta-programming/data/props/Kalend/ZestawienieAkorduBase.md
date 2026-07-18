# Pola i właściwości klasy biznesowej: `Soneta.Kalend.ZestawienieAkorduBase`
Nazwa tabeli: `ZestawAkordow`
Tytuł: Zestawienia akordów
Opis: Element szczegółowy akordu (Akord). Okresowe zestawienie rozliczenia akordowego, agregujące czas pracy, ilość i wartość w ramach okresu rozliczeniowego dla danego typu akordu.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Akord` → `Akord`

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 1
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Akord | `Soneta.Kadry.Akord` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Czas | `Time` | bazodanowe |  |  |
| Ilosc | `double` | bazodanowe |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Typ | `Soneta.Kadry.TypAkordu` (enum) | bazodanowe, tylko-odczyt |  |  |
| Wartosc | `Currency` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypAkordu (`Soneta.Kadry.TypAkordu`)
- `Prosty` = 1
- `Grupowy` = 2
