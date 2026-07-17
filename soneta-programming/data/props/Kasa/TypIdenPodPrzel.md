# Pola i właściwości klasy biznesowej: `Soneta.Kasa.TypIdenPodPrzel`
Nazwa tabeli: `TypyIdenPodPrzel`
Tytuł: Typy identyfikatorów podmiotu przelewu
Opis: Słownik typów identyfikatorów podmiotów stosowanych w przelewach zagranicznych. Definiuje kody identyfikacji (np. paszport, dowód osobisty, PESEL) wymagane przy eksporcie przelewów w formatach międzynarodowych, z rozróżnieniem na osoby fizyczne i prawne.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Blokada typu identyfikatora |
| Nazwa | `string` | bazodanowe |  |  |
| Symbol | `string` | bazodanowe |  |  |
| TypOsoby | `Soneta.Kasa.TypFormaPrawna` | bazodanowe, enum |  | Typ osoby |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypFormaPrawna (`Soneta.Kasa.TypFormaPrawna`)
- `Wszystkie` = 0
- `OsobaFizyczna` = 1
- `OsobaPrawna` = 2
