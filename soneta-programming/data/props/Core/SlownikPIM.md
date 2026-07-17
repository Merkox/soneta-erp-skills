# Pola i właściwości klasy biznesowej: `Soneta.Core.PIM.SlownikPIM`
Nazwa tabeli: `SlownikiPIM`
Opis: Pola dodatkowe przypisane do Hosta. Dzięki szabloną można użyć wartości np. do tłumaczeń cech, nazw, kodów.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Cecha | `Soneta.Business.FeatureDefinition` | bazodanowe |  |  |
| Host | `Soneta.Business.ISlownikPIMHost` | bazodanowe | Obiekt głowny | Obiekt do którego przypisane jest pole we wskazanym szablonie |
| Jezyk | `string` | bazodanowe |  |  |
| Pole | `string` | bazodanowe |  |  |
| Szablon | `Soneta.Core.PIM.SzablonSlownikaPIM` | bazodanowe |  |  |
| Typ | `Soneta.Core.PIM.SlownikPIM.TypWartosciSlownikPIM` | enum |  |  |
| Wartosc | `string` | bazodanowe | Wartość |  |
| WartoscOryginalna | `string` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypWartosciSlownikPIM (`Soneta.Core.PIM.SlownikPIM.TypWartosciSlownikPIM`)
- `Podstawowe` = 0
- `Cecha` = 1
