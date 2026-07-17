# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DzienAkorduBase`
Nazwa tabeli: `DniAkordow`
Tytuł: Dni akordów
Opis: Element szczegółowy akordu (Akord). Pojedynczy dzień rozliczenia akordowego, zawierający datę, typ akordu, przepracowany czas, ilość wykonanej pracy oraz wartość w przypadku akordu grupowego.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Akord` → `Akord`

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Akord | `Soneta.Kadry.Akord` | bazodanowe, guided-parent |  |  |
| Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Ilosc | `double` | bazodanowe |  |  |
| Typ | `Soneta.Kadry.TypAkordu` | bazodanowe, enum |  |  |
| Wartosc | `Soneta.Types.Currency` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypAkordu (`Soneta.Kadry.TypAkordu`)
- `Prosty` = 1
- `Grupowy` = 2
