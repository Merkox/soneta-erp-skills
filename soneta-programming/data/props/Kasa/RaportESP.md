# Pola i właściwości klasy biznesowej: `Soneta.Kasa.RaportESP`
Nazwa tabeli: `RaportyESP`
Tytuł: Raport ESP
Opis: Raport ewidencji środków pieniężnych (kasowy lub bankowy) za określony okres. Agreguje wpłaty, wypłaty i salda w ramach ewidencji, stanowiąc podstawę do zamknięcia okresu kasowego i księgowania zbiorczego operacji gotówkowych lub bankowych.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokumentKsiegowalny`, `IRaportEwidencjiSP`

- pola bazodanowe: 17
- pola kalkulowane (z klas biznesowych): 20

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` | bazodanowe |  |  |
| BuforOpisuAnalitycznego | `bool` | bazodanowe |  | Bufor opisu analitycznego |
| Data | `Soneta.Types.Date` |  |  |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` |  |  |  |
| Dokumenty | `Soneta.Business.SubTable<Soneta.Kasa.DokKasowyBase>` |  |  |  |
| DokumentyEwidencji | `Soneta.Business.SubTable<Soneta.Core.DokEwidencji>` |  |  |  |
| Ewidencja | `Soneta.Core.DokEwidencji` |  |  |  |
| Firma | `Soneta.Core.OddzialFirmy` |  |  |  |
| GotowkaKoncowe | `Soneta.Types.Currency` |  |  |  |
| GotowkaPoczatkowe | `Soneta.Types.Currency` | bazodanowe |  |  |
| GotowkaWplaty | `Soneta.Types.Currency` | bazodanowe |  |  |
| GotowkaWyplaty | `Soneta.Types.Currency` | bazodanowe |  |  |
| Kasa | `Soneta.Kasa.EwidencjaSP` | bazodanowe |  |  |
| Nazwa | `string` |  |  |  |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| NumerDzienny | `int` | bazodanowe |  |  |
| NumerRaportu | `string` |  |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` |  |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| OkresDzien | `Soneta.Types.Date` |  |  |  |
| OperacjeBankowe | `Soneta.Business.LpSubTable<Soneta.Kasa.OperacjaBankowa>` |  |  |  |
| PozycjeEwidencji | `Soneta.Business.SubTable<Soneta.Core.PozycjaEwidencjiZbiorczej>` |  |  |  |
| RodzajRaportu | `Soneta.Kasa.RodzajRaportuESP` | bazodanowe, enum |  |  |
| SaldoKoncowe | `Soneta.Types.Currency` |  |  |  |
| SaldoPoczatkowe | `Soneta.Types.Currency` | bazodanowe |  |  |
| SymbolOkresuWgDatyDokumentu | `string` |  |  |  |
| Wplaty | `Soneta.Types.Currency` | bazodanowe |  |  |
| Wyplaty | `Soneta.Types.Currency` | bazodanowe |  |  |
| ZaimportowaneFragmenty | `string` | bazodanowe |  |  |
| Zamknięty | `bool` |  |  |  |
| Zaplaty | `Soneta.Business.LpSubTable<Soneta.Kasa.Zaplata>` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajRaportuESP (`Soneta.Kasa.RodzajRaportuESP`)
- `Okresowy` = 1 — Okresowy (standard)
- `DziennyMulti` = 2 — Dzienny (multi)
