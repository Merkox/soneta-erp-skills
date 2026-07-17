# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Config.WfPlugInReference`
Nazwa tabeli: `WfPlugInsRef`
Tytuł: Powiązania wtyczek definicji procesów
Opis: Element szczegółowy hosta wtyczek (IWfPlugInReferenceHost). Powiązanie między definicją procesu workflow a wtyczką (WfPlugIn), umożliwiające dołączenie rozszerzeń do procesu. Flaga Managed wskazuje, czy powiązanie jest zarządzane automatycznie.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Definition` → `IWfPlugInReferenceHost`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definition | `Soneta.Business.IWfPlugInReferenceHost` | bazodanowe, guided-parent, iface-ref | Wtyczka dla |  |
| Managed | `bool` | bazodanowe |  |  |
| PlugIn | `Soneta.Workflow.Config.WfPlugIn` | bazodanowe |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Definition | `IWfPlugInReferenceHost` | `DbTupleDefinition`, `DefLeada`, `DefProjektu`, `DefTransakcja`, `DefZadania`, `WFDefinition` |
