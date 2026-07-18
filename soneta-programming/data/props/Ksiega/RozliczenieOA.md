# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.RozliczenieOA`
Nazwa tabeli: `RozliczeniaOA`
Tytuł: Rozliczenie opisu analitycznego
Opis: Rozliczenie opisu analitycznego wiąże element rozliczany z elementem rozliczającym w ramach kontroli budżetowej. Śledzi kwoty, ilości i daty rozliczeń, obsługuje powiązanie z rozliczeniami środków pieniężnych oraz kontrolę przekroczeń budżetu.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe | Data rozliczenia | Data rozliczenia |
| Ilosc | `Amount` | bazodanowe |  | Ilosc rozliczana |
| KategoriaBudzetowa | `Soneta.Core.IBudgetCategoryDefinition` | bazodanowe, tylko-odczyt |  | Kategoria budżetu |
| Kwota | `Currency` | bazodanowe |  | Kwota rozliczana |
| KwotaDodatkowa | `Currency` | bazodanowe |  | Dodatkowa kwota rozliczana |
| RodzajRozliczenia | `Soneta.Core.SettlementOAKind` (enum) | bazodanowe, tylko-odczyt |  | Rodzaj rozliczenia |
| Rozliczajacy | `Soneta.Ksiega.ElemOpisuAnalitycznego` | bazodanowe, tylko-odczyt | Element rozliczający | Rozliczający element opisu analitycznego. |
| Rozliczany | `Soneta.Ksiega.ElemOpisuAnalitycznego` | bazodanowe, tylko-odczyt | Element rozliczany | Rozliczany element opisu analityczneg. |
| RozliczenieSP | `Soneta.Kasa.RozliczenieSP` | bazodanowe | Rozliczenie środków pieniężnych | Rozliczenie środków pieniężnych. |
| TypRozliczenia | `Soneta.Core.SettlementOAType` (enum) | bazodanowe, tylko-odczyt |  | Typ rozliczenia |

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
