# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Config.WfPlugInItem`
Nazwa tabeli: `WfPlugInItems`
Tytuł: Wtyczki elementów procesu
Opis: Wtyczka rozszerzająca pojedynczy element (zadanie lub tranzycję) procesu workflow. Definiuje nazwę, typ, interfejs wymaganego obiektu zarządzanego oraz konfigurację specyficzną dla danego kroku. Jest podrzędna wobec wtyczki definicji procesu (WfPlugIn).
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IWfPlugInItemHost`

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ConfigCode | `Soneta.Business.MemoText` | bazodanowe |  |  |
| ConfigXml | `Soneta.Business.MemoText` | bazodanowe |  |  |
| ContentInfo | `string` |  |  |  |
| DataType | `System.Type` |  |  |  |
| DataTypeFullName | `string` |  |  |  |
| Description | `Soneta.Business.MemoText` | bazodanowe | Opis |  |
| FullName | `string` |  |  |  |
| IconName | `string` |  |  |  |
| Interface | `string` | bazodanowe | Interfejs | Interfejs wymagane od klasy obiektu zarządzanego |
| Items | `Soneta.Business.SubTable<Soneta.Workflow.Config.WfPlugInItem>` |  |  |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa tranzycji |
| PlugIn | `Soneta.Workflow.Config.IWfPlugInItemHost` | bazodanowe, iface-ref |  |  |
| TableName | `string` | bazodanowe | Klasa | Klasa obiektu nadrzędanego. |
| Type | `Soneta.Business.WfPlugInItemType` | bazodanowe, enum |  |  |
| VariantTypeName | `string` | bazodanowe | Typ wtyczki wielowariantowej | Typ wtyczki wielowariantowej |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| PlugIn | `IWfPlugInItemHost` | `WfPlugIn`, `WfPlugInItem` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### WfPlugInItemType (`Soneta.Business.WfPlugInItemType`)
- `Task` = 1 — Zadanie
- `Transition` = 2 — Przejście
- `ProcessRole` = 3 — Role procesowa
- `TaskTrigger` = 4 — Wyzwalacz zadania
- `TaskSource` = 5 — Źródło zadania
- `SysNotification` = 6 — Powiadomienie
