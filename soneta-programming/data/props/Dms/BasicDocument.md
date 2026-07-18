# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Dms.BasicDocument`
Nazwa tabeli: `BasicDocs`
Tytuł: Dokumenty podstawowe
Opis: Dokument podstawowy (pismo) w systemie DMS, stanowiący główną jednostkę obiegu dokumentów. Przechowuje dane ewidencyjne dokumentu: daty, numer, serię, podmiot, rejestr, sprawę, kategorię archiwalną, poziom dostępu oraz powiązanie z klasą wykazu akt.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IPermissionClient`, `IEmailElement`, `IDaneKontrahentaHost`, `IDokument`, `IChronoOrderHost`, `IDmsArchInfoHost`

- pola bazodanowe (zapisywalne): 23
- pola kalkulowane (zapisywalne): 3
- pola tylko-odczyt: 17
- podlisty: 9
- subrowy: 2
- razem: 54

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AddingDatetime | `System.DateTime` | bazodanowe, tylko-odczyt | Data i czas dodania do sprawy | Data i czas dodania pisma do sprawy |
| ArchInfos | `SubTable<Soneta.Workflow.Dms.IK.DmsArchInfo>` | podlista |  |  |
| ArchiveCategory | `Soneta.Workflow.Dms.Config.ArchiveCategory` (subrow) | bazodanowe | Kategoria archiwalna | Kategoria archiwalna dokumentu |
| ArchiveCategory.Category | `string` | tylko-odczyt | Formatowana nazwa | Formatowana nazwa kategorii archiwalnej |
| ArchiveCategory.HasDictionary | `bool` | tylko-odczyt | Określono słownik | Określono słownik kategorii |
| ArchiveCategory.ImportArchiveCategory | `string` |  |  |  |
| ArchiveCategory.Period | `int` | bazodanowe | Okres | Opcjonalny okres kategorii archiwalnej dokumentu |
| ArchiveCategory.Symbol | `Soneta.Ksiega.ElemSlownika` | bazodanowe | Symbol | Symbol kategorii archiwalnej dokumentu |
| ArchiveCategory.WgSymbol | `Key` | podlista |  |  |
| ArchivedTerm | `System.DateTime` | bazodanowe, tylko-odczyt | Data i czas archiwizacji | Data i czas archiwizacji dokumentu |
| AttachmentsCount | `int` | tylko-odczyt | Liczba załączników | Liczba załączników |
| BasicDocBusEnts | `SubTable<Soneta.Workflow.Dms.BDocBusEnt>` | podlista |  |  |
| BasicDocBusEntsList | `string` | tylko-odczyt |  |  |
| ContractorDatas | `SubTable` | podlista | Dane kontrahenta | Lista wszystkich danych kontrahenta powiązanych z dokumentem podstawowym. |
| Date | `Date` | bazodanowe | Data | Data pisma |
| DateOfDispatch | `Date` | bazodanowe | Data nadania | Data nadania pisma |
| DateOfDocument | `Date` | bazodanowe | Data dokumentu | Ewidencyjna data dokumentu |
| DateOfReceipt | `System.DateTime` | bazodanowe, tylko-odczyt | Data wpływu | Data wpływu pisma |
| DaysForResponse | `int` | bazodanowe, tylko-odczyt | Dni na odpowiedź | Określa liczbę dni na odpowiedź |
| DbTuple | `Soneta.Core.DbTuples.DbTuple` | tylko-odczyt |  |  |
| DcType | `Soneta.Workflow.Enums.DublinCoreEnum` (enum) | bazodanowe | Typ opisu | Typ opisu DublinCore |
| Definition | `Soneta.Workflow.Dms.Config.BasicDocumentDefinition` | bazodanowe, tylko-odczyt | Definicja dokumentu podstawowego | Definicja dokumentu podstawowego powiązana z dokumentem podstawowym |
| Description | `string` | tylko-odczyt |  |  |
| Division | `Soneta.Core.OddzialFirmy` | bazodanowe | Odział firmy | Oddział firmy powiązany z dokumentem podstawowym |
| DocState | `Soneta.Workflow.Dms.DmsState` | bazodanowe, tylko-odczyt | Status |  |
| DocType | `Soneta.Workflow.Dms.BasicDocKind` | bazodanowe | Typ dokumentu |  |
| DocumentAccess | `Soneta.Workflow.Enums.AccessEnum` (enum) | bazodanowe | Dostęp | Dostęp do dokumentu |
| DocumentNote | `MemoText` | bazodanowe, podlista | Uwagi | Uwagi do dokumentu |
| DocumentType | `Soneta.Core.DbTuples.DbTupleDefinition` |  | Typ dokumentu | Typ dokumentu dodatkowego powiązanego z dokumentem podstawowym |
| Email | `string` | bazodanowe | E-mail | E-mail |
| FileExtension | `string` | tylko-odczyt | Format rozszerzenia | Format rozszerzenia pliku |
| ForeignSign | `string` | bazodanowe | Znak obcy | Znak obcy |
| HasDictionary | `bool` | tylko-odczyt | Określono słownik | Określono słownik kategorii |
| HasOrganizationalStructure | `bool` | tylko-odczyt |  |  |
| LanguageCode | `string` | bazodanowe | Kod języka | Kod języka |
| Matter | `Soneta.Workflow.Dms.Matter` | bazodanowe | Sprawa | Dokument podstawowy powiązany ze sprawą |
| MethodOfTransfer | `Soneta.Ksiega.ElemSlownika` | bazodanowe | Sposób przekazania | Sposób przekazania dokumentu |
| Number | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe | Numer | Numer dokumentu |
| Number.Numer | `int` | bazodanowe |  |  |
| Number.NumerPelny | `string` |  |  |  |
| Number.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Number.Symbol | `string` | bazodanowe |  |  |
| Number.WgNumeruDokumentu | `Key` | podlista |  |  |
| Number.WgSymboluDokumentu | `Key` | podlista |  |  |
| Permissions | `SubTable<Db.Permissions.RecordPermission>` | podlista |  |  |
| Register | `Soneta.Workflow.Dms.Config.Register` | bazodanowe | Rejestr dokumentu podstawowego | Rejestr dokumentu podstawowego powiązany z dokumentem podstawowym |
| RegistrationDatetime | `System.DateTime` | bazodanowe, tylko-odczyt | Data i czas rejestracji | Data i czas rejestracji pisma |
| ResponseDeadline | `Date` | bazodanowe | Termin odpowiedzi | Data wyznaczająca termin odpowiedzi na pismo |
| Responsible | `App.Operator` | bazodanowe | Odpowiedzialny | Odpowiedzialny za dokument |
| Series | `string` | bazodanowe | Seria | Seria dokumentu |
| SubstantiveCell | `Soneta.Core.ElementStrukturyOrganizacyjnej` | bazodanowe | Komórka merytoryczna | Komórka merytoryczna |
| Title | `string` | bazodanowe | Tytuł | Tytuł |
| UnifiedRegisterClass | `Soneta.Workflow.Dms.Config.UnifiedRegisterClass` | bazodanowe | Klasa wykazu akt | Dokument podstawowy powiązany z klasą wykazu akt |
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
