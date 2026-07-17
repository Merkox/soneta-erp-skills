# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.TaskHistoryRel`
Nazwa tabeli: `TaskHistoryRels`
Tytuł: Historie zadań
Opis: Relacja historii przepływu zadań w procesie workflow. ŝączy zadanie źródłowe z docelowym przez tranzycję, tworząc ścieżkę przebiegu procesu.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| First | `bool` | bazodanowe | Utworzenie zadania | Określa czy jest to tranzycja która utworzyła taska. |
| Source | `Soneta.Business.Db.Task` | bazodanowe | Zadanie źródłowe | Określa zadanie źródłowe z którego powstał task. |
| Target | `Soneta.Business.Db.Task` | bazodanowe | Zadanie docelowe | Określa zadanie docelowe do którego przeszedł task. |
| WfTransition | `Soneta.Business.IWFTransition` | bazodanowe, iface-ref | Tranzycja | Określa tranzycję, którą został utworzony task. |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| WfTransition | `IWFTransition` | `WFTransition` |
