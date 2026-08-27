# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Dms.Config.UnifiedRegisterClass`
Nazwa tabeli: `UnifiedRgClasses`
Tytuł: Klasy wykazów akt
Opis: Pozycja (klasa) w hierarchicznym wykazie akt, identyfikowana symbolem w ramach nadrzędnego wykazu. Określa kategorię archiwalną i może tworzyć wielopoziomową strukturę drzewiastą poprzez relację do klasy nadrzędnej. Służy do klasyfikacji spraw i dokumentów.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ArchiveCategory | `Soneta.Workflow.Dms.Config.ArchiveCategory` (subrow) | bazodanowe | Kategoria archiwalna | Kategoria archiwalna klasy wykazu akt |
| ArchiveCategory.Category | `string` | tylko-odczyt | Formatowana nazwa | Formatowana nazwa kategorii archiwalnej |
| ArchiveCategory.HasDictionary | `bool` | tylko-odczyt | Określono słownik | Określono słownik kategorii |
| ArchiveCategory.ImportArchiveCategory | `string` |  |  |  |
| ArchiveCategory.Period | `int` | bazodanowe | Okres | Opcjonalny okres kategorii archiwalnej dokumentu |
| ArchiveCategory.Symbol | `Soneta.Ksiega.ElemSlownika` | bazodanowe | Symbol | Symbol kategorii archiwalnej dokumentu |
| ArchiveCategory.WgSymbol | `Key` | podlista |  |  |
| BasicDocuments | `SubTable<Soneta.Workflow.Dms.BasicDocument>` | podlista |  |  |
| ChildUnifiedRegisterClass | `SubTable<Soneta.Workflow.Dms.Config.UnifiedRegisterClass>` | podlista |  |  |
| Description | `MemoText` | bazodanowe, podlista | Opis | Opis klasy wykazu akt |
| Locked | `bool` | bazodanowe | Zablokowane | Klasa wykazu akt zablokowana |
| Matters | `SubTable<Soneta.Workflow.Dms.Matter>` | podlista |  |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa klasy wykazu akt |
| Parent | `Soneta.Workflow.Dms.Config.UnifiedRegisterClass` | bazodanowe | Klasa nadrzędna | Nadrzędna klasa wykazu akt |
| Path | `string` | tylko-odczyt | Ścieżka |  |
| Symbol | `string` | bazodanowe | Symbol | Symbol klasy wykazu akt |
| TranslatedDescription | `string` | tylko-odczyt |  |  |
| TranslatedName | `string` | tylko-odczyt |  |  |
| UnifiedRegister | `Soneta.Workflow.Dms.Config.UnifiedRegister` | bazodanowe, tylko-odczyt | Wykaz akt | Wykaz akt powiązany z klasą wykazu akt |
