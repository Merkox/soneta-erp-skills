# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Dms.BasicDocument`
Nazwa tabeli: `BasicDocs`
Tytuł: Dokumenty podstawowe
Opis: Dokument podstawowy (pismo) w systemie DMS, stanowiący główną jednostkę obiegu dokumentów. Przechowuje dane ewidencyjne dokumentu: daty, numer, serię, podmiot, rejestr, sprawę, kategorię archiwalną, poziom dostępu oraz powiązanie z klasą wykazu akt.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IPermissionClient`, `IEmailElement`, `IDaneKontrahentaHost`, `IDokument`, `IChronoOrderHost`, `IDmsArchInfoHost`

- pola bazodanowe: 37
- pola kalkulowane (z klas biznesowych): 20

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AddingDatetime | `System.DateTime` | bazodanowe | Data i czas dodania do sprawy | Data i czas dodania pisma do sprawy |
| ArchInfos | `Soneta.Business.SubTable<Soneta.Workflow.Dms.IK.DmsArchInfo>` |  |  |  |
| ArchiveCategory | `Soneta.Workflow.Dms.Config.ArchiveCategory` | bazodanowe | Kategoria archiwalna | Kategoria archiwalna dokumentu |
| ArchiveCategory.Category | `string` |  | Formatowana nazwa | Formatowana nazwa kategorii archiwalnej |
| ArchiveCategory.HasDictionary | `bool` |  | Określono słownik | Określono słownik kategorii |
| ArchiveCategory.ImportArchiveCategory | `string` |  |  |  |
| ArchiveCategory.Period | `int` | bazodanowe | Okres | Opcjonalny okres kategorii archiwalnej dokumentu |
| ArchiveCategory.Symbol | `Soneta.Ksiega.ElemSlownika` | bazodanowe | Symbol | Symbol kategorii archiwalnej dokumentu |
| ArchiveCategory.WgSymbol | `Soneta.Business.Key` |  |  |  |
| ArchivedTerm | `System.DateTime` | bazodanowe | Data i czas archiwizacji | Data i czas archiwizacji dokumentu |
| AttachmentsCount | `int` |  | Liczba załączników | Liczba załączników |
| BasicDocBusEnts | `Soneta.Business.SubTable<Soneta.Workflow.Dms.BDocBusEnt>` |  |  |  |
| BasicDocBusEntsList | `string` |  |  |  |
| BusinessEntity | `Soneta.Core.IPodmiot` | bazodanowe, iface-ref | Podmiot | Podmiot związany z dokumentem podstawowym |
| ContractorDatas | `Soneta.Business.SubTable` |  | Dane kontrahenta | Lista wszystkich danych kontrahenta powiązanych z dokumentem podstawowym. |
| Date | `Soneta.Types.Date` | bazodanowe | Data | Data pisma |
| DateOfDispatch | `Soneta.Types.Date` | bazodanowe | Data nadania | Data nadania pisma |
| DateOfDocument | `Soneta.Types.Date` | bazodanowe | Data dokumentu | Ewidencyjna data dokumentu |
| DateOfReceipt | `System.DateTime` | bazodanowe | Data wpływu | Data wpływu pisma |
| DaysForResponse | `int` | bazodanowe | Dni na odpowiedź | Określa liczbę dni na odpowiedź |
| DbTuple | `Soneta.Core.DbTuples.DbTuple` |  |  |  |
| DcType | `Soneta.Workflow.Enums.DublinCoreEnum` | bazodanowe, enum | Typ opisu | Typ opisu DublinCore |
| Definition | `Soneta.Workflow.Dms.Config.BasicDocumentDefinition` | bazodanowe | Definicja dokumentu podstawowego | Definicja dokumentu podstawowego powiązana z dokumentem podstawowym |
| Description | `string` |  |  |  |
| Division | `Soneta.Core.OddzialFirmy` | bazodanowe | Odział firmy | Oddział firmy powiązany z dokumentem podstawowym |
| DocState | `Soneta.Workflow.Dms.DmsState` | bazodanowe | Status |  |
| DocType | `Soneta.Workflow.Dms.BasicDocKind` | bazodanowe | Typ dokumentu |  |
| DocumentAccess | `Soneta.Workflow.Enums.AccessEnum` | bazodanowe, enum | Dostęp | Dostęp do dokumentu |
| DocumentNote | `Soneta.Business.MemoText` | bazodanowe | Uwagi | Uwagi do dokumentu |
| DocumentType | `Soneta.Core.DbTuples.DbTupleDefinition` |  | Typ dokumentu | Typ dokumentu dodatkowego powiązanego z dokumentem podstawowym |
| EditableField | `Soneta.Workflow.Enums.EditableFieldEnum` | bazodanowe, enum | Pole edytowane | Które pole jest edytowane (podmiot lub osoba) |
| Email | `string` | bazodanowe | E-mail | E-mail |
| FileExtension | `string` |  | Format rozszerzenia | Format rozszerzenia pliku |
| ForeignSign | `string` | bazodanowe | Znak obcy | Znak obcy |
| HasDictionary | `bool` |  | Określono słownik | Określono słownik kategorii |
| HasOrganizationalStructure | `bool` |  |  |  |
| LanguageCode | `string` | bazodanowe | Kod języka | Kod języka |
| Matter | `Soneta.Workflow.Dms.Matter` | bazodanowe | Sprawa | Dokument podstawowy powiązany ze sprawą |
| MethodOfTransfer | `Soneta.Ksiega.ElemSlownika` | bazodanowe | Sposób przekazania | Sposób przekazania dokumentu |
| Number | `Soneta.Core.NumerDokumentu` | bazodanowe | Numer | Numer dokumentu |
| Number.Numer | `int` | bazodanowe |  |  |
| Number.NumerPelny | `string` |  |  |  |
| Number.Pelny | `string` | bazodanowe | Numer pełny |  |
| Number.Symbol | `string` | bazodanowe |  |  |
| Number.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Number.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| Permissions | `Soneta.Business.SubTable<Soneta.Business.Db.Permissions.RecordPermission>` |  |  |  |
| Person | `Soneta.CRM.KontaktOsoba` | bazodanowe | Osoba | Osoba związany z dokumentem podstawowym |
| Register | `Soneta.Workflow.Dms.Config.Register` | bazodanowe | Rejestr dokumentu podstawowego | Rejestr dokumentu podstawowego powiązany z dokumentem podstawowym |
| RegistrationDatetime | `System.DateTime` | bazodanowe | Data i czas rejestracji | Data i czas rejestracji pisma |
| ResponseDeadline | `Soneta.Types.Date` | bazodanowe | Termin odpowiedzi | Data wyznaczająca termin odpowiedzi na pismo |
| Responsible | `Soneta.Business.App.Operator` | bazodanowe | Odpowiedzialny | Odpowiedzialny za dokument |
| Series | `string` | bazodanowe | Seria | Seria dokumentu |
| SubstantiveCell | `Soneta.Core.ElementStrukturyOrganizacyjnej` | bazodanowe | Komórka merytoryczna | Komórka merytoryczna |
| Title | `string` | bazodanowe | Tytuł | Tytuł |
| UnifiedRegisterClass | `Soneta.Workflow.Dms.Config.UnifiedRegisterClass` | bazodanowe | Klasa wykazu akt | Dokument podstawowy powiązany z klasą wykazu akt |
| WiadomosciPowiazane | `Soneta.Business.SubTable<Soneta.CRM.ElementEmail>` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| BusinessEntity | `IPodmiot` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |

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

### EditableFieldEnum (`Soneta.Workflow.Enums.EditableFieldEnum`)
- `BusinessEntity` = 0 — Podmiot
- `Person` = 1 — Osoba
