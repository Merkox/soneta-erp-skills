# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Dms.Matter`
Nazwa tabeli: `Matters`
Tytuł: Sprawy
Opis: Sprawa w systemie DMS grupująca powiązane dokumenty podstawowe. Przechowuje dane rejestracyjne, operatora zakładającego i prowadzącego, klasyfikację wg wykazu akt, daty archiwizacji i zakończenia, poziom dostępu oraz hierarchię spraw nadrzędnych i podrzędnych.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IPermissionClient`, `IEmailAttachmentsHolder`, `IEmailElement`, `IDokument`, `IDmsArchInfoHost`

- pola bazodanowe (zapisywalne): 14
- pola kalkulowane (zapisywalne): 2
- pola tylko-odczyt: 12
- podlisty: 9
- subrowy: 2
- razem: 39

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ArchInfos | `SubTable<Soneta.Workflow.Dms.IK.DmsArchInfo>` | podlista |  |  |
| ArchiveCategory | `Soneta.Workflow.Dms.Config.ArchiveCategory` (subrow) | bazodanowe | Kategoria archiwalna | Kategoria archiwalna sprawy |
| ArchiveCategory.Category | `string` | tylko-odczyt | Formatowana nazwa | Formatowana nazwa kategorii archiwalnej |
| ArchiveCategory.HasDictionary | `bool` | tylko-odczyt | Określono słownik | Określono słownik kategorii |
| ArchiveCategory.ImportArchiveCategory | `string` |  |  |  |
| ArchiveCategory.Period | `int` | bazodanowe | Okres | Opcjonalny okres kategorii archiwalnej dokumentu |
| ArchiveCategory.Symbol | `Soneta.Ksiega.ElemSlownika` | bazodanowe | Symbol | Symbol kategorii archiwalnej dokumentu |
| ArchiveCategory.WgSymbol | `Key` | podlista |  |  |
| ArchivedTerm | `System.DateTime` | bazodanowe, tylko-odczyt | Data i czas archiwizacji | Data i czas archiwizacji sprawy |
| BasicDocuments | `SubTable<Soneta.Workflow.Dms.BasicDocument>` | podlista |  |  |
| ChildMatters | `SubTable<Soneta.Workflow.Dms.Matter>` | podlista |  |  |
| CloseDatetime | `System.DateTime` | bazodanowe, tylko-odczyt | Data i czas zakończenia | Data i czas zakończenia sprawy |
| Creator | `App.Operator` | bazodanowe, tylko-odczyt | Założył | Operator, który założył sprawę |
| Date | `Date` | tylko-odczyt | Data | Data sprawy |
| DcType | `Soneta.Workflow.Enums.DublinCoreEnum` (enum) | bazodanowe | Typ opisu | Typ opisu DublinCore |
| Definition | `Soneta.Workflow.Dms.Config.MatterDefinition` | bazodanowe, tylko-odczyt | Definicja sprawy | Definicja sprawy powiązana ze sprawą |
| Description | `MemoText` | bazodanowe, podlista | Opis | Opis sprawy |
| Division | `Soneta.Core.OddzialFirmy` | bazodanowe | Odział firmy | Oddział firmy powiązany ze sprawą |
| Format | `string` | bazodanowe | Format | Format sprawy |
| HasOrganizationalStructure | `bool` | tylko-odczyt |  |  |
| LastBasicDocDatetime | `System.DateTime` | bazodanowe, tylko-odczyt | Data i czas dodania dokumentu | Data i czas dodania ostatniego dokumentu podstawowego |
| Leader | `App.Operator` | bazodanowe | Prowadzący | Prowadzący sprawę |
| MatterAccess | `Soneta.Workflow.Enums.AccessEnum` (enum) | bazodanowe | Dostęp | Dostęp do sprawy |
| MatterState | `Soneta.Workflow.Dms.DmsState` | bazodanowe, tylko-odczyt | Status |  |
| Number | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe | Numer | Numer sprawy |
| Number.Numer | `int` | bazodanowe |  |  |
| Number.NumerPelny | `string` |  |  |  |
| Number.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Number.Symbol | `string` | bazodanowe |  |  |
| Number.WgNumeruDokumentu | `Key` | podlista |  |  |
| Number.WgSymboluDokumentu | `Key` | podlista |  |  |
| Parent | `Soneta.Workflow.Dms.Matter` | bazodanowe | Sprawa nadrzędna | Nadrzędna sprawa |
| Permissions | `SubTable<Db.Permissions.RecordPermission>` | podlista |  |  |
| RegistrationDatetime | `System.DateTime` | bazodanowe, tylko-odczyt | Data i czas rejestracji | Data i czas rejestracji sprawy |
| Series | `string` | bazodanowe | Seria | Seria sprawy |
| SubstantiveCell | `Soneta.Core.ElementStrukturyOrganizacyjnej` | bazodanowe | Komórka merytoryczna | Komórka merytoryczna |
| Title | `string` | bazodanowe | Tytuł | Tytuł sprawy |
| UnifiedRegisterClass | `Soneta.Workflow.Dms.Config.UnifiedRegisterClass` | bazodanowe | Klasa wykazu akt | Sprawa powiązana z klasą wykazu akt |
| WiadomosciPowiazane | `SubTable<Soneta.CRM.ElementEmail>` | podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AccessEnum (`Soneta.Workflow.Enums.AccessEnum`)
- `Public` = 0 — Publiczny - dostępny w całości
- `PartialPublic` = 1 — Publiczny - dostępny częściowo
- `Private` = 2 — Niepubliczny

### DublinCoreEnum (`Soneta.Workflow.Enums.DublinCoreEnum`)
- `Text` = 0 — Tekst
- `Image` = 1 — Obraz
- `Sound` = 2 — Dźwięk
- `Software` = 3 — Oprogramowanie
- `PhysicalObject` = 4 — Obiekt fizyczny
- `MotionPicture` = 5 — Obraz ruchomy
- `StructuredDataSet` = 6 — Uporządkowany zbiór danych
- `UnstructuredDataSet` = 7 — Nieuporządkowany zbiór danych
