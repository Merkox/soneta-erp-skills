# Pola i właściwości klasy biznesowej: `Soneta.Workflow.WfTaskFlowError`
Nazwa tabeli: `WfTaskFlowErrors`
Tytuł: Błędy przeliczania zadań
Opis: Element szczegółowy zadania (Task). Rejestruje błędy powstałe podczas przeliczania lub realizacji zadania workflow, przechowując nazwę błędu, komunikat, stos wywołań oraz datę zgłoszenia i rozwiązania. Służy do diagnostyki i monitorowania przebiegu procesów.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Task` → `Task`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CallStack | `MemoText` | bazodanowe, podlista |  |  |
| IsResolved | `bool` | tylko-odczyt |  |  |
| Message | `string` | bazodanowe, tylko-odczyt |  |  |
| Name | `string` | bazodanowe, tylko-odczyt |  |  |
| Registered | `System.DateTime` | bazodanowe, tylko-odczyt |  |  |
| RegisteredInfo | `string` | tylko-odczyt |  |  |
| Resolved | `System.DateTime` | bazodanowe, tylko-odczyt |  |  |
| ResolvedInfo | `string` | tylko-odczyt |  |  |
| Task | `Db.Task` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| TaskUser | `ITaskUser` | bazodanowe, tylko-odczyt, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| TaskUser | `ITaskUser` | `KontaktOsoba`, `Operator`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego`, `WykladowcaSzkol` |
