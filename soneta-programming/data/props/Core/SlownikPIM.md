# Pola i właściwości klasy biznesowej: `Soneta.Core.PIM.SlownikPIM`
Nazwa tabeli: `SlownikiPIM`
Opis: Pola dodatkowe przypisane do Hosta. Dzięki szabloną można użyć wartości np. do tłumaczeń cech, nazw, kodów.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Cecha | `FeatureDefinition` | bazodanowe |  |  |
| Host | `ISlownikPIMHost` | bazodanowe, tylko-odczyt | Obiekt głowny | Obiekt do którego przypisane jest pole we wskazanym szablonie |
| Jezyk | `string` | bazodanowe |  |  |
| Pole | `string` | bazodanowe |  |  |
| Szablon | `Soneta.Core.PIM.SzablonSlownikaPIM` | bazodanowe |  |  |
| Typ | `Soneta.Core.PIM.SlownikPIM.TypWartosciSlownikPIM` (enum) | tylko-odczyt |  |  |
| Wartosc | `string` | bazodanowe | Wartość |  |
| WartoscOryginalna | `string` | tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypWartosciSlownikPIM (`Soneta.Core.PIM.SlownikPIM.TypWartosciSlownikPIM`)
- `Podstawowe` = 0
- `Cecha` = 1
