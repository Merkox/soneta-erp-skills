# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.Wizard.WizardDefinition`
Nazwa tabeli: `WizardDefs`
Tytuł: Definicje kreatorów
Opis: Definicja kreatora (wizarda) prowadzącego użytkownika przez wielokrokowy proces. Określa typ obiektu, algorytm kalkulatora kroków, kolejność i konfigurację kreatora.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AfterSaveAndFinishCode | `string` |  | Kod algorytmu metody AfterSaveAndFinish | Kod algorytmu kalkulatora metody wykonywanej po zapisie kreatora |
| Algorithm | `Db.Wizard.WizardAlgorithm` (enum) | bazodanowe | Algorytm | Algorytm kalkulatora kroków kreatora |
| BeforeSaveAndFinishCode | `string` |  | Kod algorytmu metody BeforeSaveAndFinish | Kod algorytmu kalkulatora metody wykonywanej przed zapisem kreatora |
| ClassName | `string` | tylko-odczyt |  |  |
| Code | `MemoText` | bazodanowe, podlista | Kod algorytmu | Kod algorytmu kalkulatora kreatora |
| ConfigClass | `string` | bazodanowe | Klasa do zapisu konfiguracji | Klasa z definicją obiektu przechowującego statyczną konfigrację. |
| ConfigTypeFullName | `string` |  |  |  |
| CreateStepsCode | `string` |  | Kod algorytmu metody CreateSteps | Kod algorytmu kalkulatora metody wyliczającej kroki kreatora |
| DataType | `System.Type` | tylko-odczyt |  |  |
| DataTypeFullName | `string` | tylko-odczyt |  |  |
| DataTypeName | `string` | tylko-odczyt |  |  |
| Description | `string` | bazodanowe | Opis | Opis definicji |
| EngineClassName | `string` | tylko-odczyt |  |  |
| EngineCode | `MemoText` | bazodanowe, podlista | Kod engine | Kod engine kalkulatora kreatora |
| EngineCodeEditorSource | `Compiler.ICodeEditorSource` |  | Kod algorytmu metody Engine | Kod engine |
| ForceUnloockParentCode | `string` |  | Kod algorytmu metody ForceUnloockParent | Kod algorytmu kalkulatora metody określającej czy automatycznie odblokować wiersz do edycji |
| FormattedName | `string` | bazodanowe | Nazwa formatowana | Nazwa formatowana definicji |
| GetRowCode | `string` |  | Kod algorytmu metody GetRow | Kod algorytmu kalkulatora metody wyliczającej wiersz edytowany w kreatorze |
| Host | `IWizardReferenceHost` | bazodanowe, tylko-odczyt, iface-ref | Kreator dla |  |
| HostsRef | `SubTable<Db.Wizard.WizardReference>` | podlista |  |  |
| Info | `string` | tylko-odczyt |  |  |
| InterfaceMode | `Db.Wizard.WizardInterfaceModes` (enum) | bazodanowe | Tryb wyboru ścieżki | Tryb wybór ścieżki dla kreatora |
| IsEnableCode | `string` |  | Kod algorytmu metody IsEnable | Kod algorytmu kalkulatora metody określającej aktywność kreatora |
| IsPageVisible | `bool` | tylko-odczyt |  |  |
| Locked | `bool` | bazodanowe | Zablokowana | Czy definicja zablokowana |
| Lp | `int` | bazodanowe | Lp. | Liczba porządkowa kreatora |
| Name | `string` | bazodanowe | Nazwa | Nazwa definicji |
| ParentType | `string` | bazodanowe, tylko-odczyt | Typ obiektu kreatora | Określa typ obiektu kreatora |
| RowName | `string` | tylko-odczyt |  |  |
| RowType | `IWizardRowType` | bazodanowe | Typ | Typ dla row dla dbtuple |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| SourceCode | `string` | tylko-odczyt |  |  |
| Steps | `LpSubTable<Db.Wizard.WizardStepDefinition>` | podlista |  |  |
| StepsTableNames | `System.Collections.Generic.IEnumerable<string>` | podlista |  |  |
| TaskDefinitions | `SubTable<Db.TaskDefinition>` | podlista |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IWizardReferenceHost` | `DbTupleDefinition`, `DefLeada`, `DefProjektu`, `DefTransakcja`, `DefZadania`, `TaskDefinition`, `WFDefinition` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### WizardAlgorithm (`Db.Wizard.WizardAlgorithm`)
- `False` = 0 — Brak
- `True` = 1 — Wielozakładkowy
- `Advanced` = 2 — Jednozakładkowy

### WizardInterfaceModes (`Db.Wizard.WizardInterfaceModes`)
- `Default` = 0 — Domyślny
- `SelectMode` = 1 — Lista
- `WizardMode` = 2 — Przyciski
- `SimpleWizardMode` = 3 — Przyciski (skrócony)
