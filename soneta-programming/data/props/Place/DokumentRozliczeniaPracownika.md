# Pola i właściwości klasy biznesowej: `Soneta.Place.DokumentRozliczeniaPracownika`
Nazwa tabeli: `DokumentyRozlPra`
Tytuł: Rozliczenia pracownika
Opis: Element szczegółowy dokumentu rozliczenia kontrahenta (DokumentRozliczeniaKontrahenta). Reprezentuje rozliczenie wynagrodzenia konkretnego pracownika w ramach umowy zewnętrznej za dany okres.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 13
- pola kalkulowane (z klas biznesowych): 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BaseOkres | `Soneta.Types.FromTo` |  |  |  |
| BaseUmowa | `Soneta.Kadry.UmowaZewnetrzna` |  |  |  |
| Bufor | `bool` | bazodanowe |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  |  |
| Dokument | `Soneta.Place.DokumentRozliczeniaKontrahenta` | bazodanowe |  |  |
| Elementy | `Soneta.Business.SubTable<Soneta.Place.ElementRozliczeniaPracownika>` |  |  |  |
| Lp | `int` | bazodanowe |  |  |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| NumerPelny | `string` |  |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Umowa | `Soneta.Kadry.UmowaZewnetrzna` | bazodanowe |  |  |
| WartoscCy | `Soneta.Types.Currency` | bazodanowe |  |  |
| Zatwierdzony | `bool` |  |  |  |
