# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.TaskHistoryRel`
Nazwa tabeli: `TaskHistoryRels`
Tytuł: Historie zadań
Opis: Relacja historii przepływu zadań w procesie workflow. ŝączy zadanie źródłowe z docelowym przez tranzycję, tworząc ścieżkę przebiegu procesu.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 4
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| First | `bool` | bazodanowe, tylko-odczyt | Utworzenie zadania | Określa czy jest to tranzycja która utworzyła taska. |
| Source | `Db.Task` | bazodanowe, tylko-odczyt | Zadanie źródłowe | Określa zadanie źródłowe z którego powstał task. |
| Target | `Db.Task` | bazodanowe, tylko-odczyt | Zadanie docelowe | Określa zadanie docelowe do którego przeszedł task. |
| WfTransition | `IWFTransition` | bazodanowe, tylko-odczyt, iface-ref | Tranzycja | Określa tranzycję, którą został utworzony task. |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| WfTransition | `IWFTransition` | `WFTransition` |
