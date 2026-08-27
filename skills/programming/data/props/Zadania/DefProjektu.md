# Pola i właściwości klasy biznesowej: `Soneta.Zadania.DefProjektu`
Nazwa tabeli: `DefProjektow`
Tytuł: Definicje projektów CRM
Opis: Szablon projektu CRM określający numerację, kontrolę dat i stanów, budżetowanie oraz domyślne parametry dokumentów handlowych. Stanowi bazę konfiguracyjną dla tworzenia nowych projektów.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`, `ISysNotificationHost`, `IWizardReferenceHost`, `IWfPlugInReferenceHost`, `IWFDefinitionHost`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `bool` | bazodanowe |  | Określa czy istnieje algorytm dla zadania. |
| AlgorytmNazwyIOpisu | `MemoText` | bazodanowe, podlista | Kod kalkulatora dla nazwy i opisu projektu w kalendarzu | Kod kalkulatora dla nazwy i opisu projektu w kalendarzu. |
| Blokada | `bool` | bazodanowe | Zablokowana | Określa zablokowanie definicji. Zablokowane definicje dokumentów nie będą wyświetlane w liście wyboru. |
| ClassName | `string` | tylko-odczyt |  |  |
| Code | `MemoText` | bazodanowe, podlista | Kod kalkulatora dla zadania | Kod klasy kalkulatora dla zadania. |
| CreateProcess | `Soneta.Core.DbTuples.CreateProcessType` (enum) | bazodanowe | Uruchom procesy |  |
| DataType | `System.Type` | tylko-odczyt |  |  |
| DefBudgets | `Soneta.Zadania.Budzetowanie.DefBudget[]` | podlista |  |  |
| DefaultDefBudget | `Soneta.Zadania.Budzetowanie.DefBudget` |  |  |  |
| DefinedTypeName | `string` | tylko-odczyt |  |  |
| DefinicjaDokHandlowego | `Soneta.Handel.DefDokHandlowego` | bazodanowe | Definicja dokumentu handlowego | Domyślna definicja dokumentu handlowego generowanego dla tego projektu |
| DefinicjaDokZapotrzebowania | `Soneta.Handel.DefDokHandlowego` | bazodanowe | Definicja dokumentu zapotrzebowania | Domyślna definicja dokumentu zapotrzebowania generowanego dla tego projektu |
| DefinicjeBudzetow | `string` | bazodanowe |  | Lista definicji budżetów przypisanych do projektu. |
| DlaUprawnienia | `bool` |  |  |  |
| Domyslna | `bool` | bazodanowe | Domyślna | Określa, że jest to domyślna definicja projektu |
| EntitleGuid | `System.Guid` | bazodanowe |  | Domyślne uprawnienie dla którego przypisane jest zadanie. |
| EtapyDefProjektu | `LpSubTable<Soneta.Zadania.EtapDefProjektu>` | podlista |  |  |
| FormularzUzytkownika | `bool` | bazodanowe | Formularz użytkownika | Formularz użytkownika. |
| IsEnabled | `bool` | tylko-odczyt |  |  |
| IsSource | `bool` | tylko-odczyt |  |  |
| IsVisibleBudgetConfiguration | `bool` | tylko-odczyt |  |  |
| Key | `string` | tylko-odczyt |  |  |
| Kod | `string` | tylko-odczyt |  |  |
| KontrolaDat | `Soneta.Core.TypKontroli` (enum) | bazodanowe | Typ kontroli dat | Określa typ kontroli dat na projekcie. |
| KontrolaStanu | `Soneta.Core.TypKontroli` (enum) | bazodanowe | Typ kontroli stanu | Określa typ kontroli stanu na projekcie. |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe | Domyślny magazyn | Określa, domyślny magazyn. |
| NamePrefix | `string` | tylko-odczyt |  |  |
| Namespace | `string` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Pełna nazwa definicji projektu. |
| NazwaZakladkiUz | `string` | bazodanowe | Nazwa zakładki użytkownika |  |
| Numeracja | `Soneta.Core.DefinicjaNumeracji` (subrow) | bazodanowe | Numeracja | Ustawienia określające sposób numeracji projektów. |
| Numeracja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numeracja.PodczasZapisu | `bool` |  |  |  |
| Numeracja.Separator | `string` | bazodanowe |  |  |
| Numeracja.Wzor | `string` | bazodanowe |  |  |
| PlugIns | `SubTable` | podlista |  |  |
| PokazKomunikat | `bool` | bazodanowe |  | Decyduje o pokazywaniu komunikatu o kontrahencie podczas jego ustawianiu na dokument CRM. |
| Rozliczaj | `bool` | bazodanowe | Rozliczaj |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| StageOverlap | `bool` | bazodanowe | Nachodzenie etapów |  |
| Stany | `LpSubTable<Soneta.Zadania.StanProjektu>` | podlista |  |  |
| Symbol | `string` | bazodanowe | Symbol | Skrótowa nazwa definicji projektu wykorzystywana do wyszukiwania definicji oraz numeracji projektów CRM. |
| SysNotifications | `SubTable<Db.Notifications.SysNotification>` | podlista |  |  |
| TableName | `string` | tylko-odczyt |  |  |
| TypZaokraglenia | `Soneta.Zadania.TypZaokraglenia` (enum) | bazodanowe |  | Określa rodzaj zaokrąglenia. |
| TypeFullName | `string` | tylko-odczyt |  |  |
| UprawnieniaNaAktywnosciach | `bool` | tylko-odczyt |  |  |
| Uprawnienie | `App.Entitle` |  |  |  |
| WFDefinition | `Soneta.Workflow.Config.WFDefinitionExtend` | tylko-odczyt |  |  |
| WfEngineCode | `MemoText` | bazodanowe, podlista |  |  |
| WfEngineCodeEditorSource | `Compiler.ICodeEditorSource` |  | Algorytm procesu | Algorytm procesu |
| WizardsRef | `LpSubTable<Db.Wizard.WizardReference>` | podlista |  |  |
| XmlForm | `MemoText` | bazodanowe, podlista | Definicja zakładki użytkownika. |  |
| ZapisNaBiezaco | `bool` | bazodanowe | Zapis na bieżąco sesji | Jeśli możliwe, sesja zostanie zapisana najszybciej jak to możliwe. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### CreateProcessType (`Soneta.Core.DbTuples.CreateProcessType`)
- `Default` = 0 — Podczas zapisu dokumentu
- `OnAdded` = 1 — Podczas dodawania dokumentu

### TypKontroli (`Soneta.Core.TypKontroli`)
- `Brak` = 0 — Brak
- `Ostrzegaj` = 1
- `Zabraniaj` = 2

### TypZaokraglenia (`Soneta.Zadania.TypZaokraglenia`)
- `Gora` = 0 — W górę
- `Dol` = 1 — W dół
- `DoBliskiejWartosci` = 2 — Do najbliższej wartości
- `Proporcjonalnie` = 3 — Proporcjonalnie
