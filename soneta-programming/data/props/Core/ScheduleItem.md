# Pola i właściwości klasy biznesowej: `Soneta.Core.Schedule.ScheduleItem`
Nazwa tabeli: `ScheduleItems`
Tytuł: Elementy harmonogramów
Opis: Pojedynczy element (instancja wykonania) harmonogramu. Powiązany z definicją harmonogramu i zadaniem, zawiera identyfikator wiersza, czas wykonania, opcjonalny rekord powiązany oraz czas wystąpienia wyjątku.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definition | `Soneta.Business.IScheduleDefinition` |  |  |  |
| ExceptionTimeStamp | `System.DateTime` | bazodanowe | Czas wystąpienia wyjątku | Określa czas wystąpienia wyjątku dla przetwarzanego elementu harmonogramu |
| Host | `Soneta.Business.IScheduleAutoJob` | bazodanowe | Rekord | Określa opcjonalny rekord powiązany |
| HostGuid | `System.Guid?` |  |  |  |
| HostTable | `string` |  |  |  |
| IdGuid | `System.Guid` | bazodanowe | Identyfikator wiersza | Określa identyfikator wiersza |
| InvokeTime | `System.DateTime` | bazodanowe | Czas wykonania zadania | Określa czas wykonania zadania |
| ParentGuid | `System.Guid?` |  |  |  |
| ParentTable | `string` |  |  |  |
| ScheduleDefinition | `Soneta.Core.Schedule.ScheduleDefinition` | bazodanowe | Definicja harmonogramu | Definicja harmonogramu powiązana z elementem harmonogramu |
| Task | `Soneta.Business.Db.Task` | bazodanowe | Zadanie | Zadanie powiązana z elementem harmonogramu |
| TaskGuid | `System.Guid?` |  |  |  |
