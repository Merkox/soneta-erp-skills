# Pola i właściwości klasy biznesowej: `Soneta.Zadania.DefProjektu`
Nazwa tabeli: `DefProjektow`
Tytuł: Definicje projektów CRM
Opis: Szablon projektu CRM określający numerację, kontrolę dat i stanów, budżetowanie oraz domyślne parametry dokumentów handlowych. Stanowi bazę konfiguracyjną dla tworzenia nowych projektów.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`, `ISysNotificationHost`, `IWizardReferenceHost`, `IWfPlugInReferenceHost`, `IWFDefinitionHost`

- pola bazodanowe: 32
- pola kalkulowane (z klas biznesowych): 26

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `bool` | bazodanowe |  | Określa czy istnieje algorytm dla zadania. |
| AlgorytmNazwyIOpisu | `Soneta.Business.MemoText` | bazodanowe | Kod kalkulatora dla nazwy i opisu projektu w kalendarzu | Kod kalkulatora dla nazwy i opisu projektu w kalendarzu. |
| Blokada | `bool` | bazodanowe | Zablokowana | Określa zablokowanie definicji. Zablokowane definicje dokumentów nie będą wyświetlane w liście wyboru. |
| ClassName | `string` |  |  |  |
| Code | `Soneta.Business.MemoText` | bazodanowe | Kod kalkulatora dla zadania | Kod klasy kalkulatora dla zadania. |
| CreateProcess | `Soneta.Core.DbTuples.CreateProcessType` | bazodanowe, enum | Uruchom procesy |  |
| DataType | `System.Type` |  |  |  |
| DefBudgets | `Soneta.Zadania.Budzetowanie.DefBudget[]` |  |  |  |
| DefaultDefBudget | `Soneta.Zadania.Budzetowanie.DefBudget` |  |  |  |
| DefinedTypeName | `string` |  |  |  |
| DefinicjaDokHandlowego | `Soneta.Handel.DefDokHandlowego` | bazodanowe | Definicja dokumentu handlowego | Domyślna definicja dokumentu handlowego generowanego dla tego projektu |
| DefinicjaDokZapotrzebowania | `Soneta.Handel.DefDokHandlowego` | bazodanowe | Definicja dokumentu zapotrzebowania | Domyślna definicja dokumentu zapotrzebowania generowanego dla tego projektu |
| DefinicjeBudzetow | `string` | bazodanowe |  | Lista definicji budżetów przypisanych do projektu. |
| DlaUprawnienia | `bool` |  |  |  |
| Domyslna | `bool` | bazodanowe | Domyślna | Określa, że jest to domyślna definicja projektu |
| EntitleGuid | `System.Guid` | bazodanowe |  | Domyślne uprawnienie dla którego przypisane jest zadanie. |
| EtapyDefProjektu | `Soneta.Business.LpSubTable<Soneta.Zadania.EtapDefProjektu>` |  |  |  |
| FormularzUzytkownika | `bool` | bazodanowe | Formularz użytkownika | Formularz użytkownika. |
| IsEnabled | `bool` |  |  |  |
| IsSource | `bool` |  |  |  |
| IsVisibleBudgetConfiguration | `bool` |  |  |  |
| Key | `string` |  |  |  |
| Kod | `string` |  |  |  |
| KontrolaDat | `Soneta.Core.TypKontroli` | bazodanowe, enum | Typ kontroli dat | Określa typ kontroli dat na projekcie. |
| KontrolaStanu | `Soneta.Core.TypKontroli` | bazodanowe, enum | Typ kontroli stanu | Określa typ kontroli stanu na projekcie. |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe | Domyślny magazyn | Określa, domyślny magazyn. |
| NamePrefix | `string` |  |  |  |
| Namespace | `string` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Pełna nazwa definicji projektu. |
| NazwaZakladkiUz | `string` | bazodanowe | Nazwa zakładki użytkownika |  |
| Numeracja | `Soneta.Core.DefinicjaNumeracji` | bazodanowe | Numeracja | Ustawienia określające sposób numeracji projektów. |
| Numeracja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numeracja.PodczasZapisu | `bool` |  |  |  |
| Numeracja.Separator | `string` | bazodanowe |  |  |
| Numeracja.Wzor | `string` | bazodanowe |  |  |
| PlugIns | `Soneta.Business.SubTable` |  |  |  |
| PokazKomunikat | `bool` | bazodanowe |  | Decyduje o pokazywaniu komunikatu o kontrahencie podczas jego ustawianiu na dokument CRM. |
| Rozliczaj | `bool` | bazodanowe | Rozliczaj |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| StageOverlap | `bool` | bazodanowe | Nachodzenie etapów |  |
| Stany | `Soneta.Business.LpSubTable<Soneta.Zadania.StanProjektu>` |  |  |  |
| Symbol | `string` | bazodanowe | Symbol | Skrótowa nazwa definicji projektu wykorzystywana do wyszukiwania definicji oraz numeracji projektów CRM. |
| SysNotifications | `Soneta.Business.SubTable<Soneta.Business.Db.Notifications.SysNotification>` |  |  |  |
| TableName | `string` |  |  |  |
| TypZaokraglenia | `Soneta.Zadania.TypZaokraglenia` | bazodanowe, enum |  | Określa rodzaj zaokrąglenia. |
| TypeFullName | `string` |  |  |  |
| UprawnieniaNaAktywnosciach | `bool` |  |  |  |
| Uprawnienie | `Soneta.Business.App.Entitle` |  |  |  |
| WFDefinition | `Soneta.Workflow.Config.WFDefinitionExtend` |  |  |  |
| WfEngineCode | `Soneta.Business.MemoText` | bazodanowe |  |  |
| WfEngineCodeEditorSource | `Soneta.Business.Compiler.ICodeEditorSource` |  | Algorytm procesu | Algorytm procesu |
| WizardsRef | `Soneta.Business.LpSubTable<Soneta.Business.Db.Wizard.WizardReference>` |  |  |  |
| XmlForm | `Soneta.Business.MemoText` | bazodanowe | Definicja zakładki użytkownika. |  |
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
