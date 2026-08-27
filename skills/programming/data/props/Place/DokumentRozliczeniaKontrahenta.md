# Pola i właściwości klasy biznesowej: `Soneta.Place.DokumentRozliczeniaKontrahenta`
Nazwa tabeli: `DokumentyRozlKon`
Tytuł: Dokumenty rozliczenia kontrahenta
Opis: Dokument zbiorczego rozliczenia wynagrodzenia z kontrahentem zewnętrznym za określony okres. Grupuje rozliczenia poszczególnych pracowników i stanowi podstawę do wystawienia dokumentu ewidencji.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` | bazodanowe |  |  |
| Data | `Date` | bazodanowe |  |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  |  |
| DokumentyEwidencji | `SubTable<Soneta.Place.RozliczenieDokKontrahenta>` | podlista |  |  |
| Kontrahent | `Soneta.CRM.Kontrahent` | bazodanowe, tylko-odczyt |  |  |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Rozliczenia | `SubTable<Soneta.Place.DokumentRozliczeniaPracownika>` | podlista |  |  |
| Seria | `string` | bazodanowe |  |  |
| WartoscCy | `Currency` | bazodanowe, tylko-odczyt |  |  |
| Zatwierdzony | `bool` |  |  |  |
