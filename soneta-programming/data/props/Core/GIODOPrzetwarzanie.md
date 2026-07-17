# Pola i właściwości klasy biznesowej: `Soneta.Core.GIODO.GIODOPrzetwarzanie`
Nazwa tabeli: `GIODOPrzetwarz`
Tytuł: Czynności przetwarzania
Opis: Czynność przetwarzania danych osobowych w ramach zbioru danych RODO. Dokumentuje nazwę czynności, numer, zakres przetwarzania, daty rozpoczęcia i zakończenia oraz planowany termin zakończenia.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 11
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa czynności | Nazwa czynności przetwarzania |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` |  |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe | Opis, zakres przetwarzania |  |
| PlanZakonczenia | `string` | bazodanowe | Plan zakończenia | Plan zakończenia przetwarzania |
| Rozpoczecie | `Soneta.Types.Date` | bazodanowe | Data rozpoczęcia przetwarzania |  |
| Selektor | `Soneta.Core.GIODO.SelektorPrzetwarzania` | bazodanowe, enum | Selektor przetwarzania |  |
| Zakonczenie | `Soneta.Types.Date` | bazodanowe | Data zakończenia przetwarzania |  |
| ZbiorDanych | `Soneta.Core.GIODO.GIODOZbiorDanych` | bazodanowe | Zbiór danych |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### SelektorPrzetwarzania (`Soneta.Core.GIODO.SelektorPrzetwarzania`)
- `Czynnosc` = 1
- `KategoriaCzynnosci` = 2
