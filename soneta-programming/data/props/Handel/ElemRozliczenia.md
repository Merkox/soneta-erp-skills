# Pola i właściwości klasy biznesowej: `Soneta.Handel.ElemRozliczenia`
Nazwa tabeli: `ElemyRozliczenia`
Tytuł: Elementy rozliczenia pozycji
Opis: Element szczegółowy pozycji dokumentu handlowego (PozycjaDokHandlowego). Reprezentuje pojedynczy element rozliczenia umowy cyklicznej: okres, ilość planowaną, zrealizowaną i rozliczoną.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pozycja` → `PozycjaDokHandlowego`

- pola bazodanowe (zapisywalne): 11
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 2
- subrowy: 0
- razem: 14

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataDo | `Date` | bazodanowe |  | Data zakończenia trwania elementu. |
| DataOd | `Date` | bazodanowe |  | Data rozpoczęcia trwania elementu. |
| DataRealizacji | `Date` | bazodanowe |  | Data bieżącej realizacji. |
| DokumentRozliczajacy | `Soneta.Handel.DokumentHandlowy` | bazodanowe |  | Dokument rozliczający pozycję elementu. |
| IloscPlanowana | `Soneta.Towary.Quantity` | bazodanowe |  | Ilość planowana do rozliczenia w elemencie. |
| IloscRozliczona | `Soneta.Towary.Quantity` | bazodanowe |  | Ilość rozliczona w elemencie. |
| IloscZrealizowana | `Soneta.Towary.Quantity` | bazodanowe |  | Ilość zrealizowana w elemencie. |
| Okres | `FromTo` | podlista |  |  |
| PowodZawieszenia | `MemoText` | bazodanowe, podlista |  | Powód zawieszenia - opis słowny. |
| Pozycja | `Soneta.Handel.PozycjaDokHandlowego` | bazodanowe, tylko-odczyt, guided-parent |  | Pozycja, której realizacja jest rozbita na elementy. |
| StanPoczatkowy | `Soneta.Towary.Quantity` | bazodanowe |  | Stan początkowy. |
| StanRozliczony | `Soneta.Towary.Quantity` | bazodanowe |  | Stan rozliczony. |
| StanZrealizowany | `Soneta.Towary.Quantity` | bazodanowe |  | Stan zrealizowany. |
| Typ | `Soneta.Handel.TypElementuRozliczenia` (enum) | bazodanowe |  | Typ elementu. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypElementuRozliczenia (`Soneta.Handel.TypElementuRozliczenia`)
- `Planowanie` = 0 — Planowanie
- `Realizacja` = 1
- `Rozliczenie` = 2
- `Zawieszenie` = 3
