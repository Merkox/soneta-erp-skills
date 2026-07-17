# Pola i właściwości klasy biznesowej: `Soneta.CRM.Config.DefLeada`
Nazwa tabeli: `DefLeadow`
Tytuł: Definicje leadów CRM
Opis: Definicja typu leada CRM określająca jego parametry i zachowanie. Konfiguruje numerację, algorytmy, formularz użytkownika, uprawnienia, domyślną definicję transakcji oraz procesy workflow, stanowiąc wzorzec dla tworzenia leadów sprzedażowych.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`, `ISysNotificationHost`, `IWizardReferenceHost`, `IWfPlugInReferenceHost`, `IWFDefinitionHost`

- pola bazodanowe: 25
- pola kalkulowane (z klas biznesowych): 18

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `bool` | bazodanowe |  | Określa czy istnieje algorytm dla leada. |
| Blokada | `bool` | bazodanowe | Zablokowana | Określa zablokowanie definicji. |
| ClassName | `string` |  |  |  |
| Code | `Soneta.Business.MemoText` | bazodanowe | Kod kalkulatora dla leada | Kod klasy kalkulatora dla leada. |
| CreateProcess | `Soneta.Core.DbTuples.CreateProcessType` | bazodanowe, enum | Uruchom procesy |  |
| DataType | `System.Type` |  |  |  |
| DefinedTypeName | `string` |  |  |  |
| DefinicjaTransakcja | `Soneta.CRM.Config.DefTransakcja` | bazodanowe | Domyślna definicja Transakcji | Domyślna definicja transakcji dla tego Leada |
| Domyslna | `bool` | bazodanowe | Domyślna | Domyślna definicja leada. |
| FormularzUzytkownika | `bool` |  |  |  |
| InicjujNazwe | `bool` | bazodanowe | Inicjuje nazwę leada | Określa, czy lead ma zainicjowaną nazwę z definicji. |
| IsSource | `bool` |  |  |  |
| KanbanColor | `string` | bazodanowe | Kolor | Kolor na tablicy Kanban. |
| NamePrefix | `string` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Pełna nazwa definicji leada. |
| NazwaZakladkiUz | `string` | bazodanowe | Nazwa zakładki użytkownika |  |
| Numeracja | `Soneta.Core.DefinicjaNumeracji` | bazodanowe | Numeracja | Ustawienia określające sposób numeracji leadów. |
| Numeracja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numeracja.PodczasZapisu | `bool` |  |  |  |
| Numeracja.Separator | `string` | bazodanowe |  |  |
| Numeracja.Wzor | `string` | bazodanowe |  |  |
| OpisHTML | `bool` | bazodanowe | Opis w postaci HTML. | Określa, czy opis będzie w postaci HTML. |
| PlugIns | `Soneta.Business.SubTable` |  |  |  |
| PokazKomunikat | `bool` | bazodanowe |  | Decyduje o pokazywaniu komunikatu o kontrahencie podczas jego ustawianiu na dokument CRM. |
| Priorytety | `Soneta.Business.LpSubTable<Soneta.CRM.Config.PriorytetLeada>` |  |  |  |
| RodzajFormularza | `Soneta.CRM.RodzajFormularzaCrm` | bazodanowe, enum | Rodzaj formularza | Rodzaj formularza. |
| RoleGuid | `System.Guid` | bazodanowe |  | Domyślna rola dla której przypisany zostanie lead. |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| Stany | `Soneta.Business.LpSubTable<Soneta.CRM.Config.StanLeada>` |  |  |  |
| Symbol | `string` | bazodanowe | Symbol | Skrótowa nazwa definicji leada wykorzystywana do wyszukiwania definicji oraz numeracji leadów CRM. |
| SysNotifications | `Soneta.Business.SubTable<Soneta.Business.Db.Notifications.SysNotification>` |  |  |  |
| TableName | `string` |  |  |  |
| Temperatury | `Soneta.Business.LpSubTable<Soneta.CRM.Config.TemperaturaLeada>` |  |  |  |
| TypeFullName | `string` |  |  |  |
| WFDefinition | `Soneta.Business.IWFDefinition` | iface-ref |  |  |
| WfEngineCode | `Soneta.Business.MemoText` | bazodanowe |  |  |
| WfEngineCodeEditorSource | `Soneta.Business.Compiler.ICodeEditorSource` |  | Algorytm procesu | Algorytm procesu |
| WizardsRef | `Soneta.Business.LpSubTable<Soneta.Business.Db.Wizard.WizardReference>` |  |  |  |
| XmlForm | `Soneta.Business.MemoText` | bazodanowe | Definicja zakładki użytkownika. |  |

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
