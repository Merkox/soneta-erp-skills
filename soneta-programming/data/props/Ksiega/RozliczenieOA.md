# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.RozliczenieOA`
Nazwa tabeli: `RozliczeniaOA`
Tytuł: Rozliczenie opisu analitycznego
Opis: Rozliczenie opisu analitycznego wiąże element rozliczany z elementem rozliczającym w ramach kontroli budżetowej. Śledzi kwoty, ilości i daty rozliczeń, obsługuje powiązanie z rozliczeniami środków pieniężnych oraz kontrolę przekroczeń budżetu.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 10
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe | Data rozliczenia | Data rozliczenia |
| Ilosc | `Soneta.Types.Amount` | bazodanowe |  | Ilosc rozliczana |
| KategoriaBudzetowa | `Soneta.Core.IBudgetCategoryDefinition` | bazodanowe |  | Kategoria budżetu |
| Kwota | `Soneta.Types.Currency` | bazodanowe |  | Kwota rozliczana |
| KwotaDodatkowa | `Soneta.Types.Currency` | bazodanowe |  | Dodatkowa kwota rozliczana |
| RodzajRozliczenia | `Soneta.Core.SettlementOAKind` | bazodanowe, enum |  | Rodzaj rozliczenia |
| Rozliczajacy | `Soneta.Ksiega.ElemOpisuAnalitycznego` | bazodanowe | Element rozliczający | Rozliczający element opisu analitycznego. |
| Rozliczany | `Soneta.Ksiega.ElemOpisuAnalitycznego` | bazodanowe | Element rozliczany | Rozliczany element opisu analityczneg. |
| RozliczenieSP | `Soneta.Kasa.RozliczenieSP` | bazodanowe | Rozliczenie środków pieniężnych | Rozliczenie środków pieniężnych. |
| TypRozliczenia | `Soneta.Core.SettlementOAType` | bazodanowe, enum |  | Typ rozliczenia |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### SettlementOAKind (`Soneta.Core.SettlementOAKind`)
- `None` = 0 — Brak
- `Relation` = 1 — Powiązanie
- `Main` = 2 — Główne
- `Additional` = 4 — Dodatkowe
- `MainWithAdditional` = 6 — Główne i Dodatkowe

### SettlementOAType (`Soneta.Core.SettlementOAType`)
- `None` = 0 — Brak
- `Settlement` = 1 — Rozliczenie
- `CorrectionSettlement` = 2 — Rozliczenie korygujące
- `CorrectionWithRestrictions` = 3 — Korekta z obostrzeniami
- `CorrectionWithoutRestrictions` = 4 — Korekta bez obostrzeń
- `AutoSettlement` = 5 — Autorozliczenie
