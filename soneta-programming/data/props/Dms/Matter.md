# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Dms.Matter`
Nazwa tabeli: `Matters`
Tytuł: Sprawy
Opis: Sprawa w systemie DMS grupująca powiązane dokumenty podstawowe. Przechowuje dane rejestracyjne, operatora zakładającego i prowadzącego, klasyfikację wg wykazu akt, daty archiwizacji i zakończenia, poziom dostępu oraz hierarchię spraw nadrzędnych i podrzędnych.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IPermissionClient`, `IEmailAttachmentsHolder`, `IEmailElement`, `IDokument`, `IDmsArchInfoHost`

- pola bazodanowe: 25
- pola kalkulowane (z klas biznesowych): 14

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ArchInfos | `Soneta.Business.SubTable<Soneta.Workflow.Dms.IK.DmsArchInfo>` |  |  |  |
| ArchiveCategory | `Soneta.Workflow.Dms.Config.ArchiveCategory` | bazodanowe | Kategoria archiwalna | Kategoria archiwalna sprawy |
| ArchiveCategory.Category | `string` |  | Formatowana nazwa | Formatowana nazwa kategorii archiwalnej |
| ArchiveCategory.HasDictionary | `bool` |  | Określono słownik | Określono słownik kategorii |
| ArchiveCategory.ImportArchiveCategory | `string` |  |  |  |
| ArchiveCategory.Period | `int` | bazodanowe | Okres | Opcjonalny okres kategorii archiwalnej dokumentu |
| ArchiveCategory.Symbol | `Soneta.Ksiega.ElemSlownika` | bazodanowe | Symbol | Symbol kategorii archiwalnej dokumentu |
| ArchiveCategory.WgSymbol | `Soneta.Business.Key` |  |  |  |
| ArchivedTerm | `System.DateTime` | bazodanowe | Data i czas archiwizacji | Data i czas archiwizacji sprawy |
| BasicDocuments | `Soneta.Business.SubTable<Soneta.Workflow.Dms.BasicDocument>` |  |  |  |
| ChildMatters | `Soneta.Business.SubTable<Soneta.Workflow.Dms.Matter>` |  |  |  |
| CloseDatetime | `System.DateTime` | bazodanowe | Data i czas zakończenia | Data i czas zakończenia sprawy |
| Creator | `Soneta.Business.App.Operator` | bazodanowe | Założył | Operator, który założył sprawę |
| Date | `Soneta.Types.Date` |  | Data | Data sprawy |
| DcType | `Soneta.Workflow.Enums.DublinCoreEnum` | bazodanowe, enum | Typ opisu | Typ opisu DublinCore |
| Definition | `Soneta.Workflow.Dms.Config.MatterDefinition` | bazodanowe | Definicja sprawy | Definicja sprawy powiązana ze sprawą |
| Description | `Soneta.Business.MemoText` | bazodanowe | Opis | Opis sprawy |
| Division | `Soneta.Core.OddzialFirmy` | bazodanowe | Odział firmy | Oddział firmy powiązany ze sprawą |
| Format | `string` | bazodanowe | Format | Format sprawy |
| HasOrganizationalStructure | `bool` |  |  |  |
| LastBasicDocDatetime | `System.DateTime` | bazodanowe | Data i czas dodania dokumentu | Data i czas dodania ostatniego dokumentu podstawowego |
| Leader | `Soneta.Business.App.Operator` | bazodanowe | Prowadzący | Prowadzący sprawę |
| MatterAccess | `Soneta.Workflow.Enums.AccessEnum` | bazodanowe, enum | Dostęp | Dostęp do sprawy |
| MatterState | `Soneta.Workflow.Dms.DmsState` | bazodanowe | Status |  |
| Number | `Soneta.Core.NumerDokumentu` | bazodanowe | Numer | Numer sprawy |
| Number.Numer | `int` | bazodanowe |  |  |
| Number.NumerPelny | `string` |  |  |  |
| Number.Pelny | `string` | bazodanowe | Numer pełny |  |
| Number.Symbol | `string` | bazodanowe |  |  |
| Number.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Number.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| Parent | `Soneta.Workflow.Dms.Matter` | bazodanowe | Sprawa nadrzędna | Nadrzędna sprawa |
| Permissions | `Soneta.Business.SubTable<Soneta.Business.Db.Permissions.RecordPermission>` |  |  |  |
| RegistrationDatetime | `System.DateTime` | bazodanowe | Data i czas rejestracji | Data i czas rejestracji sprawy |
| Series | `string` | bazodanowe | Seria | Seria sprawy |
| SubstantiveCell | `Soneta.Core.ElementStrukturyOrganizacyjnej` | bazodanowe | Komórka merytoryczna | Komórka merytoryczna |
| Title | `string` | bazodanowe | Tytuł | Tytuł sprawy |
| UnifiedRegisterClass | `Soneta.Workflow.Dms.Config.UnifiedRegisterClass` | bazodanowe | Klasa wykazu akt | Sprawa powiązana z klasą wykazu akt |
| WiadomosciPowiazane | `Soneta.Business.SubTable<Soneta.CRM.ElementEmail>` |  |  |  |

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
