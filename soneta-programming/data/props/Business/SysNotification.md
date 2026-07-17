# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.Notifications.SysNotification`
Nazwa tabeli: `SysNotifications`
Tytuł: Powiadomienia
Opis: Definicja powiadomienia systemowego powiązanego z zadaniem lub procesem. Konfiguruje okoliczność, opóźnienie, odbiorcę, szablon i algorytm wyzwalania powiadomienia.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IWfPlugInItemReferenceHost`, `IWFRecipientHost`

- pola bazodanowe: 27
- pola kalkulowane (z klas biznesowych): 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CanCreateSysNotificationCode | `Soneta.Business.Db.AlgorithmColumn` | bazodanowe | Kod metody CanCreateSysNotification | Określa algorytm metody CanCreateSysNotification |
| CanCreateSysNotificationCode.Code | `Soneta.Business.MemoText` | bazodanowe |  |  |
| CanCreateSysNotificationCode.CodeUi | `string` |  |  |  |
| CanCreateSysNotificationCode.CodeUiRoslyn | `Soneta.Business.Compiler.ICodeEditorSource` |  |  |  |
| DefinitionType | `Soneta.Business.Db.DefinitionTypeEnum` | bazodanowe, enum | Tryb edycji | Określa tryb edycji definicji workflow |
| DelayUnit | `Soneta.Business.Db.Notifications.SysNotificationDelayUnit` | bazodanowe, enum | Typ opóźnienia | Określa typ opóźnienia |
| DelayValue | `int` | bazodanowe | Wartość opóźnienia | Określa wartość opóźnienia |
| ErrorReaction | `Soneta.Business.Db.Notifications.SysNotificationErrorReactionType` | bazodanowe, enum | Reakcja na błąd | Określa sposób reakcji na błąd w wysyłce powiadomienia |
| ExcludedErrorMessages | `string[]` |  |  |  |
| Fact | `Soneta.Business.Db.Notifications.SysNotificationFact` | bazodanowe, enum | Okoliczność | Określa okoliczność wystąpienia powiadomienia |
| Finalization | `Soneta.Business.Db.Notifications.SysNotificationFinalization` | bazodanowe, enum | Zakończenie | Określa kiedy automatycznie zakończyć powiadomienie |
| ForTaskDefinition | `bool` |  |  |  |
| FormattedName | `string` | bazodanowe | Nazwa formatowana | Ogólne |
| GetRecipientsExpressionCode | `Soneta.Business.Db.AlgorithmColumn` | bazodanowe | Kod metody GetRecipientsExpression | Określa algorytm metody GetRecipientsExpression |
| GetSysNotificationContentCode | `Soneta.Business.Db.AlgorithmColumn` | bazodanowe | Kod metody GetSysNotificationContent | Określa algorytm metody GetSysNotificationContent |
| Group | `string` | bazodanowe | Typ odbiorcy - grupa | Określa typ odbiorcy jako grupa |
| Host | `Soneta.Business.ISysNotificationHost` | bazodanowe, iface-ref | Powiadomienie dla |  |
| IsVisibleGroupRecipientType | `bool` |  |  |  |
| IsVisibleRoleRecipientType | `bool` |  |  |  |
| Locked | `bool` | bazodanowe | Zablokowany |  |
| Mode | `Soneta.Business.Db.Notifications.SysNotification.NotificationMode` | enum |  |  |
| Name | `string` | bazodanowe | Nazwa | Ogólne |
| Node | `Soneta.Business.IElementStrukturyOrganizacyjnej` | bazodanowe, iface-ref |  |  |
| NotificationType | `Soneta.Business.Db.TaskDefinition` | bazodanowe | Typ powiadomienia | Definicja zadania określającego typ powiadomienia. |
| OrgStructure | `Soneta.Business.IStrukturaOrganizacyjna` | bazodanowe, iface-ref |  |  |
| RecipientType | `Soneta.Business.Db.Notifications.SysNotificationRecipientType` | bazodanowe, enum | Typ odbiorcy | Określa typ odbiorcy |
| References | `Soneta.Business.SubTable<Soneta.Business.Db.Notifications.SysNotificationRef>` |  |  |  |
| Role | `string` | bazodanowe | Typ odbiorcy - rola | Określa typ odbiorcy jako rola |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| TaskDefinition | `Soneta.Business.Db.TaskDefinition` | bazodanowe | Definicja zadania | Definicja zadania, do której przypisane jest powiadomienie. |
| Template | `Soneta.Business.ITemplate` | bazodanowe, iface-ref | Szablon powiadomienia | Określa szablon powiadomienia |
| WfDefinition | `Soneta.Business.IWFDefinition` | bazodanowe, iface-ref | Definicja procesu | Określa definicję procesu |

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

### DefinitionTypeEnum (`Soneta.Business.Db.DefinitionTypeEnum`)
- `Standard` = 0 — Wielozakładkowy
- `Engine` = 1 — Jednozakładkowy
- `None` = 2 — Brak

### NotificationMode (`Soneta.Business.Db.Notifications.SysNotification.NotificationMode`)
- `System` = 0
- `Email` = 1
- `Sms` = 2

### SysNotificationDelayUnit (`Soneta.Business.Db.Notifications.SysNotificationDelayUnit`)
- `Hours` = 0 — Godziny
- `Days` = 1 — Dni

### SysNotificationErrorReactionType (`Soneta.Business.Db.Notifications.SysNotificationErrorReactionType`)
- `ThrowError` = 0 — Wstrzymaj wykonanie zadania
- `GenerateSystemNotification` = 1 — Wykonaj zadanie z powiadomieniem systemowym
- `None` = 2 — Wykonaj zadanie bez powiadomień

### SysNotificationFact (`Soneta.Business.Db.Notifications.SysNotificationFact`)
- `OnCreate` = 0 — Utworzenie
- `OnRealize` = 1 — Realizacja
- `OnDelayedTime` = 2 — Opóźnione w czasie

### SysNotificationFinalization (`Soneta.Business.Db.Notifications.SysNotificationFinalization`)
- `Never` = 0 — Nigdy
- `OnTaskTerminated` = 1 — Na przerwanie zadania
- `OnTaskRealized` = 2 — Na wykonanie zadania
- `OnTaskFinalized` = 3 — Na zakończenie zadania
- `OnProcessFinalized` = 4 — Na zakończenie procesu

### SysNotificationRecipientType (`Soneta.Business.Db.Notifications.SysNotificationRecipientType`)
- `TaskRecipient` = 0 — Adresat zadania
- `ProcessOwner` = 1 — Opiekun procesu
- `ObjectCreator` = 2 — Tworzący obiekt
- `ObjectModifier` = 3 — Modyfikujący obiekt
- `Recipients` = 4 — Grupa
- `Role` = 5 — Rola
- `Expression` = 6 — Wyrażenie
- `Node` = 7 — Element struktury organizacyjnej
