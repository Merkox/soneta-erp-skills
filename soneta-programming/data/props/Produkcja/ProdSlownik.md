# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.ProdSlownik`
Nazwa tabeli: `ProdSlowniki`
Tytuł: Słowniki
Opis: Konfigurowalna definicja słownika produkcyjnego przechowującego listy wartości alfanumerycznych lub numerycznych. Słowniki służą m.in. do klasyfikacji braków, opisów awarii i innych parametrów produkcyjnych wymagających ustandaryzowanego zestawu wartości do wyboru.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Zablokowana | Określa zablokowanie słownika. Zablokowane słowniki nie będą wyświetlane na listach wyboru. |
| Kod | `string` | bazodanowe |  | Kod, skrócona nazwa słownika. |
| Nazwa | `string` | bazodanowe | Nazwa słownika | Pełna nazwa słownika. |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis słownika. |
| Pozycje | `Soneta.Business.LpSubTable<Soneta.Produkcja.ProdPozSlownika>` |  |  |  |
| Typ | `Soneta.Produkcja.TypSlownika` | bazodanowe, enum |  | Określa typ danych słownika (alfanumeryczny, numeryczny). |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypSlownika (`Soneta.Produkcja.TypSlownika`)
- `Alfanumeryczny` = 0
- `Numeryczny` = 10
