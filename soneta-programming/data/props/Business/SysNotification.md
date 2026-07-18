# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.Notifications.SysNotification`
Nazwa tabeli: `SysNotifications`
Tytuł: Powiadomienia
Opis: Definicja powiadomienia systemowego powiązanego z zadaniem lub procesem. Konfiguruje okoliczność, opóźnienie, odbiorcę, szablon i algorytm wyzwalania powiadomienia.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IWfPlugInItemReferenceHost`, `IWFRecipientHost`
Selektor: pole `DefinitionType` (`Db.DefinitionTypeEnum`) — wiele typów w jednej tabeli, podtypów: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CanCreateSysNotificationCode | `Db.AlgorithmColumn` (subrow) | bazodanowe | Kod metody CanCreateSysNotification | Określa algorytm metody CanCreateSysNotification |
| CanCreateSysNotificationCode.Code | `MemoText` | bazodanowe, podlista |  |  |
| CanCreateSysNotificationCode.CodeUiRoslyn | `Compiler.ICodeEditorSource` |  |  |  |
| DefinitionType | `Db.DefinitionTypeEnum` (enum) | bazodanowe, tylko-odczyt, selektor | Tryb edycji | Określa tryb edycji definicji workflow |
| DelayUnit | `Db.Notifications.SysNotificationDelayUnit` (enum) | bazodanowe | Typ opóźnienia | Określa typ opóźnienia |
| DelayValue | `int` | bazodanowe | Wartość opóźnienia | Określa wartość opóźnienia |
| ErrorReaction | `Db.Notifications.SysNotificationErrorReactionType` (enum) | bazodanowe | Reakcja na błąd | Określa sposób reakcji na błąd w wysyłce powiadomienia |
| ExcludedErrorMessages | `string[]` | podlista |  |  |
| Fact | `Db.Notifications.SysNotificationFact` (enum) | bazodanowe | Okoliczność | Określa okoliczność wystąpienia powiadomienia |
| Finalization | `Db.Notifications.SysNotificationFinalization` (enum) | bazodanowe | Zakończenie | Określa kiedy automatycznie zakończyć powiadomienie |
| ForTaskDefinition | `bool` | tylko-odczyt |  |  |
| FormattedName | `string` | bazodanowe | Nazwa formatowana | Ogólne |
| GetRecipientsExpressionCode | `Db.AlgorithmColumn` (subrow) | bazodanowe | Kod metody GetRecipientsExpression | Określa algorytm metody GetRecipientsExpression |
| GetSysNotificationContentCode | `Db.AlgorithmColumn` (subrow) | bazodanowe | Kod metody GetSysNotificationContent | Określa algorytm metody GetSysNotificationContent |
| Group | `string` | bazodanowe | Typ odbiorcy - grupa | Określa typ odbiorcy jako grupa |
| Host | `ISysNotificationHost` | bazodanowe, tylko-odczyt, iface-ref | Powiadomienie dla |  |
| Locked | `bool` | bazodanowe | Zablokowany |  |
| Mode | `Db.Notifications.SysNotification.NotificationMode` (enum) | tylko-odczyt |  |  |
| Name | `string` | bazodanowe | Nazwa | Ogólne |
| Node | `IElementStrukturyOrganizacyjnej` | bazodanowe, iface-ref |  |  |
| NotificationType | `Db.TaskDefinition` | bazodanowe | Typ powiadomienia | Definicja zadania określającego typ powiadomienia. |
| OrgStructure | `IStrukturaOrganizacyjna` | bazodanowe, iface-ref |  |  |
| RecipientType | `Db.Notifications.SysNotificationRecipientType` (enum) | bazodanowe | Typ odbiorcy | Określa typ odbiorcy |
| References | `SubTable<Db.Notifications.SysNotificationRef>` | podlista |  |  |
| Role | `string` | bazodanowe | Typ odbiorcy - rola | Określa typ odbiorcy jako rola |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| TaskDefinition | `Db.TaskDefinition` | bazodanowe | Definicja zadania | Definicja zadania, do której przypisane jest powiadomienie. |
| Template | `ITemplate` | bazodanowe, iface-ref | Szablon powiadomienia | Określa szablon powiadomienia |
| WfDefinition | `IWFDefinition` | bazodanowe, iface-ref | Definicja procesu | Określa definicję procesu |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `DefinitionType`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Standard` | 0 | `Db.Notifications.SysNotification` |  |
| `Engine` | 1 | `Soneta.Workflow.Config.WfSysNotificationExtend` | Powiadomienie jednozakładkowe |
| `None` | 2 | `Db.Notifications.SysNotification` |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `ISysNotificationHost` | `DbTupleDefinition`, `DefLeada`, `DefProjektu`, `DefTransakcja`, `DefZadania`, `TaskDefinition` |
| Node | `IElementStrukturyOrganizacyjnej` | `ElementStrukturyOrganizacyjnej` |
| OrgStructure | `IStrukturaOrganizacyjna` | `StrukturaOrganizacyjna` |
| Template | `ITemplate` | `SzablonEmail`, `SzablonSms` |
| WfDefinition | `IWFDefinition` | `WFDefinition` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DefinitionTypeEnum (`Db.DefinitionTypeEnum`)
- `Standard` = 0 — Wielozakładkowy
- `Engine` = 1 — Jednozakładkowy
- `None` = 2 — Brak

### NotificationMode (`Db.Notifications.SysNotification.NotificationMode`)
- `System` = 0
- `Email` = 1
- `Sms` = 2

### SysNotificationDelayUnit (`Db.Notifications.SysNotificationDelayUnit`)
- `Hours` = 0 — Godziny
- `Days` = 1 — Dni

### SysNotificationErrorReactionType (`Db.Notifications.SysNotificationErrorReactionType`)
- `ThrowError` = 0 — Wstrzymaj wykonanie zadania
- `GenerateSystemNotification` = 1 — Wykonaj zadanie z powiadomieniem systemowym
- `None` = 2 — Wykonaj zadanie bez powiadomień

### SysNotificationFact (`Db.Notifications.SysNotificationFact`)
- `OnCreate` = 0 — Utworzenie
- `OnRealize` = 1 — Realizacja
- `OnDelayedTime` = 2 — Opóźnione w czasie

### SysNotificationFinalization (`Db.Notifications.SysNotificationFinalization`)
- `Never` = 0 — Nigdy
- `OnTaskTerminated` = 1 — Na przerwanie zadania
- `OnTaskRealized` = 2 — Na wykonanie zadania
- `OnTaskFinalized` = 3 — Na zakończenie zadania
- `OnProcessFinalized` = 4 — Na zakończenie procesu

### SysNotificationRecipientType (`Db.Notifications.SysNotificationRecipientType`)
- `TaskRecipient` = 0 — Adresat zadania
- `ProcessOwner` = 1 — Opiekun procesu
- `ObjectCreator` = 2 — Tworzący obiekt
- `ObjectModifier` = 3 — Modyfikujący obiekt
- `Recipients` = 4 — Grupa
- `Role` = 5 — Rola
- `Expression` = 6 — Wyrażenie
- `Node` = 7 — Element struktury organizacyjnej
