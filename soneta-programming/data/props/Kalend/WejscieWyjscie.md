# Pola i właściwości klasy biznesowej: `Soneta.Kalend.WejscieWyjscie`
Nazwa tabeli: `WejsciaWyjscia`
Tytuł: Wejścia/Wyjścia
Opis: Element szczegółowy dnia pracy (DzienPracy). Rejestracja pojedynczego wejścia lub wyjścia pracownika w danym dniu, zawierająca godzinę, typ operacji (wejście/wyjście/służbowe/prywatne) oraz powiązanie z definicją zdarzenia RCP.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dzien` → `DzienPracy`

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaZdarzenia | `Soneta.Kalend.DefinicjaZdarzeniaRCP` | bazodanowe |  |  |
| Dzien | `Soneta.Kalend.DzienPracy` | bazodanowe, guided-parent |  |  |
| Godzina | `Soneta.Types.Time` | bazodanowe |  |  |
| Lp | `int` | bazodanowe |  | Liczba porządkowa kolejnych wejść wyjść |
| Operacja | `int` | bazodanowe |  |  |
| Typ | `Soneta.Kalend.TypWejsciaWyjscia` | bazodanowe, enum |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypWejsciaWyjscia (`Soneta.Kalend.TypWejsciaWyjscia`)
- `Niezdefiniowany` = 0
- `Wejscie` = 1 — Wejście
- `Wyjscie` = 2 — Wyjście
- `WejscieSluzbowe` = 3 — Wejście służbowe
- `WyjscieSluzbowe` = 4 — Wyjście służbowe
- `WejsciePrywatne` = 5 — Wejście prywatne
- `WyjsciePrywatne` = 6 — Wyjście prywatne
