# Pola i właściwości klasy biznesowej: `Soneta.Core.AdditionRowDesc`
Nazwa tabeli: `AdditionRowDescs`
Tytuł: Dodatkowe informacje
Opis: Tabela przechowuje dodatkowe opisy i adnotacje dołączane do wierszy innych obiektów biznesowych. Umożliwia rejestrowanie komentarzy, nagłówków kategorii, znaczników czasu oraz informacji o autorze wpisu.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AdditionalDescriptionSource | `Soneta.Core.IAdditionalDescriptionSender` | bazodanowe | Źródło dodatkowej informacji |  |
| CreatedByWebUserKBN | `bool` | bazodanowe | Czy utworzył WebUserKBN |  |
| DateTime | `System.DateTime` | bazodanowe | Znacznik czasu |  |
| Description | `Soneta.Business.MemoText` | bazodanowe | Treść opisowa |  |
| DescriptionItem | `Soneta.Core.IAdditionalDescriptionReceiver` | bazodanowe |  |  |
| Header | `Soneta.Core.AdditionalDescriptionTitle` | bazodanowe, enum | Wartość identyfikująca typ lub kategorię opisu |  |
| OperatorName | `string` | bazodanowe | Nazwa operatora |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AdditionalDescriptionTitle (`Soneta.Core.AdditionalDescriptionTitle`)
- `Unknown` = 0 — Nieznane
- `OCR` = 1
- `DocPkg` = 2 — Paczka dokumentów
- `KSeF` = 3
- `WMS` = 4
