# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.Wizard.WizardDefinition`
Nazwa tabeli: `WizardDefs`
Tytuł: Definicje kreatorów
Opis: Definicja kreatora (wizarda) prowadzącego użytkownika przez wielokrokowy proces. Określa typ obiektu, algorytm kalkulatora kroków, kolejność i konfigurację kreatora.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 17
- pola kalkulowane (z klas biznesowych): 22

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AfterSaveAndFinishCode | `string` |  | Kod algorytmu metody AfterSaveAndFinish | Kod algorytmu kalkulatora metody wykonywanej po zapisie kreatora |
| Algorithm | `Soneta.Business.Db.Wizard.WizardAlgorithm` | bazodanowe, enum | Algorytm | Algorytm kalkulatora kroków kreatora |
| BeforeSaveAndFinishCode | `string` |  | Kod algorytmu metody BeforeSaveAndFinish | Kod algorytmu kalkulatora metody wykonywanej przed zapisem kreatora |
| ClassName | `string` |  |  |  |
| Code | `Soneta.Business.MemoText` | bazodanowe | Kod algorytmu | Kod algorytmu kalkulatora kreatora |
| ConfigClass | `string` | bazodanowe | Klasa do zapisu konfiguracji | Klasa z definicją obiektu przechowującego statyczną konfigrację. |
| ConfigTypeFullName | `string` |  |  |  |
| CreateStepsCode | `string` |  | Kod algorytmu metody CreateSteps | Kod algorytmu kalkulatora metody wyliczającej kroki kreatora |
| DataType | `System.Type` |  |  |  |
| DataTypeFullName | `string` |  |  |  |
| DataTypeName | `string` |  |  |  |
| Description | `string` | bazodanowe | Opis | Opis definicji |
| EngineClassName | `string` |  |  |  |
| EngineCode | `Soneta.Business.MemoText` | bazodanowe | Kod engine | Kod engine kalkulatora kreatora |
| EngineCodeEditorSource | `Soneta.Business.Compiler.ICodeEditorSource` |  | Kod algorytmu metody Engine | Kod engine |
| ForceUnloockParentCode | `string` |  | Kod algorytmu metody ForceUnloockParent | Kod algorytmu kalkulatora metody określającej czy automatycznie odblokować wiersz do edycji |
| FormattedName | `string` | bazodanowe | Nazwa formatowana | Nazwa formatowana definicji |
| GetRowCode | `string` |  | Kod algorytmu metody GetRow | Kod algorytmu kalkulatora metody wyliczającej wiersz edytowany w kreatorze |
| Host | `Soneta.Business.IWizardReferenceHost` | bazodanowe, iface-ref | Kreator dla |  |
| HostsRef | `Soneta.Business.SubTable<Soneta.Business.Db.Wizard.WizardReference>` |  |  |  |
| Info | `string` |  |  |  |
| InterfaceMode | `Soneta.Business.Db.Wizard.WizardInterfaceModes` | bazodanowe, enum | Tryb wyboru ścieżki | Tryb wybór ścieżki dla kreatora |
| IsEnableCode | `string` |  | Kod algorytmu metody IsEnable | Kod algorytmu kalkulatora metody określającej aktywność kreatora |
| IsPageVisible | `bool` |  |  |  |
| Locked | `bool` | bazodanowe | Zablokowana | Czy definicja zablokowana |
| Lp | `int` | bazodanowe | Lp. | Liczba porządkowa kreatora |
| Name | `string` | bazodanowe | Nazwa | Nazwa definicji |
| ParentType | `string` | bazodanowe | Typ obiektu kreatora | Określa typ obiektu kreatora |
| RowName | `string` |  |  |  |
| RowType | `Soneta.Business.IWizardRowType` | bazodanowe | Typ | Typ dla row dla dbtuple |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| SourceCode | `string` |  |  |  |
| Steps | `Soneta.Business.LpSubTable<Soneta.Business.Db.Wizard.WizardStepDefinition>` |  |  |  |
| StepsTableNames | `System.Collections.Generic.IEnumerable<string>` |  |  |  |
| TaskDefinitions | `Soneta.Business.SubTable<Soneta.Business.Db.TaskDefinition>` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IWizardReferenceHost` | `DbTupleDefinition`, `DefLeada`, `DefProjektu`, `DefTransakcja`, `DefZadania`, `TaskDefinition`, `WFDefinition` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### WizardAlgorithm (`Soneta.Business.Db.Wizard.WizardAlgorithm`)
- `False` = 0 — Brak
- `True` = 1 — Wielozakładkowy
- `Advanced` = 2 — Jednozakładkowy

### WizardInterfaceModes (`Soneta.Business.Db.Wizard.WizardInterfaceModes`)
- `Default` = 0 — Domyślny
- `SelectMode` = 1 — Lista
- `WizardMode` = 2 — Przyciski
- `SimpleWizardMode` = 3 — Przyciski (skrócony)
