# Pola i właściwości klasy biznesowej: `Soneta.RMK.DokumentRMK`
Nazwa tabeli: `DokumentyRMK`
Tytuł: Dokumenty RMK
Opis: Dokument rozliczeń międzyokresowych kosztów. Grupuje obroty RMK w ramach jednego dokumentu księgowego z numerem, datą dokumentu i datą operacji. Stanowi podstawę do generowania dekretów księgowych z tytułu rozliczeń międzyokresowych.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokumentKsiegowalny`

- pola bazodanowe (zapisywalne): 7
- pola kalkulowane (zapisywalne): 3
- pola tylko-odczyt: 10
- podlisty: 8
- subrowy: 1
- razem: 29

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` |  |  |  |
| BuforOpisuAnalitycznego | `bool` | bazodanowe |  | Bufor opisu analitycznego |
| DataDokumentu | `Date` | bazodanowe |  | Data dokumentu |
| DataOperacji | `Date` | bazodanowe |  | Data operacji |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  | Definicja dokumentu |
| DokumentyEwidencji | `SubTable<Soneta.Core.DokEwidencji>` | podlista |  |  |
| Ewidencja | `Soneta.Core.DokEwidencji` | tylko-odczyt |  |  |
| Firma | `Soneta.Core.OddzialFirmy` | tylko-odczyt |  |  |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  | Numer dokumentu |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| NumerProceduryISO | `string` | bazodanowe, tylko-odczyt |  | Numer procedury ISO |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  | Oddział firmy |
| OpisyAnalityczne | `ListWithView` | podlista |  |  |
| Pozycje | `SubTable<Soneta.RMK.ObrotRMK>` | podlista |  |  |
| PozycjeEwidencji | `SubTable<Soneta.Core.PozycjaEwidencjiZbiorczej>` | podlista |  |  |
| StanDokumentuPozwalaNaBuforowanieOA | `bool` | tylko-odczyt |  |  |
| StanDokumentuPozwalaNaZatwierdzenieOA | `bool` | tylko-odczyt |  |  |
| SymbolOkresuWgDatyDokumentu | `string` | tylko-odczyt |  |  |
| WgCentrowKosztow | `Soneta.RMK.DokumentRMK.DokumentRMKWgCentrumKosztow[]` | podlista |  |  |
| WgGrupKosztow | `Soneta.RMK.DokumentRMK.DokumentRMKWgGrupyKosztow[]` | podlista |  |  |
| WidokAktywny | `bool` | tylko-odczyt |  |  |
| Wielooddzialowosc | `bool` | tylko-odczyt |  |  |
| Zatwierdzony | `bool` |  |  |  |
| ZrodloTableName | `string` | tylko-odczyt |  |  |
