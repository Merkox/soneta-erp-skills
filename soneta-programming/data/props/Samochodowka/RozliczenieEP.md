# Pola i właściwości klasy biznesowej: `Soneta.Samochodowka.RozliczenieEP`
Nazwa tabeli: `RozliczeniaEP`
Tytuł: Rozliczenia
Opis: Dokument rozliczenia ewidencji przebiegu pojazdu za dany okres. Agreguje wartości przejazdów i kosztów eksploatacyjnych, wyliczając kwotę do rozliczenia z korektą. Stanowi podstawę księgowania kosztów używania pojazdów w module księgowym.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokumentKsiegowalny`

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 3
- pola tylko-odczyt: 6
- podlisty: 7
- subrowy: 1
- razem: 21

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` |  |  |  |
| Data | `Date` | bazodanowe |  | Data dokumentu rozliczenia |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  | Definicja dokumentu rozliczenia |
| DoRozliczenia | `decimal` | bazodanowe, tylko-odczyt |  | Do rozliczenia |
| DokumentyEwidencji | `SubTable<Soneta.Core.DokEwidencji>` | podlista |  |  |
| Ewidencja | `Soneta.Core.DokEwidencji` | tylko-odczyt |  |  |
| KorektaKosztow | `decimal` | bazodanowe, tylko-odczyt |  | Korekta kosztów |
| Koszty | `SubTable<Soneta.Samochodowka.KosztEP>` | podlista |  |  |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  | Numer dokumentu |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| PozycjeEwidencji | `SubTable<Soneta.Core.PozycjaEwidencjiZbiorczej>` | podlista |  |  |
| Przejazdy | `SubTable<Soneta.Samochodowka.Przejazd>` | podlista |  |  |
| RozliczeniaPojazdow | `Soneta.Samochodowka.RozliczenieEPPojazdu[]` | podlista |  |  |
| WartoscKosztow | `decimal` | bazodanowe, tylko-odczyt |  | Wartość kosztów |
| WartoscPrzejazdow | `decimal` | bazodanowe, tylko-odczyt |  | Wartość przejazdów |
| Zatwierdzony | `bool` |  |  |  |
