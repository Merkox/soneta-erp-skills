# Pola i właściwości klasy biznesowej: `Soneta.Core.Schedule.ScheduleItem`
Nazwa tabeli: `ScheduleItems`
Tytuł: Elementy harmonogramów
Opis: Pojedynczy element (instancja wykonania) harmonogramu. Powiązany z definicją harmonogramu i zadaniem, zawiera identyfikator wiersza, czas wykonania, opcjonalny rekord powiązany oraz czas wystąpienia wyjątku.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 11
- podlisty: 0
- subrowy: 0
- razem: 12

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definition | `IScheduleDefinition` | tylko-odczyt |  |  |
| ExceptionTimeStamp | `System.DateTime` | bazodanowe, tylko-odczyt | Czas wystąpienia wyjątku | Określa czas wystąpienia wyjątku dla przetwarzanego elementu harmonogramu |
| Host | `IScheduleAutoJob` | bazodanowe, tylko-odczyt | Rekord | Określa opcjonalny rekord powiązany |
| HostGuid | `System.Guid?` | tylko-odczyt |  |  |
| HostTable | `string` | tylko-odczyt |  |  |
| IdGuid | `System.Guid` | bazodanowe, tylko-odczyt | Identyfikator wiersza | Określa identyfikator wiersza |
| InvokeTime | `System.DateTime` | bazodanowe | Czas wykonania zadania | Określa czas wykonania zadania |
| ParentGuid | `System.Guid?` | tylko-odczyt |  |  |
| ParentTable | `string` | tylko-odczyt |  |  |
| ScheduleDefinition | `Soneta.Core.Schedule.ScheduleDefinition` | bazodanowe, tylko-odczyt | Definicja harmonogramu | Definicja harmonogramu powiązana z elementem harmonogramu |
| Task | `Db.Task` | bazodanowe, tylko-odczyt | Zadanie | Zadanie powiązana z elementem harmonogramu |
| TaskGuid | `System.Guid?` | tylko-odczyt |  |  |
