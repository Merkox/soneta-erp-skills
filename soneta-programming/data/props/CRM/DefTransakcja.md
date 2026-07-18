# Pola i właściwości klasy biznesowej: `Soneta.CRM.Config.DefTransakcja`
Nazwa tabeli: `DefTransakcji`
Tytuł: Definicje transakcji CRM
Opis: Definicja typu transakcji CRM określająca jej parametry i zachowanie. Konfiguruje numerację, algorytmy kalkulacji, formularz użytkownika, uprawnienia i procesy workflow, stanowiąc wzorzec dla tworzenia transakcji sprzedażowych.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`, `ISysNotificationHost`, `IWizardReferenceHost`, `IWfPlugInReferenceHost`, `IWFDefinitionHost`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `bool` | bazodanowe |  | Określa czy istnieje algorytm dla transakcji. |
| Blokada | `bool` | bazodanowe | Zablokowana | Określa zablokowanie definicji. |
| ClassName | `string` | tylko-odczyt |  |  |
| Code | `MemoText` | bazodanowe, podlista | Kod kalkulatora dla transakcji | Kod klasy kalkulatora dla transakcji. |
| CreateProcess | `Soneta.Core.DbTuples.CreateProcessType` (enum) | bazodanowe | Uruchom procesy |  |
| DataType | `System.Type` | tylko-odczyt |  |  |
| DefinedTypeName | `string` | tylko-odczyt |  |  |
| Domyslna | `bool` | bazodanowe | Domyślna | Domyślna definicja transakcji. |
| FormularzUzytkownika | `bool` |  |  |  |
| InicjujNazwe | `bool` | bazodanowe | Inicjuje nazwę transakcji | Określa, czy transakcja ma zainicjowaną nazwę z definicji. |
| IsEnabled | `bool` | tylko-odczyt |  |  |
| IsSource | `bool` | tylko-odczyt |  |  |
| KanbanColor | `string` | bazodanowe | Kolor | Kolor na tablicy Kanban. |
| Key | `string` | tylko-odczyt |  |  |
| NamePrefix | `string` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Pełna nazwa definicji transakcji. |
| NazwaZakladkiUz | `string` | bazodanowe | Nazwa zakładki użytkownika |  |
| Numeracja | `Soneta.Core.DefinicjaNumeracji` (subrow) | bazodanowe | Numeracja | Ustawienia określające sposób numeracji transakcji. |
| Numeracja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numeracja.PodczasZapisu | `bool` |  |  |  |
| Numeracja.Separator | `string` | bazodanowe |  |  |
| Numeracja.Wzor | `string` | bazodanowe |  |  |
| OpisHTML | `bool` | bazodanowe | Opis w postaci HTML. | Określa, czy opis będzie w postaci HTML. |
| PlugIns | `SubTable` | podlista |  |  |
| PokazKomunikat | `bool` | bazodanowe |  | Decyduje o pokazywaniu komunikatu o kontrahencie podczas jego ustawianiu na dokument CRM. |
| Priorytety | `LpSubTable<Soneta.CRM.Config.PriorytetTransakcja>` | podlista |  |  |
| RodzajFormularza | `Soneta.CRM.RodzajFormularzaCrm` (enum) | bazodanowe | Rodzaj formularza | Rodzaj formularza. |
| RoleGuid | `System.Guid` | bazodanowe |  | Domyślna rola do której przypisana zostanie transakcja. |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| StanyTransakcji | `LpSubTable<Soneta.CRM.Config.StanTransakcji>` | podlista |  |  |
| Symbol | `string` | bazodanowe | Symbol | Skrótowa nazwa definicji transakcji wykorzystywana do wyszukiwania definicji oraz numeracji transakcji CRM. |
| SysNotifications | `SubTable<Db.Notifications.SysNotification>` | podlista |  |  |
| TableName | `string` | tylko-odczyt |  |  |
| Temperatury | `LpSubTable<Soneta.CRM.Config.TemperaturaTransakcji>` | podlista |  |  |
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
