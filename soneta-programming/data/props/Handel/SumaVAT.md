# Pola i właściwości klasy biznesowej: `Soneta.Handel.SumaVAT`
Nazwa tabeli: `SumyVAT`
Tytuł: Sumy VAT
Opis: Element szczegółowy dokumentu handlowego (DokumentHandlowy). Przechowuje kwoty netto, VAT i brutto w rozbiciu na poszczególne stawki VAT dla danego dokumentu.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dokument` → `DokumentHandlowy`

- pola bazodanowe: 16
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaStawki | `Soneta.Core.DefinicjaStawkiVat` | bazodanowe |  | Definicja stawki VAT |
| Dokument | `Soneta.Handel.DokumentHandlowy` | bazodanowe, guided-parent |  | Dokument, do którego przypisana jest stawka VAT |
| Stawka | `Soneta.Core.StawkaVat` | bazodanowe |  | Typ stawki VAT |
| Stawka.Kraj | `Soneta.Core.KrajTbl` | bazodanowe |  |  |
| Stawka.Obnizona | `bool` | bazodanowe |  |  |
| Stawka.Procent | `Soneta.Types.Percent` | bazodanowe |  |  |
| Stawka.Status | `Soneta.Core.StatusStawkiVat` | bazodanowe, enum |  |  |
| Stawka.WgKraj | `Soneta.Business.Key` |  |  |  |
| Stawka.WymagaSWW | `bool` |  |  |  |
| Stawka.Zrodlowa | `Soneta.Types.Percent` | bazodanowe |  |  |
| Suma | `Soneta.Handel.BruttoNetto` | bazodanowe |  | Kwoty netto, VAT i brutto. |
| Suma.Brutto | `decimal` | bazodanowe |  | Wartość brutto. |
| Suma.BruttoCy | `Soneta.Types.Currency` |  |  | Wartość brutto wyrażona w walucie. Zawsze PLN poza dokumentami 0%. |
| Suma.JestZero | `bool` |  |  |  |
| Suma.Netto | `decimal` | bazodanowe |  | Wartość netto. |
| Suma.NettoCy | `Soneta.Types.Currency` |  |  | Wartość netto wyrażona w walucie. Zawsze PLN poza dokumentami 0%. |
| Suma.VAT | `decimal` | bazodanowe |  | Kwota podatku VAT. |
| Suma.VATCy | `Soneta.Types.Currency` |  |  | Wartość podatku VAT wyrażona w walucie. Zawsze PLN poza dokumentami 0%. |
| SumaCy | `Soneta.Handel.BruttoNettoCy` | bazodanowe |  | Kwoty w walucie netto, VAT i brutto. |
| SumaCy.BruttoCy | `Soneta.Types.Currency` | bazodanowe |  | Kwota brutto. |
| SumaCy.NettoCy | `Soneta.Types.Currency` | bazodanowe |  | Kwota netto. |
| SumaCy.VatCy | `Soneta.Types.Currency` | bazodanowe |  | Kwota podatku VAT. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StatusStawkiVat (`Soneta.Core.StatusStawkiVat`)
- `Opodatkowana` = 0 — Opodatkowana
- `Zaniżona` = 1
- `Zwolniona` = 2
- `NiePodlega` = 3
- `Brak` = 4
