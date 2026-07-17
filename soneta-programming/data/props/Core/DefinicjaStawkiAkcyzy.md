# Pola i właściwości klasy biznesowej: `Soneta.Core.DefinicjaStawkiAkcyzy`
Nazwa tabeli: `DefStawekAkcyzy`
Tytuł: Definicje stawek akcyzy
Opis: Słownik stawek podatku akcyzowego. Każda definicja zawiera kod, symbol (np. SWW), grupę wyrobów, pozycję tabeli stawek, typ stawki i procent. Używana przy dokumentach dotyczących wyrobów akcyzowych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Kod | `string` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| Stawka | `Soneta.Core.StawkaAkcyzy` | bazodanowe |  |  |
| Stawka.Grupa | `string` | bazodanowe |  | Grupa wyrobów |
| Stawka.Pozycja | `int` | bazodanowe |  | Pozycja tabeli stawek |
| Stawka.Procent | `Soneta.Types.Percent` | bazodanowe |  |  |
| Stawka.Symbol | `string` | bazodanowe |  | Symbol - np. SWW |
| Stawka.Typ | `Soneta.Core.TypStawkiAkcyzy` | bazodanowe, enum |  |  |
| Stawka.TypGrupy | `Soneta.Core.TypGrupyAkcyzy` | bazodanowe, enum |  | Typ grupy wyrobów |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypGrupyAkcyzy (`Soneta.Core.TypGrupyAkcyzy`)
- `Brak` = 0 — Brak
- `WyrobySpirytusowe` = 1
- `WyrobyWiniarskie` = 2
- `Piwa` = 3
- `PaliwaSilnikowe` = 4
- `SamochodyOsobowe` = 5
- `WyrobyTytoniowe` = 6
- `PozostałeWyrobyAkcyzowe` = 7
- `EnergiaElektryczna` = 8

### TypStawkiAkcyzy (`Soneta.Core.TypStawkiAkcyzy`)
- `Procentowa` = 0 — Procentowa
- `Kwotowa` = 1
- `Zwolniona` = 2
