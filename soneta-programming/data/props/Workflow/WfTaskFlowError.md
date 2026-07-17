# Pola i właściwości klasy biznesowej: `Soneta.Workflow.WfTaskFlowError`
Nazwa tabeli: `WfTaskFlowErrors`
Tytuł: Błędy przeliczania zadań
Opis: Element szczegółowy zadania (Task). Rejestruje błędy powstałe podczas przeliczania lub realizacji zadania workflow, przechowując nazwę błędu, komunikat, stos wywołań oraz datę zgłoszenia i rozwiązania. Służy do diagnostyki i monitorowania przebiegu procesów.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Task` → `Task`

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CallStack | `Soneta.Business.MemoText` | bazodanowe |  |  |
| IsResolved | `bool` |  |  |  |
| Message | `string` | bazodanowe |  |  |
| Name | `string` | bazodanowe |  |  |
| Registered | `System.DateTime` | bazodanowe |  |  |
| RegisteredInfo | `string` |  |  |  |
| Resolved | `System.DateTime` | bazodanowe |  |  |
| ResolvedInfo | `string` |  |  |  |
| Task | `Soneta.Business.Db.Task` | bazodanowe, guided-parent |  |  |
| TaskUser | `Soneta.Business.ITaskUser` | bazodanowe, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| TaskUser | `ITaskUser` | `KontaktOsoba`, `Operator`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego`, `WykladowcaSzkol` |
