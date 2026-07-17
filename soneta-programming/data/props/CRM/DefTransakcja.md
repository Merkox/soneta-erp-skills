# Pola i właściwości klasy biznesowej: `Soneta.CRM.Config.DefTransakcja`
Nazwa tabeli: `DefTransakcji`
Tytuł: Definicje transakcji CRM
Opis: Definicja typu transakcji CRM określająca jej parametry i zachowanie. Konfiguruje numerację, algorytmy kalkulacji, formularz użytkownika, uprawnienia i procesy workflow, stanowiąc wzorzec dla tworzenia transakcji sprzedażowych.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`, `ISysNotificationHost`, `IWizardReferenceHost`, `IWfPlugInReferenceHost`, `IWFDefinitionHost`

- pola bazodanowe: 24
- pola kalkulowane (z klas biznesowych): 20

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `bool` | bazodanowe |  | Określa czy istnieje algorytm dla transakcji. |
| Blokada | `bool` | bazodanowe | Zablokowana | Określa zablokowanie definicji. |
| ClassName | `string` |  |  |  |
| Code | `Soneta.Business.MemoText` | bazodanowe | Kod kalkulatora dla transakcji | Kod klasy kalkulatora dla transakcji. |
| CreateProcess | `Soneta.Core.DbTuples.CreateProcessType` | bazodanowe, enum | Uruchom procesy |  |
| DataType | `System.Type` |  |  |  |
| DefinedTypeName | `string` |  |  |  |
| Domyslna | `bool` | bazodanowe | Domyślna | Domyślna definicja transakcji. |
| FormularzUzytkownika | `bool` |  |  |  |
| InicjujNazwe | `bool` | bazodanowe | Inicjuje nazwę transakcji | Określa, czy transakcja ma zainicjowaną nazwę z definicji. |
| IsEnabled | `bool` |  |  |  |
| IsSource | `bool` |  |  |  |
| KanbanColor | `string` | bazodanowe | Kolor | Kolor na tablicy Kanban. |
| Key | `string` |  |  |  |
| NamePrefix | `string` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Pełna nazwa definicji transakcji. |
| NazwaZakladkiUz | `string` | bazodanowe | Nazwa zakładki użytkownika |  |
| Numeracja | `Soneta.Core.DefinicjaNumeracji` | bazodanowe | Numeracja | Ustawienia określające sposób numeracji transakcji. |
| Numeracja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numeracja.PodczasZapisu | `bool` |  |  |  |
| Numeracja.Separator | `string` | bazodanowe |  |  |
| Numeracja.Wzor | `string` | bazodanowe |  |  |
| OpisHTML | `bool` | bazodanowe | Opis w postaci HTML. | Określa, czy opis będzie w postaci HTML. |
| PlugIns | `Soneta.Business.SubTable` |  |  |  |
| PokazKomunikat | `bool` | bazodanowe |  | Decyduje o pokazywaniu komunikatu o kontrahencie podczas jego ustawianiu na dokument CRM. |
| Priorytety | `Soneta.Business.LpSubTable<Soneta.CRM.Config.PriorytetTransakcja>` |  |  |  |
| RodzajFormularza | `Soneta.CRM.RodzajFormularzaCrm` | bazodanowe, enum | Rodzaj formularza | Rodzaj formularza. |
| RoleGuid | `System.Guid` | bazodanowe |  | Domyślna rola do której przypisana zostanie transakcja. |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| StanyTransakcji | `Soneta.Business.LpSubTable<Soneta.CRM.Config.StanTransakcji>` |  |  |  |
| Symbol | `string` | bazodanowe | Symbol | Skrótowa nazwa definicji transakcji wykorzystywana do wyszukiwania definicji oraz numeracji transakcji CRM. |
| SysNotifications | `Soneta.Business.SubTable<Soneta.Business.Db.Notifications.SysNotification>` |  |  |  |
| TableName | `string` |  |  |  |
| Temperatury | `Soneta.Business.LpSubTable<Soneta.CRM.Config.TemperaturaTransakcji>` |  |  |  |
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
