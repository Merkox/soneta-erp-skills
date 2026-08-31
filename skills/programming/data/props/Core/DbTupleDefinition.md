# Pola i właściwości klasy biznesowej: `Soneta.Core.DbTuples.DbTupleDefinition`
Nazwa tabeli: `TuplesDefs`
Tytuł: Definicje dokumentów dodatkowych
Opis: Definicja typu dokumentu dodatkowego (zdarzenia, formularza dynamicznego). Określa nazwę, symbol, numerację, klasę obiektu nadrzędnego, kategorię, konfigurację pól dynamicznych, kreatorów, interfejsy oraz sposób dołączania do dokumentów podstawowych i procesów.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRuntimeRowDefinition`, `IRightsSource`, `IManagedRowDefinion`, `IWizardReferenceHost`, `ICodeFileHost`, `ISysNotificationHost`, `IWfPlugInReferenceHost`, `IPreviewPageHost`
Selektor: pole `Typ` (`Soneta.Core.DbTuples.DbTupleDefinitionType`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AttachToBasicDocument | `Soneta.Core.DbTuples.AttachToBasicDokumentType` (enum) | bazodanowe | Dodaj do dokumentu podstawowego | Dodaj do nowego dokumentu podstawowego |
| Blokada | `bool` | bazodanowe | Blokada | Definicja zablokowana |
| CalcTypeFullName | `string` | tylko-odczyt |  |  |
| Children | `string` | bazodanowe |  |  |
| CreateProcess | `Soneta.Core.DbTuples.CreateProcessType` (enum) | bazodanowe | Uruchom procesy |  |
| DataType | `System.Type` | tylko-odczyt |  |  |
| DefaultName | `string` | tylko-odczyt |  |  |
| DefinedType | `System.Type` | tylko-odczyt |  |  |
| Dependent | `SubTable<Soneta.Core.DbTuples.DbTupleDefinition>` | podlista |  |  |
| DokEwidencjaExt | `SubTable<Soneta.Core.DbTuples.Processes.DocEwidencjaDbTupleDefExt>` | podlista |  |  |
| Domyslna | `bool` | bazodanowe | Domyślne | Definicja domyślna |
| DomyslnaPulpity | `bool` | bazodanowe | Domyślne | Definicja domyślna dla pulpitów |
| Extension | `Soneta.Core.DbTuples.IDbTupleDefinitionExt` | tylko-odczyt |  |  |
| Fields | `LpSubTable<Runtime.RuntimeFieldDefinition>` | podlista |  |  |
| Files | `SubTable<Soneta.Core.CodeFile>` | podlista |  |  |
| FolderPath | `Soneta.Core.DbTuples.FolderPaths` (enum) | bazodanowe |  |  |
| FormatedName | `string` | bazodanowe | Nazwa formatowana | Nazwa formatowana dokumentu |
| HasMultiReferenceFields | `bool` | tylko-odczyt |  |  |
| Info | `string` | tylko-odczyt |  |  |
| Interfejsy | `string` | bazodanowe | Interfejsy | Interfejsy jakie implementuje klasa tupla (z namespace) oddzielone przecinkiem |
| IsDbTupleTable | `bool` | tylko-odczyt |  |  |
| IsPageVisible | `bool` | tylko-odczyt |  |  |
| Kategoria | `Soneta.Core.KDokDodatkowego` | bazodanowe | Kategoria |  |
| KlasaBazowa | `string` | bazodanowe | Klasa bazowa | Klasa bazowa po której dziedziczy klasa tupla (z namespace), która musi dziedziczyć po DbTuple |
| Kod | `string` | tylko-odczyt |  |  |
| KreatorTabeli | `string` | bazodanowe |  |  |
| Kreatory | `SubTable<Soneta.Core.ManagedRowCreator>` | podlista |  |  |
| KreowaneDefinicje | `SubTable<Soneta.Core.ManagedRowCreator>` | podlista |  |  |
| Master | `Soneta.Core.DbTuples.DbTupleDefinition` | bazodanowe, tylko-odczyt | Nadrzędna |  |
| MultiReferenceFields | `System.Collections.Generic.IEnumerable<Soneta.Core.DbTuples.DbTupleFieldDefinition>` | podlista |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa dokumentu |
| NazwaTabeli | `string` | bazodanowe, tylko-odczyt | Klasa | Klasa obiektu nadrzędanego |
| Numeracja | `Soneta.Core.DefinicjaNumeracji` (subrow) | bazodanowe |  |  |
| Numeracja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numeracja.PodczasZapisu | `bool` |  |  |  |
| Numeracja.Separator | `string` | bazodanowe |  |  |
| Numeracja.Wzor | `string` | bazodanowe |  |  |
| PlugIns | `SubTable` | podlista |  |  |
| PracownicyExt | `SubTable` | podlista |  |  |
| ReadOnlyAttachmentEditMode | `Db.AttachmentEditMode` (enum) | bazodanowe |  |  |
| ReferenceTable | `Table` | podlista |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| Seria | `bool` | bazodanowe | Seria dokumentu |  |
| Symbol | `string` | bazodanowe | Symbol | Symbol dokumentu |
| SysNotifications | `SubTable<Db.Notifications.SysNotification>` | podlista |  |  |
| Tools | `Runtime.RuntimeRowDefinitionTools` (subrow) | bazodanowe |  |  |
| Tools.Algorytm | `string` | tylko-odczyt |  |  |
| Tools.CalcCode | `string` |  |  |  |
| Tools.ClassCode | `string` |  |  |  |
| Tools.ClassName | `string` | tylko-odczyt |  |  |
| Tools.Code | `MemoText` | bazodanowe, podlista |  |  |
| Tools.EngineCode | `string` |  |  |  |
| Tools.FieldsByName | `System.Collections.Generic.Dictionary<string, Runtime.RuntimeFieldDefinition>` | podlista |  |  |
| TupleTypeFullName | `string` | tylko-odczyt |  |  |
| TylkoPosrednio | `bool` | bazodanowe | Utwórz tylko pośrednio |  |
| Typ | `Soneta.Core.DbTuples.DbTupleDefinitionType` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| TypeFullName | `string` | tylko-odczyt |  |  |
| Ukryty | `bool` | bazodanowe |  |  |
| WfDefinition | `IWFDefinition` | tylko-odczyt, iface-ref |  |  |
| WizardsRef | `LpSubTable<Db.Wizard.WizardReference>` | podlista |  |  |
| Xml | `MemoText` | bazodanowe, podlista | Definicja zakładki użytkownika |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Typ`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Standalone` | 0 | `Soneta.Core.DbTuples.DbTupleDefinition` |  |
| `Dependent` | 1 | `Soneta.Core.DbTuples.DbTupleDefinitionDependent` | Definicja dokumentu dodatkowego (zależnego) |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| WfDefinition | `IWFDefinition` | `WFDefinition` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AttachmentEditMode (`Db.AttachmentEditMode`)
- `None` = 0
- `ReadOnly` = 1 — Zabroniona
- `AllowAdd` = 2
- `AllowEdit` = 4
- `AllowRemove` = 8
- `AllowSign` = 16
- `AllowUnsign` = 32
- `OnlyNew` = 256
- `FullEdit` = 62 — Dozwolona

### AttachToBasicDokumentType (`Soneta.Core.DbTuples.AttachToBasicDokumentType`)
- `None` = 0 — Brak
- `Required` = 1 — Wymagane
- `Optional` = 2 — Opcjonalne

### CreateProcessType (`Soneta.Core.DbTuples.CreateProcessType`)
- `Default` = 0 — Podczas zapisu dokumentu
- `OnAdded` = 1 — Podczas dodawania dokumentu

### DbTupleDefinitionType (`Soneta.Core.DbTuples.DbTupleDefinitionType`)
- `Standalone` = 0
- `Dependent` = 1

### FolderPaths (`Soneta.Core.DbTuples.FolderPaths`)
- `Dowolny` = -1
- `Domyślny` = 0
- `PracownikKadry` = 1 — Inne kadrowe
- `PracownikPłace` = 2 — Inne płacowe
