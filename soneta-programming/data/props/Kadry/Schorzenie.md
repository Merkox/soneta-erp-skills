# Pola i właściwości klasy biznesowej: `Soneta.Kadry.Schorzenie`
Nazwa tabeli: `Schorzenia`
Opis: Ewidencja schorzeń i niepełnosprawności pracownika. Rejestruje okres, typ schorzenia, przyczynę niepełnosprawności i rodzaj niesprawności, wykorzystywane przy dofinansowaniach PFRON i obowiązkach BHP.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Przyczyna | `Soneta.Kadry.PrzyczynaNiepelnosprawnosci` | bazodanowe, enum |  |  |
| Rodzaj | `Soneta.Kadry.RodzajNiesprawnosci` | bazodanowe, enum |  |  |
| Typ | `Soneta.Kadry.TypSchorzenia` | bazodanowe, enum |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### PrzyczynaNiepelnosprawnosci (`Soneta.Kadry.PrzyczynaNiepelnosprawnosci`)
- `Niezdefiniowana` = 0 — Niezdefiniowana
- `WadaWrodzona` = 1
- `ChorobaZawodowa` = 2
- `ChorobaInna` = 3
- `WypadekWMiejscuPracy` = 4
- `WypadekWDomu` = 5
- `WypadekKomunikacyjny` = 6
- `InnyWypadek` = 7
- `BrakDanych` = 8

### RodzajNiesprawnosci (`Soneta.Kadry.RodzajNiesprawnosci`)
- `Nieokreślony` = 0 — Nieokreślony
- `Słuchu` = 1
- `Wzroku` = 2
- `Ruchu` = 3
- `Inny` = 4

### TypSchorzenia (`Soneta.Kadry.TypSchorzenia`)
- `Niezdefiniowany` = 0 — Niezdefiniowany
- `UszkodzeniaIChorobyNarządówRuchu` = 1
- `UszkodzeniaIChorobyNarząduWzroku` = 2
- `UszkodzeniaIChorobyNarząduSłuchu` = 3
- `SchorzeniaUkładuKrążenia` = 4
- `SchorzeniaPsychiczne` = 5
- `UpośledzeniaUmysłowe` = 6
- `SchorzeniaNeurologiczne` = 7
- `InneSchorzenia` = 8
