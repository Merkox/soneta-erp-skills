# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.ProdSlownik`
Nazwa tabeli: `ProdSlowniki`
Tytuł: Słowniki
Opis: Konfigurowalna definicja słownika produkcyjnego przechowującego listy wartości alfanumerycznych lub numerycznych. Słowniki służą m.in. do klasyfikacji braków, opisów awarii i innych parametrów produkcyjnych wymagających ustandaryzowanego zestawu wartości do wyboru.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 2
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Zablokowana | Określa zablokowanie słownika. Zablokowane słowniki nie będą wyświetlane na listach wyboru. |
| Kod | `string` | bazodanowe |  | Kod, skrócona nazwa słownika. |
| Nazwa | `string` | bazodanowe | Nazwa słownika | Pełna nazwa słownika. |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis słownika. |
| Pozycje | `LpSubTable<Soneta.Produkcja.ProdPozSlownika>` | podlista |  |  |
| Typ | `Soneta.Produkcja.TypSlownika` (enum) | bazodanowe |  | Określa typ danych słownika (alfanumeryczny, numeryczny). |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypSlownika (`Soneta.Produkcja.TypSlownika`)
- `Alfanumeryczny` = 0
- `Numeryczny` = 10
