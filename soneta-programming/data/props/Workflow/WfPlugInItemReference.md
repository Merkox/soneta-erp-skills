# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Config.WfPlugInItemReference`
Nazwa tabeli: `WfPlugInItemsRef`
Tytuł: Powiązania wtyczek elementów procesów
Opis: Element szczegółowy hosta wtyczek elementów (IWfPlugInItemReferenceHost). Powiązanie między elementem procesu (zadaniem, tranzycją) a wtyczką elementu (WfPlugInItem) z priorytetem wykonania i możliwością blokady. Obsługuje również przypisywanie odbiorców kroku.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Host` → `IWfPlugInItemReferenceHost`
Implementuje interfejsy: `IWFRecipientHost`

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Config | `Soneta.Workflow.Config.PlugInItemConfig` |  |  |  |
| ConfigXml | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Host | `Soneta.Business.IWfPlugInItemReferenceHost` | bazodanowe, guided-parent, iface-ref | Wtyczka dla |  |
| Locked | `bool` | bazodanowe |  |  |
| Managed | `bool` | bazodanowe |  |  |
| PlugIn | `Soneta.Workflow.Config.WfPlugInItem` | bazodanowe |  |  |
| Priority | `int` | bazodanowe |  |  |
| WFRecipients | `Soneta.Business.SubTable<Soneta.Workflow.Config.WFRecipient>` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IWfPlugInItemReferenceHost` | `SysNotification`, `TaskDefinition`, `TaskTrigger`, `WFDefItem`, `WFProcessRole`, `WFTransition`, `WFTransitionDefinition`, `WfTaskSource` |
