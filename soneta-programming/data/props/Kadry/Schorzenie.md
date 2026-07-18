# Pola i właściwości klasy biznesowej: `Soneta.Kadry.Schorzenie`
Nazwa tabeli: `Schorzenia`
Opis: Ewidencja schorzeń i niepełnosprawności pracownika. Rejestruje okres, typ schorzenia, przyczynę niepełnosprawności i rodzaj niesprawności, wykorzystywane przy dofinansowaniach PFRON i obowiązkach BHP.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 2
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| Przyczyna | `Soneta.Kadry.PrzyczynaNiepelnosprawnosci` (enum) | bazodanowe |  |  |
| Rodzaj | `Soneta.Kadry.RodzajNiesprawnosci` (enum) | bazodanowe |  |  |
| Typ | `Soneta.Kadry.TypSchorzenia` (enum) | bazodanowe |  |  |

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
