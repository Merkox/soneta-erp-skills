# Pola i właściwości klasy biznesowej: `Soneta.Core.GIODO.GIODOPrzetwarzanie`
Nazwa tabeli: `GIODOPrzetwarz`
Tytuł: Czynności przetwarzania
Opis: Czynność przetwarzania danych osobowych w ramach zbioru danych RODO. Dokumentuje nazwę czynności, numer, zakres przetwarzania, daty rozpoczęcia i zakończenia oraz planowany termin zakończenia.
Tabela konfiguracyjna: Nie
Guided: root
Selektor: pole `Selektor` (`Soneta.Core.GIODO.SelektorPrzetwarzania`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe | Nazwa czynności | Nazwa czynności przetwarzania |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | tylko-odczyt |  |  |
| Opis | `MemoText` | bazodanowe, podlista | Opis, zakres przetwarzania |  |
| PlanZakonczenia | `string` | bazodanowe | Plan zakończenia | Plan zakończenia przetwarzania |
| Rozpoczecie | `Date` | bazodanowe | Data rozpoczęcia przetwarzania |  |
| Selektor | `Soneta.Core.GIODO.SelektorPrzetwarzania` (enum) | bazodanowe, tylko-odczyt, selektor | Selektor przetwarzania |  |
| Zakonczenie | `Date` | bazodanowe | Data zakończenia przetwarzania |  |
| ZbiorDanych | `Soneta.Core.GIODO.GIODOZbiorDanych` | bazodanowe | Zbiór danych |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Selektor`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Czynnosc` | 1 | `Soneta.Core.GIODO.GIODOPrzetwarzanieCzynnosc` | Czynność przetwarzania |
| `KategoriaCzynnosci` | 2 | `Soneta.Core.GIODO.GIODOPrzetwarzanieKategoriaCzynnosc` | Kategoria czynności przetwarzania |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### SelektorPrzetwarzania (`Soneta.Core.GIODO.SelektorPrzetwarzania`)
- `Czynnosc` = 1
- `KategoriaCzynnosci` = 2
