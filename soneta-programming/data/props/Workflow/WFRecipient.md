# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Config.WFRecipient`
Nazwa tabeli: `WFRecipients`
Tytuł: Odbiorcy kroku workflow
Opis: Element szczegółowy hosta odbiorców (IWFRecipientHost). Definiuje osobę lub rolę odpowiedzialną za wykonanie konkretnego kroku w procesie workflow. Umożliwia przypisanie użytkowników zadań do poszczególnych etapów procesu.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Host` → `IWFRecipientHost`

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Host | `Soneta.Business.IWFRecipientHost` | bazodanowe, guided-parent, iface-ref | Host | Host powiązany z odbiorcą kroku workflow |
| TaskUser | `Soneta.Business.ITaskUser` | bazodanowe, iface-ref | Odbiorca zadania | Odbiorca zadania powiązany z krokiem workflow |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IWFRecipientHost` | `SysNotification`, `TaskDefinition`, `WFProcessRole`, `WfPlugInItemReference` |
| TaskUser | `ITaskUser` | `KontaktOsoba`, `Operator`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego`, `WykladowcaSzkol` |
