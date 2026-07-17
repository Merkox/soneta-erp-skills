# Pola i właściwości klasy biznesowej: `Soneta.Handel.ElemRozliczenia`
Nazwa tabeli: `ElemyRozliczenia`
Tytuł: Elementy rozliczenia pozycji
Opis: Element szczegółowy pozycji dokumentu handlowego (PozycjaDokHandlowego). Reprezentuje pojedynczy element rozliczenia umowy cyklicznej: okres, ilość planowaną, zrealizowaną i rozliczoną.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pozycja` → `PozycjaDokHandlowego`

- pola bazodanowe: 13
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataDo | `Soneta.Types.Date` | bazodanowe |  | Data zakończenia trwania elementu. |
| DataOd | `Soneta.Types.Date` | bazodanowe |  | Data rozpoczęcia trwania elementu. |
| DataRealizacji | `Soneta.Types.Date` | bazodanowe |  | Data bieżącej realizacji. |
| DokumentRozliczajacy | `Soneta.Handel.DokumentHandlowy` | bazodanowe |  | Dokument rozliczający pozycję elementu. |
| IloscPlanowana | `Soneta.Towary.Quantity` | bazodanowe |  | Ilość planowana do rozliczenia w elemencie. |
| IloscRozliczona | `Soneta.Towary.Quantity` | bazodanowe |  | Ilość rozliczona w elemencie. |
| IloscZrealizowana | `Soneta.Towary.Quantity` | bazodanowe |  | Ilość zrealizowana w elemencie. |
| Okres | `Soneta.Types.FromTo` |  |  |  |
| PowodZawieszenia | `Soneta.Business.MemoText` | bazodanowe |  | Powód zawieszenia - opis słowny. |
| Pozycja | `Soneta.Handel.PozycjaDokHandlowego` | bazodanowe, guided-parent |  | Pozycja, której realizacja jest rozbita na elementy. |
| StanPoczatkowy | `Soneta.Towary.Quantity` | bazodanowe |  | Stan początkowy. |
| StanRozliczony | `Soneta.Towary.Quantity` | bazodanowe |  | Stan rozliczony. |
| StanZrealizowany | `Soneta.Towary.Quantity` | bazodanowe |  | Stan zrealizowany. |
| Typ | `Soneta.Handel.TypElementuRozliczenia` | bazodanowe, enum |  | Typ elementu. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypElementuRozliczenia (`Soneta.Handel.TypElementuRozliczenia`)
- `Planowanie` = 0 — Planowanie
- `Realizacja` = 1
- `Rozliczenie` = 2
- `Zawieszenie` = 3
