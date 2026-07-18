# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Config.WfPlugInReference`
Nazwa tabeli: `WfPlugInsRef`
Tytuł: Powiązania wtyczek definicji procesów
Opis: Element szczegółowy hosta wtyczek (IWfPlugInReferenceHost). Powiązanie między definicją procesu workflow a wtyczką (WfPlugIn), umożliwiające dołączenie rozszerzeń do procesu. Flaga Managed wskazuje, czy powiązanie jest zarządzane automatycznie.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Definition` → `IWfPlugInReferenceHost`

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 3
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definition | `IWfPlugInReferenceHost` | bazodanowe, tylko-odczyt, guided-parent, iface-ref | Wtyczka dla |  |
| Managed | `bool` | bazodanowe, tylko-odczyt |  |  |
| PlugIn | `Soneta.Workflow.Config.WfPlugIn` | bazodanowe, tylko-odczyt |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Definition | `IWfPlugInReferenceHost` | `DbTupleDefinition`, `DefLeada`, `DefProjektu`, `DefTransakcja`, `DefZadania`, `WFDefinition` |
