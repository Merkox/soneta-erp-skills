# Pola i właściwości klasy biznesowej: `Soneta.Kalend.ZestawienieAkorduBase`
Nazwa tabeli: `ZestawAkordow`
Tytuł: Zestawienia akordów
Opis: Element szczegółowy akordu (Akord). Okresowe zestawienie rozliczenia akordowego, agregujące czas pracy, ilość i wartość w ramach okresu rozliczeniowego dla danego typu akordu.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Akord` → `Akord`

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Akord | `Soneta.Kadry.Akord` | bazodanowe, guided-parent |  |  |
| Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| Ilosc | `double` | bazodanowe |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Typ | `Soneta.Kadry.TypAkordu` | bazodanowe, enum |  |  |
| Wartosc | `Soneta.Types.Currency` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypAkordu (`Soneta.Kadry.TypAkordu`)
- `Prosty` = 1
- `Grupowy` = 2
