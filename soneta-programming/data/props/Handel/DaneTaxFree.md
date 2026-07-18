# Pola i właściwości klasy biznesowej: `Soneta.Handel.DaneTaxFree`
Nazwa tabeli: `DaneDokTaxFree`
Tytuł: Dane dokumentów Tax Free
Opis: Dane Tax Free powiązane z dokumentem handlowym. Zawiera informacje o podróżnym (imię, nazwisko, paszport), numer UNS, formę zwrotu podatku VAT oraz status dokumentu.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataCzasNrUNS | `System.DateTime` | bazodanowe | Data i czas nadania numeru UNS |  |
| Dokument | `Soneta.Handel.DokumentHandlowy` | bazodanowe, tylko-odczyt | Dokument handlowy |  |
| FormaZwrotuPodatku | `Soneta.Handel.FormaZwrotuPodatkuVAT` (enum) | bazodanowe | Forma zwrotu podatku |  |
| KasjerImie | `string` | bazodanowe | Imię kasjera |  |
| KasjerNazwisko | `string` | bazodanowe | Nazwisko kasjera |  |
| NrParagonu | `string` | bazodanowe | Numer paragonu |  |
| NrUNS | `string` | bazodanowe | Numer UNS |  |
| PodmiotPosredniczacy | `Soneta.CRM.Kontrahent` | bazodanowe | Podmiot pośredniczący |  |
| PodroznyDataUrodzenia | `Date` | bazodanowe | Data urodzenia podróżnego |  |
| PodroznyImie | `string` | bazodanowe | Imię podróżnego |  |
| PodroznyKrajPaszportu | `Soneta.Core.KrajTbl` | bazodanowe | Kraj paszportu podróżnego |  |
| PodroznyNazwisko | `string` | bazodanowe | Nazwisko podróżnego |  |
| PodroznyNrPaszportu | `string` | bazodanowe | Numer paszportu podróżengo |  |
| PodroznyNrRachunku | `string` | bazodanowe | Numer rachunku podróżnego |  |
| StatusDokumentu | `Soneta.Handel.TaxFreeStatus` (enum) | bazodanowe | Status |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### FormaZwrotuPodatkuVAT (`Soneta.Handel.FormaZwrotuPodatkuVAT`)
- `Gotowkowa` = 0 — Gotówkowa
- `Bezgotowkowa` = 1 — Bezgotówkowa

### TaxFreeStatus (`Soneta.Handel.TaxFreeStatus`)
- `None` = 0
- `Wprowadzony` = 1 — Wprowadzony
- `Uniewazniony` = 2 — Unieważniony
- `PotwierdzonyWywoz` = 3 — Potwierdzony wywóz
- `PotwierdzonyCzesciowyWywoz` = 4 — Potwierdzony częściowy wywóz
- `BrakPotwierdzeniaWywozu` = 5 — Brak potwierdzenia wywozu
- `RozliczonyZPodroznym` = 6 — Rozliczony z podróżnym
- `Zamkniety` = 7 — Zamknięty
