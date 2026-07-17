# Pola i właściwości klasy biznesowej: `Soneta.Core.DefinicjaStawkiVat`
Nazwa tabeli: `DefStawekVat`
Tytuł: Definicje stawek VAT
Opis: Słownik stawek podatku VAT. Każda definicja zawiera kod stawki, procent, status, informację o stawce obniżonej, powiązanie z krajem oraz opis. Używana przy wystawianiu dokumentów handlowych i ewidencji VAT.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Kod | `string` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| Podstawowa | `bool` |  |  |  |
| Stawka | `Soneta.Core.StawkaVat` | bazodanowe |  |  |
| Stawka.Kraj | `Soneta.Core.KrajTbl` | bazodanowe |  |  |
| Stawka.Obnizona | `bool` | bazodanowe |  |  |
| Stawka.Procent | `Soneta.Types.Percent` | bazodanowe |  |  |
| Stawka.Status | `Soneta.Core.StatusStawkiVat` | bazodanowe, enum |  |  |
| Stawka.WgKraj | `Soneta.Business.Key` |  |  |  |
| Stawka.WymagaSWW | `bool` |  |  |  |
| Stawka.Zrodlowa | `Soneta.Types.Percent` | bazodanowe |  |  |
| WgWielkosci | `decimal` |  |  |  |
| WymagaSWW | `bool` |  |  |  |
| Zablokowane | `bool` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StatusStawkiVat (`Soneta.Core.StatusStawkiVat`)
- `Opodatkowana` = 0 — Opodatkowana
- `Zaniżona` = 1
- `Zwolniona` = 2
- `NiePodlega` = 3
- `Brak` = 4
