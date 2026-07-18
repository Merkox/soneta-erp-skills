# Pola i właściwości klasy biznesowej: `Soneta.Place.DokumentRozliczeniaPracownika`
Nazwa tabeli: `DokumentyRozlPra`
Tytuł: Rozliczenia pracownika
Opis: Element szczegółowy dokumentu rozliczenia kontrahenta (DokumentRozliczeniaKontrahenta). Reprezentuje rozliczenie wynagrodzenia konkretnego pracownika w ramach umowy zewnętrznej za dany okres.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BaseOkres | `FromTo` | podlista |  |  |
| BaseUmowa | `Soneta.Kadry.UmowaZewnetrzna` |  |  |  |
| Bufor | `bool` | bazodanowe |  |  |
| Data | `Date` | bazodanowe |  |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  |  |
| Dokument | `Soneta.Place.DokumentRozliczeniaKontrahenta` | bazodanowe, tylko-odczyt |  |  |
| Elementy | `SubTable<Soneta.Place.ElementRozliczeniaPracownika>` | podlista |  |  |
| Lp | `int` | bazodanowe |  |  |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| Umowa | `Soneta.Kadry.UmowaZewnetrzna` | bazodanowe |  |  |
| WartoscCy | `Currency` | bazodanowe, tylko-odczyt |  |  |
| Zatwierdzony | `bool` |  |  |  |
