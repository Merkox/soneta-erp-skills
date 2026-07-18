# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DzienAkorduBase`
Nazwa tabeli: `DniAkordow`
Tytuł: Dni akordów
Opis: Element szczegółowy akordu (Akord). Pojedynczy dzień rozliczenia akordowego, zawierający datę, typ akordu, przepracowany czas, ilość wykonanej pracy oraz wartość w przypadku akordu grupowego.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Akord` → `Akord`

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 3
- podlisty: 0
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Akord | `Soneta.Kadry.Akord` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Czas | `Time` | bazodanowe |  |  |
| Data | `Date` | bazodanowe, tylko-odczyt |  |  |
| Ilosc | `double` | bazodanowe |  |  |
| Typ | `Soneta.Kadry.TypAkordu` (enum) | bazodanowe, tylko-odczyt |  |  |
| Wartosc | `Currency` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypAkordu (`Soneta.Kadry.TypAkordu`)
- `Prosty` = 1
- `Grupowy` = 2
