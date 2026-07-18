# Pola i właściwości klasy biznesowej: `Soneta.Handel.SumaVAT`
Nazwa tabeli: `SumyVAT`
Tytuł: Sumy VAT
Opis: Element szczegółowy dokumentu handlowego (DokumentHandlowy). Przechowuje kwoty netto, VAT i brutto w rozbiciu na poszczególne stawki VAT dla danego dokumentu.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dokument` → `DokumentHandlowy`

- pola bazodanowe (zapisywalne): 9
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 9
- podlisty: 1
- subrowy: 3
- razem: 22

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaStawki | `Soneta.Core.DefinicjaStawkiVat` | bazodanowe |  | Definicja stawki VAT |
| Dokument | `Soneta.Handel.DokumentHandlowy` | bazodanowe, tylko-odczyt, guided-parent |  | Dokument, do którego przypisana jest stawka VAT |
| Stawka | `Soneta.Core.StawkaVat` (subrow) | bazodanowe |  | Typ stawki VAT |
| Stawka.Kraj | `Soneta.Core.KrajTbl` | bazodanowe |  |  |
| Stawka.Obnizona | `bool` | bazodanowe |  |  |
| Stawka.Procent | `Percent` | bazodanowe |  |  |
| Stawka.Status | `Soneta.Core.StatusStawkiVat` (enum) | bazodanowe |  |  |
| Stawka.WgKraj | `Key` | podlista |  |  |
| Stawka.WymagaSWW | `bool` | tylko-odczyt |  |  |
| Stawka.Zrodlowa | `Percent` | bazodanowe |  |  |
| Suma | `Soneta.Handel.BruttoNetto` (subrow) | bazodanowe |  | Kwoty netto, VAT i brutto. |
| Suma.Brutto | `decimal` | bazodanowe |  | Wartość brutto. |
| Suma.BruttoCy | `Currency` | tylko-odczyt |  | Wartość brutto wyrażona w walucie. Zawsze PLN poza dokumentami 0%. |
| Suma.JestZero | `bool` | tylko-odczyt |  |  |
| Suma.Netto | `decimal` | bazodanowe |  | Wartość netto. |
| Suma.NettoCy | `Currency` | tylko-odczyt |  | Wartość netto wyrażona w walucie. Zawsze PLN poza dokumentami 0%. |
| Suma.VAT | `decimal` | bazodanowe |  | Kwota podatku VAT. |
| Suma.VATCy | `Currency` | tylko-odczyt |  | Wartość podatku VAT wyrażona w walucie. Zawsze PLN poza dokumentami 0%. |
| SumaCy | `Soneta.Handel.BruttoNettoCy` (subrow) | bazodanowe |  | Kwoty w walucie netto, VAT i brutto. |
| SumaCy.BruttoCy | `Currency` | bazodanowe, tylko-odczyt |  | Kwota brutto. |
| SumaCy.NettoCy | `Currency` | bazodanowe, tylko-odczyt |  | Kwota netto. |
| SumaCy.VatCy | `Currency` | bazodanowe, tylko-odczyt |  | Kwota podatku VAT. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StatusStawkiVat (`Soneta.Core.StatusStawkiVat`)
- `Opodatkowana` = 0 — Opodatkowana
- `Zaniżona` = 1
- `Zwolniona` = 2
- `NiePodlega` = 3
- `Brak` = 4
