# Pola i właściwości klasy biznesowej: `Soneta.Core.DefinicjaStawkiVat`
Nazwa tabeli: `DefStawekVat`
Tytuł: Definicje stawek VAT
Opis: Słownik stawek podatku VAT. Każda definicja zawiera kod stawki, procent, status, informację o stawce obniżonej, powiązanie z krajem oraz opis. Używana przy wystawianiu dokumentów handlowych i ewidencji VAT.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Kod | `string` | bazodanowe, tylko-odczyt |  |  |
| Opis | `string` | bazodanowe |  |  |
| Podstawowa | `bool` | tylko-odczyt |  |  |
| Stawka | `Soneta.Core.StawkaVat` (subrow) | bazodanowe |  |  |
| Stawka.Kraj | `Soneta.Core.KrajTbl` | bazodanowe |  |  |
| Stawka.Obnizona | `bool` | bazodanowe |  |  |
| Stawka.Procent | `Percent` | bazodanowe |  |  |
| Stawka.Status | `Soneta.Core.StatusStawkiVat` (enum) | bazodanowe |  |  |
| Stawka.WgKraj | `Key` | podlista |  |  |
| Stawka.WymagaSWW | `bool` | tylko-odczyt |  |  |
| Stawka.Zrodlowa | `Percent` | bazodanowe |  |  |
| WgWielkosci | `decimal` | tylko-odczyt |  |  |
| WymagaSWW | `bool` | tylko-odczyt |  |  |
| Zablokowane | `bool` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StatusStawkiVat (`Soneta.Core.StatusStawkiVat`)
- `Opodatkowana` = 0 — Opodatkowana
- `Zaniżona` = 1
- `Zwolniona` = 2
- `NiePodlega` = 3
- `Brak` = 4
