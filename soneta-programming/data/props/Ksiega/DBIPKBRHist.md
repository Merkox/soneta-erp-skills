# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.DBIPKBRHist`
Nazwa tabeli: `DBIPKBRHists`
Tytuł: Historia zmian statusów okresów rozliczeniowych PKBR
Opis: Historia zmian statusu okresu rozliczeniowego na potrzeby użytkowników PKBR. Zawiera informację o dacie oraz użytkowniku dokonującym zmiany statusu. Rejestruje również status przed zmianą i po zmianie oraz opcjonalny komentarz.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DBItemPKBROkRoz` → `DBItemPKBROkRoz`

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DBItemPKBROkRoz | `Soneta.Ksiega.DBItemPKBROkRoz` | bazodanowe, tylko-odczyt, guided-parent |  | Okres rozliczeniowy |
| DataOperacji | `System.DateTime` | bazodanowe | DataOperacji | DataOperacji |
| Komentarz | `string` | bazodanowe | Komentarz | Komentarz |
| Operator | `string` | bazodanowe | Operator | Operator |
| StatusPo | `Soneta.Ksiega.TaxMonthStatus` (enum) | bazodanowe | Status po | Status po |
| StatusPrzed | `Soneta.Ksiega.TaxMonthStatus` (enum) | bazodanowe | Status przed | Status przed |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TaxMonthStatus (`Soneta.Ksiega.TaxMonthStatus`)
- `Otwarty` = 1 — Otwarty
- `Zamkniety` = 2 — Zamknięty
- `OtwartyPonownie` = 3 — Otwarty ponownie
