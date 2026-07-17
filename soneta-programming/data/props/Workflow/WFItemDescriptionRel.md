# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Config.WFItemDescriptionRel`
Nazwa tabeli: `WFItemDescRels`
Tytuł: Komentarze do elementów workflow
Opis: Tabela relacyjna łącząca komentarze (WFItemDescription) z elementami procesu workflow poprzez interfejs IWorkflowItemDescriptionHost. Umożliwia przypisanie wielu komentarzy do jednego elementu oraz współdzielenie komentarzy między elementami.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Description` → `IWFItemDescription`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Description | `Soneta.Business.IWFItemDescription` | bazodanowe, guided-parent | Komentarz powiązany | Komentarz powiązany z elementem |
| From | `Soneta.Business.UI.Diagram.IConnectableNode` |  |  |  |
| FromPoint | `System.Drawing.PointF` |  |  |  |
| Host | `Soneta.Business.IWorkflowItemDescriptionHost` | bazodanowe, iface-ref | Element powiązany | Element powiązany z komentarzem |
| Identifier | `System.Guid` | bazodanowe | Identyfikator wiersza | Określa identyfikator wiersza |
| LinePoints | `System.Drawing.PointF[]` |  |  |  |
| Location | `System.Drawing.PointF` |  |  |  |
| SourceNodePort | `int` |  |  |  |
| TargetNodePort | `int` |  |  |  |
| To | `Soneta.Business.UI.Diagram.IConnectableNode` |  |  |  |
| ToPoint | `System.Drawing.PointF` |  |  |  |
| WFDefinition | `Soneta.Workflow.Config.WFDefinition` | bazodanowe | Definicja procesu | Definicja procesu |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IWorkflowItemDescriptionHost` | `OGSchema`, `TaskDefinition` |
