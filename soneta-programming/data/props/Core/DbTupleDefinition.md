# Pola i właściwości klasy biznesowej: `Soneta.Core.DbTuples.DbTupleDefinition`
Nazwa tabeli: `TuplesDefs`
Tytuł: Definicje dokumentów dodatkowych
Opis: Definicja typu dokumentu dodatkowego (zdarzenia, formularza dynamicznego). Określa nazwę, symbol, numerację, klasę obiektu nadrzędnego, kategorię, konfigurację pól dynamicznych, kreatorów, interfejsy oraz sposób dołączania do dokumentów podstawowych i procesów.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRuntimeRowDefinition`, `IRightsSource`, `IManagedRowDefinion`, `IWizardReferenceHost`, `ICodeFileHost`, `ISysNotificationHost`, `IWfPlugInReferenceHost`, `IPreviewPageHost`

- pola bazodanowe: 32
- pola kalkulowane (z klas biznesowych): 33

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AttachToBasicDocument | `Soneta.Core.DbTuples.AttachToBasicDokumentType` | bazodanowe, enum | Dodaj do dokumentu podstawowego | Dodaj do nowego dokumentu podstawowego |
| Blokada | `bool` | bazodanowe | Blokada | Definicja zablokowana |
| CalcTypeFullName | `string` |  |  |  |
| Children | `string` | bazodanowe |  |  |
| CreateProcess | `Soneta.Core.DbTuples.CreateProcessType` | bazodanowe, enum | Uruchom procesy |  |
| DataType | `System.Type` |  |  |  |
| DefaultName | `string` |  |  |  |
| DefinedType | `System.Type` |  |  |  |
| Dependent | `Soneta.Business.SubTable<Soneta.Core.DbTuples.DbTupleDefinition>` |  |  |  |
| DokEwidencjaExt | `Soneta.Business.SubTable<Soneta.Core.DbTuples.Processes.DocEwidencjaDbTupleDefExt>` |  |  |  |
| Domyslna | `bool` | bazodanowe | Domyślne | Definicja domyślna |
| DomyslnaPulpity | `bool` | bazodanowe | Domyślne | Definicja domyślna dla pulpitów |
| Extension | `Soneta.Core.DbTuples.IDbTupleDefinitionExt` |  |  |  |
| Fields | `Soneta.Business.LpSubTable<Soneta.Business.Runtime.RuntimeFieldDefinition>` |  |  |  |
| Files | `Soneta.Business.SubTable<Soneta.Core.CodeFile>` |  |  |  |
| FolderPath | `Soneta.Core.DbTuples.FolderPaths` | bazodanowe, enum |  |  |
| FormatedName | `string` | bazodanowe | Nazwa formatowana | Nazwa formatowana dokumentu |
| HasMultiReferenceFields | `bool` |  |  |  |
| Info | `string` |  |  |  |
| Interfejsy | `string` | bazodanowe | Interfejsy | Interfejsy jakie implementuje klasa tupla (z namespace) oddzielone przecinkiem |
| IsDbTupleTable | `bool` |  |  |  |
| IsPageVisible | `bool` |  |  |  |
| Kategoria | `Soneta.Core.KDokDodatkowego` | bazodanowe | Kategoria |  |
| KlasaBazowa | `string` | bazodanowe | Klasa bazowa | Klasa bazowa po której dziedziczy klasa tupla (z namespace), która musi dziedziczyć po DbTuple |
| Kod | `string` |  |  |  |
| KreatorTabeli | `string` | bazodanowe |  |  |
| Kreatory | `Soneta.Business.SubTable<Soneta.Core.ManagedRowCreator>` |  |  |  |
| KreowaneDefinicje | `Soneta.Business.SubTable<Soneta.Core.ManagedRowCreator>` |  |  |  |
| Master | `Soneta.Core.DbTuples.DbTupleDefinition` | bazodanowe | Nadrzędna |  |
| MultiReferenceFields | `System.Collections.Generic.IEnumerable<Soneta.Core.DbTuples.DbTupleFieldDefinition>` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa dokumentu |
| NazwaTabeli | `string` | bazodanowe | Klasa | Klasa obiektu nadrzędanego |
| Numeracja | `Soneta.Core.DefinicjaNumeracji` | bazodanowe |  |  |
| Numeracja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numeracja.PodczasZapisu | `bool` |  |  |  |
| Numeracja.Separator | `string` | bazodanowe |  |  |
| Numeracja.Wzor | `string` | bazodanowe |  |  |
| PlugIns | `Soneta.Business.SubTable` |  |  |  |
| PracownicyExt | `Soneta.Business.SubTable` |  |  |  |
| ReadOnlyAttachmentEditMode | `Soneta.Business.Db.AttachmentEditMode` | bazodanowe, enum |  |  |
| ReferenceTable | `Soneta.Business.Table` |  |  |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| Seria | `bool` | bazodanowe | Seria dokumentu |  |
| Symbol | `string` | bazodanowe | Symbol | Symbol dokumentu |
| SysNotifications | `Soneta.Business.SubTable<Soneta.Business.Db.Notifications.SysNotification>` |  |  |  |
| Tools | `Soneta.Business.Runtime.RuntimeRowDefinitionTools` | bazodanowe |  |  |
| Tools.Algorytm | `string` |  |  |  |
| Tools.CalcCode | `string` |  |  |  |
| Tools.ClassCode | `string` |  |  |  |
| Tools.ClassName | `string` |  |  |  |
| Tools.Code | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Tools.EngineCode | `string` |  |  |  |
| Tools.FieldsByName | `System.Collections.Generic.Dictionary<string, Soneta.Business.Runtime.RuntimeFieldDefinition>` |  |  |  |
| TupleTypeFullName | `string` |  |  |  |
| TylkoPosrednio | `bool` | bazodanowe | Utwórz tylko pośrednio |  |
| Typ | `Soneta.Core.DbTuples.DbTupleDefinitionType` | bazodanowe, enum |  |  |
| TypeFullName | `string` |  |  |  |
| Ukryty | `bool` | bazodanowe |  |  |
| WfDefinition | `Soneta.Business.IWFDefinition` | iface-ref |  |  |
| WizardsRef | `Soneta.Business.LpSubTable<Soneta.Business.Db.Wizard.WizardReference>` |  |  |  |
| Xml | `Soneta.Business.MemoText` | bazodanowe | Definicja zakładki użytkownika |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| WfDefinition | `IWFDefinition` | `WFDefinition` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AttachmentEditMode (`Soneta.Business.Db.AttachmentEditMode`)
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
