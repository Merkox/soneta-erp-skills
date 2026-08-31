# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Config.WfPlugInItem`
Nazwa tabeli: `WfPlugInItems`
Tytuł: Wtyczki elementów procesu
Opis: Wtyczka rozszerzająca pojedynczy element (zadanie lub tranzycję) procesu workflow. Definiuje nazwę, typ, interfejs wymaganego obiektu zarządzanego oraz konfigurację specyficzną dla danego kroku. Jest podrzędna wobec wtyczki definicji procesu (WfPlugIn).
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IWfPlugInItemHost`
Selektor: pole `Type` (`WfPlugInItemType`) — wiele typów w jednej tabeli, podtypów: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ConfigCode | `MemoText` | bazodanowe, podlista |  |  |
| ConfigXml | `MemoText` | bazodanowe, podlista |  |  |
| ContentInfo | `string` | tylko-odczyt |  |  |
| DataType | `System.Type` | tylko-odczyt |  |  |
| DataTypeFullName | `string` | tylko-odczyt |  |  |
| Description | `MemoText` | bazodanowe, podlista | Opis |  |
| FullName | `string` | tylko-odczyt |  |  |
| IconName | `string` | tylko-odczyt |  |  |
| Interface | `string` | bazodanowe | Interfejs | Interfejs wymagane od klasy obiektu zarządzanego |
| Items | `SubTable<Soneta.Workflow.Config.WfPlugInItem>` | podlista |  |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa tranzycji |
| PlugIn | `Soneta.Workflow.Config.IWfPlugInItemHost` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| TableName | `string` | bazodanowe, tylko-odczyt | Klasa | Klasa obiektu nadrzędanego. |
| Type | `WfPlugInItemType` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| VariantTypeName | `string` | bazodanowe | Typ wtyczki wielowariantowej | Typ wtyczki wielowariantowej |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Type`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Task` | 1 | `Soneta.Workflow.Config.WfTaskPlugIn` | Zadanie |
| `Transition` | 2 | `Soneta.Workflow.Config.WfTransitionPlugIn` | Przejście |
| `ProcessRole` | 3 | `Soneta.Workflow.Config.WfProcessRolePlugIn` | Rola procesowa |
| `TaskTrigger` | 4 | `Soneta.Workflow.Config.WfTaskTriggerPlugIn` | Wyzwalacz zadania |
| `TaskSource` | 5 | `Soneta.Workflow.Config.WfTaskSourcePlugIn` | Źródło zadania |
| `SysNotification` | 6 | `Soneta.Workflow.Config.WfSysNotificationPlugIn` | Powiadomienie |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| PlugIn | `IWfPlugInItemHost` | `WfPlugIn`, `WfPlugInItem` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### WfPlugInItemType (`WfPlugInItemType`)
- `Task` = 1 — Zadanie
- `Transition` = 2 — Przejście
- `ProcessRole` = 3 — Role procesowa
- `TaskTrigger` = 4 — Wyzwalacz zadania
- `TaskSource` = 5 — Źródło zadania
- `SysNotification` = 6 — Powiadomienie
