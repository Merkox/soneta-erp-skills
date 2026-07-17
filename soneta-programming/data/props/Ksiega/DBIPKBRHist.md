# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.DBIPKBRHist`
Nazwa tabeli: `DBIPKBRHists`
Tytuł: Historia zmian statusów okresów rozliczeniowych PKBR
Opis: Historia zmian statusu okresu rozliczeniowego na potrzeby użytkowników PKBR. Zawiera informację o dacie oraz użytkowniku dokonującym zmiany statusu. Rejestruje również status przed zmianą i po zmianie oraz opcjonalny komentarz.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DBItemPKBROkRoz` → `DBItemPKBROkRoz`

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DBItemPKBROkRoz | `Soneta.Ksiega.DBItemPKBROkRoz` | bazodanowe, guided-parent |  | Okres rozliczeniowy |
| DataOperacji | `System.DateTime` | bazodanowe | DataOperacji | DataOperacji |
| Komentarz | `string` | bazodanowe | Komentarz | Komentarz |
| Operator | `string` | bazodanowe | Operator | Operator |
| StatusPo | `Soneta.Ksiega.TaxMonthStatus` | bazodanowe, enum | Status po | Status po |
| StatusPrzed | `Soneta.Ksiega.TaxMonthStatus` | bazodanowe, enum | Status przed | Status przed |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TaxMonthStatus (`Soneta.Ksiega.TaxMonthStatus`)
- `Otwarty` = 1 — Otwarty
- `Zamkniety` = 2 — Zamknięty
- `OtwartyPonownie` = 3 — Otwarty ponownie
