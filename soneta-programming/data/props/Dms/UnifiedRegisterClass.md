# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Dms.Config.UnifiedRegisterClass`
Nazwa tabeli: `UnifiedRgClasses`
Tytuł: Klasy wykazów akt
Opis: Pozycja (klasa) w hierarchicznym wykazie akt, identyfikowana symbolem w ramach nadrzędnego wykazu. Określa kategorię archiwalną i może tworzyć wielopoziomową strukturę drzewiastą poprzez relację do klasy nadrzędnej. Służy do klasyfikacji spraw i dokumentów.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 10

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ArchiveCategory | `Soneta.Workflow.Dms.Config.ArchiveCategory` | bazodanowe | Kategoria archiwalna | Kategoria archiwalna klasy wykazu akt |
| ArchiveCategory.Category | `string` |  | Formatowana nazwa | Formatowana nazwa kategorii archiwalnej |
| ArchiveCategory.HasDictionary | `bool` |  | Określono słownik | Określono słownik kategorii |
| ArchiveCategory.ImportArchiveCategory | `string` |  |  |  |
| ArchiveCategory.Period | `int` | bazodanowe | Okres | Opcjonalny okres kategorii archiwalnej dokumentu |
| ArchiveCategory.Symbol | `Soneta.Ksiega.ElemSlownika` | bazodanowe | Symbol | Symbol kategorii archiwalnej dokumentu |
| ArchiveCategory.WgSymbol | `Soneta.Business.Key` |  |  |  |
| BasicDocuments | `Soneta.Business.SubTable<Soneta.Workflow.Dms.BasicDocument>` |  |  |  |
| ChildUnifiedRegisterClass | `Soneta.Business.SubTable<Soneta.Workflow.Dms.Config.UnifiedRegisterClass>` |  |  |  |
| Description | `Soneta.Business.MemoText` | bazodanowe | Opis | Opis klasy wykazu akt |
| Locked | `bool` | bazodanowe | Zablokowane | Klasa wykazu akt zablokowana |
| Matters | `Soneta.Business.SubTable<Soneta.Workflow.Dms.Matter>` |  |  |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa klasy wykazu akt |
| Parent | `Soneta.Workflow.Dms.Config.UnifiedRegisterClass` | bazodanowe | Klasa nadrzędna | Nadrzędna klasa wykazu akt |
| Path | `string` |  | Ścieżka |  |
| Symbol | `string` | bazodanowe | Symbol | Symbol klasy wykazu akt |
| TranslatedDescription | `string` |  |  |  |
| TranslatedName | `string` |  |  |  |
| UnifiedRegister | `Soneta.Workflow.Dms.Config.UnifiedRegister` | bazodanowe | Wykaz akt | Wykaz akt powiązany z klasą wykazu akt |
