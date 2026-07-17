# Pola i właściwości klasy biznesowej: `Soneta.RMK.DokumentRMK`
Nazwa tabeli: `DokumentyRMK`
Tytuł: Dokumenty RMK
Opis: Dokument rozliczeń międzyokresowych kosztów. Grupuje obroty RMK w ramach jednego dokumentu księgowego z numerem, datą dokumentu i datą operacji. Stanowi podstawę do generowania dekretów księgowych z tytułu rozliczeń międzyokresowych.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokumentKsiegowalny`

- pola bazodanowe: 10
- pola kalkulowane (z klas biznesowych): 19

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` |  |  |  |
| BuforOpisuAnalitycznego | `bool` | bazodanowe |  | Bufor opisu analitycznego |
| DataDokumentu | `Soneta.Types.Date` | bazodanowe |  | Data dokumentu |
| DataOperacji | `Soneta.Types.Date` | bazodanowe |  | Data operacji |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  | Definicja dokumentu |
| DokumentyEwidencji | `Soneta.Business.SubTable<Soneta.Core.DokEwidencji>` |  |  |  |
| Ewidencja | `Soneta.Core.DokEwidencji` |  |  |  |
| Firma | `Soneta.Core.OddzialFirmy` |  |  |  |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  | Numer dokumentu |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| NumerProceduryISO | `string` | bazodanowe |  | Numer procedury ISO |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  | Oddział firmy |
| OpisyAnalityczne | `Soneta.Business.ListWithView` |  |  |  |
| Pozycje | `Soneta.Business.SubTable<Soneta.RMK.ObrotRMK>` |  |  |  |
| PozycjeEwidencji | `Soneta.Business.SubTable<Soneta.Core.PozycjaEwidencjiZbiorczej>` |  |  |  |
| StanDokumentuPozwalaNaBuforowanieOA | `bool` |  |  |  |
| StanDokumentuPozwalaNaZatwierdzenieOA | `bool` |  |  |  |
| SymbolOkresuWgDatyDokumentu | `string` |  |  |  |
| WgCentrowKosztow | `Soneta.RMK.DokumentRMK.DokumentRMKWgCentrumKosztow[]` |  |  |  |
| WgGrupKosztow | `Soneta.RMK.DokumentRMK.DokumentRMKWgGrupyKosztow[]` |  |  |  |
| WidokAktywny | `bool` |  |  |  |
| Wielooddzialowosc | `bool` |  |  |  |
| Zatwierdzony | `bool` |  |  |  |
| ZrodloTableName | `string` |  |  |  |
