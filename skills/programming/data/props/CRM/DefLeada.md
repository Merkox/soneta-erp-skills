# Pola i właściwości klasy biznesowej: `Soneta.CRM.Config.DefLeada`
Nazwa tabeli: `DefLeadow`
Tytuł: Definicje leadów CRM
Opis: Definicja typu leada CRM określająca jego parametry i zachowanie. Konfiguruje numerację, algorytmy, formularz użytkownika, uprawnienia, domyślną definicję transakcji oraz procesy workflow, stanowiąc wzorzec dla tworzenia leadów sprzedażowych.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`, `ISysNotificationHost`, `IWizardReferenceHost`, `IWfPlugInReferenceHost`, `IWFDefinitionHost`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `bool` | bazodanowe |  | Określa czy istnieje algorytm dla leada. |
| Blokada | `bool` | bazodanowe | Zablokowana | Określa zablokowanie definicji. |
| ClassName | `string` | tylko-odczyt |  |  |
| Code | `MemoText` | bazodanowe, podlista | Kod kalkulatora dla leada | Kod klasy kalkulatora dla leada. |
| CreateProcess | `Soneta.Core.DbTuples.CreateProcessType` (enum) | bazodanowe | Uruchom procesy |  |
| DataType | `System.Type` | tylko-odczyt |  |  |
| DefinedTypeName | `string` | tylko-odczyt |  |  |
| DefinicjaTransakcja | `Soneta.CRM.Config.DefTransakcja` | bazodanowe | Domyślna definicja Transakcji | Domyślna definicja transakcji dla tego Leada |
| Domyslna | `bool` | bazodanowe | Domyślna | Domyślna definicja leada. |
| FormularzUzytkownika | `bool` |  |  |  |
| InicjujNazwe | `bool` | bazodanowe | Inicjuje nazwę leada | Określa, czy lead ma zainicjowaną nazwę z definicji. |
| IsSource | `bool` | tylko-odczyt |  |  |
| KanbanColor | `string` | bazodanowe | Kolor | Kolor na tablicy Kanban. |
| NamePrefix | `string` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Pełna nazwa definicji leada. |
| NazwaZakladkiUz | `string` | bazodanowe | Nazwa zakładki użytkownika |  |
| Numeracja | `Soneta.Core.DefinicjaNumeracji` (subrow) | bazodanowe | Numeracja | Ustawienia określające sposób numeracji leadów. |
| Numeracja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numeracja.PodczasZapisu | `bool` |  |  |  |
| Numeracja.Separator | `string` | bazodanowe |  |  |
| Numeracja.Wzor | `string` | bazodanowe |  |  |
| OpisHTML | `bool` | bazodanowe | Opis w postaci HTML. | Określa, czy opis będzie w postaci HTML. |
| PlugIns | `SubTable` | podlista |  |  |
| PokazKomunikat | `bool` | bazodanowe |  | Decyduje o pokazywaniu komunikatu o kontrahencie podczas jego ustawianiu na dokument CRM. |
| Priorytety | `LpSubTable<Soneta.CRM.Config.PriorytetLeada>` | podlista |  |  |
| RodzajFormularza | `Soneta.CRM.RodzajFormularzaCrm` (enum) | bazodanowe | Rodzaj formularza | Rodzaj formularza. |
| RoleGuid | `System.Guid` | bazodanowe |  | Domyślna rola dla której przypisany zostanie lead. |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| Stany | `LpSubTable<Soneta.CRM.Config.StanLeada>` | podlista |  |  |
| Symbol | `string` | bazodanowe | Symbol | Skrótowa nazwa definicji leada wykorzystywana do wyszukiwania definicji oraz numeracji leadów CRM. |
| SysNotifications | `SubTable<Db.Notifications.SysNotification>` | podlista |  |  |
| TableName | `string` | tylko-odczyt |  |  |
| Temperatury | `LpSubTable<Soneta.CRM.Config.TemperaturaLeada>` | podlista |  |  |
| TypeFullName | `string` | tylko-odczyt |  |  |
| WFDefinition | `IWFDefinition` | tylko-odczyt, iface-ref |  |  |
| WfEngineCode | `MemoText` | bazodanowe, podlista |  |  |
| WfEngineCodeEditorSource | `Compiler.ICodeEditorSource` |  | Algorytm procesu | Algorytm procesu |
| WizardsRef | `LpSubTable<Db.Wizard.WizardReference>` | podlista |  |  |
| XmlForm | `MemoText` | bazodanowe, podlista | Definicja zakładki użytkownika. |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| WFDefinition | `IWFDefinition` | `WFDefinition` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajFormularzaCrm (`Soneta.CRM.RodzajFormularzaCrm`)
- `Podstawowy` = 1 — Podstawowy
- `Pelny` = 2 — Pełny
- `Uzytkownika` = 3 — Użytkownika

### CreateProcessType (`Soneta.Core.DbTuples.CreateProcessType`)
- `Default` = 0 — Podczas zapisu dokumentu
- `OnAdded` = 1 — Podczas dodawania dokumentu
