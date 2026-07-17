# Pola i właściwości klasy biznesowej: `Soneta.Place.DokumentRozliczeniaKontrahenta`
Nazwa tabeli: `DokumentyRozlKon`
Tytuł: Dokumenty rozliczenia kontrahenta
Opis: Dokument zbiorczego rozliczenia wynagrodzenia z kontrahentem zewnętrznym za określony okres. Grupuje rozliczenia poszczególnych pracowników i stanowi podstawę do wystawienia dokumentu ewidencji.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 11
- pola kalkulowane (z klas biznesowych): 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` | bazodanowe |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  |  |
| DokumentyEwidencji | `Soneta.Business.SubTable<Soneta.Place.RozliczenieDokKontrahenta>` |  |  |  |
| Kontrahent | `Soneta.CRM.Kontrahent` | bazodanowe |  |  |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| NumerPelny | `string` |  |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Rozliczenia | `Soneta.Business.SubTable<Soneta.Place.DokumentRozliczeniaPracownika>` |  |  |  |
| Seria | `string` | bazodanowe |  |  |
| WartoscCy | `Soneta.Types.Currency` | bazodanowe |  |  |
| Zatwierdzony | `bool` |  |  |  |
