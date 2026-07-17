# Pola i właściwości klasy biznesowej: `Soneta.Samochodowka.RozliczenieEP`
Nazwa tabeli: `RozliczeniaEP`
Tytuł: Rozliczenia
Opis: Dokument rozliczenia ewidencji przebiegu pojazdu za dany okres. Agreguje wartości przejazdów i kosztów eksploatacyjnych, wyliczając kwotę do rozliczenia z korektą. Stanowi podstawę księgowania kosztów używania pojazdów w module księgowym.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokumentKsiegowalny`

- pola bazodanowe: 10
- pola kalkulowane (z klas biznesowych): 13

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` |  |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  | Data dokumentu rozliczenia |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  | Definicja dokumentu rozliczenia |
| DoRozliczenia | `decimal` | bazodanowe |  | Do rozliczenia |
| DoRozliczeniaOldValue | `decimal` |  |  |  |
| DokumentyEwidencji | `Soneta.Business.SubTable<Soneta.Core.DokEwidencji>` |  |  |  |
| Ewidencja | `Soneta.Core.DokEwidencji` |  |  |  |
| KorektaKosztow | `decimal` | bazodanowe |  | Korekta kosztów |
| KorektaKosztowOldValue | `decimal` |  |  |  |
| Koszty | `Soneta.Business.SubTable<Soneta.Samochodowka.KosztEP>` |  |  |  |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  | Numer dokumentu |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| PozycjeEwidencji | `Soneta.Business.SubTable<Soneta.Core.PozycjaEwidencjiZbiorczej>` |  |  |  |
| Przejazdy | `Soneta.Business.SubTable<Soneta.Samochodowka.Przejazd>` |  |  |  |
| RozliczeniaPojazdow | `Soneta.Samochodowka.RozliczenieEPPojazdu[]` |  |  |  |
| WartoscKosztow | `decimal` | bazodanowe |  | Wartość kosztów |
| WartoscPrzejazdow | `decimal` | bazodanowe |  | Wartość przejazdów |
| Zatwierdzony | `bool` |  |  |  |
