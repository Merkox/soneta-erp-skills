# Pola i właściwości klasy biznesowej: `Soneta.Kasa.RaportESP`
Nazwa tabeli: `RaportyESP`
Tytuł: Raport ESP
Opis: Raport ewidencji środków pieniężnych (kasowy lub bankowy) za określony okres. Agreguje wpłaty, wypłaty i salda w ramach ewidencji, stanowiąc podstawę do zamknięcia okresu kasowego i księgowania zbiorczego operacji gotówkowych lub bankowych.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokumentKsiegowalny`, `IRaportEwidencjiSP`

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 3
- pola tylko-odczyt: 20
- podlisty: 8
- subrowy: 1
- razem: 37

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` | bazodanowe |  |  |
| BuforOpisuAnalitycznego | `bool` | bazodanowe |  | Bufor opisu analitycznego |
| Data | `Date` | tylko-odczyt |  |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | tylko-odczyt |  |  |
| Dokumenty | `SubTable<Soneta.Kasa.DokKasowyBase>` | podlista |  |  |
| DokumentyEwidencji | `SubTable<Soneta.Core.DokEwidencji>` | podlista |  |  |
| Ewidencja | `Soneta.Core.DokEwidencji` | tylko-odczyt |  |  |
| Firma | `Soneta.Core.OddzialFirmy` | tylko-odczyt |  |  |
| GotowkaKoncowe | `Currency` | tylko-odczyt |  |  |
| GotowkaPoczatkowe | `Currency` | bazodanowe, tylko-odczyt |  |  |
| GotowkaWplaty | `Currency` | bazodanowe, tylko-odczyt |  |  |
| GotowkaWyplaty | `Currency` | bazodanowe, tylko-odczyt |  |  |
| Kasa | `Soneta.Kasa.EwidencjaSP` | bazodanowe, tylko-odczyt |  |  |
| Nazwa | `string` | tylko-odczyt |  |  |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| NumerDzienny | `int` | bazodanowe |  |  |
| NumerRaportu | `string` | tylko-odczyt |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | tylko-odczyt |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| OkresDzien | `Date` |  |  |  |
| OperacjeBankowe | `LpSubTable<Soneta.Kasa.OperacjaBankowa>` | podlista |  |  |
| PozycjeEwidencji | `SubTable<Soneta.Core.PozycjaEwidencjiZbiorczej>` | podlista |  |  |
| RodzajRaportu | `Soneta.Kasa.RodzajRaportuESP` (enum) | bazodanowe, tylko-odczyt |  |  |
| SaldoKoncowe | `Currency` | tylko-odczyt |  |  |
| SaldoPoczatkowe | `Currency` | bazodanowe, tylko-odczyt |  |  |
| SymbolOkresuWgDatyDokumentu | `string` | tylko-odczyt |  |  |
| Wplaty | `Currency` | bazodanowe, tylko-odczyt |  |  |
| Wyplaty | `Currency` | bazodanowe, tylko-odczyt |  |  |
| ZaimportowaneFragmenty | `string` | bazodanowe, tylko-odczyt |  |  |
| Zamknięty | `bool` |  |  |  |
| Zaplaty | `LpSubTable<Soneta.Kasa.Zaplata>` | podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajRaportuESP (`Soneta.Kasa.RodzajRaportuESP`)
- `Okresowy` = 1 — Okresowy (standard)
- `DziennyMulti` = 2 — Dzienny (multi)
