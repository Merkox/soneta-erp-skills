# Pola i właściwości klasy biznesowej: `Soneta.Core.Schedule.JobInvokeLog`
Nazwa tabeli: `JobInvokeLogs`
Tytuł: Logi prac
Opis: Log wykonania zadania harmonogramu. Rejestruje identyfikator elementu harmonogramu, GUID zadania, czas rozpoczęcia i zakończenia, informacje o definicji harmonogramu oraz dodatkowe dane o przebiegu zadania.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 11
- pola kalkulowane (z klas biznesowych): 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| EndDate | `Soneta.Types.Date` |  | Data zakończenia logu | Określa datę zakończenia logu |
| EndDateTime | `System.DateTime` | bazodanowe | Czas zakończenia | Określa czas zakończenia |
| EndTime | `Soneta.Types.TimeSec` |  | Czas zakończenia logu | Określa czas zakończenia logu |
| HasDefinition | `bool` |  | Czy określono definicję harmonogramu |  |
| Host | `Soneta.Business.GuidedRow` |  | Wiersz na podstawie HostGuid | Pobiera dane wiersza na podstawie HostGuid |
| HostGuid | `System.Guid` | bazodanowe | Guid wiersza powiązanego | Określa guid wiersza powiązanego |
| HostTable | `string` | bazodanowe | Tabela wiersza powiązanego | Określa tabelę wiersza powiązanego |
| Parent | `Soneta.Business.IGuidedRow` |  | Wiersz dla zadania | Pobiera dane wiersza dla zadania |
| ParentTable | `string` |  | Nazwa tabeli dla wiersza | Pobiera nazwę tabeli dla wiersza |
| ScheduleDefinition | `Soneta.Core.Schedule.ScheduleDefinition` |  | Wiersz na podstawie ScheduleDefGuid | Pobiera dane definicji harmonogramu na podstawie ScheduleDefGuid |
| ScheduleDefinitionGuid | `System.Guid` | bazodanowe | Guid definicji harmonogramu | Określa guid definicji harmonogramu |
| ScheduleDefinitionName | `string` | bazodanowe | Nazwa definicji harmonogramu | Określa nazwę definicji harmonogramu |
| ScheduleItem | `Soneta.Core.Schedule.ScheduleItem` |  | Element harmonogramu na podstawie ScheduleItemIdGuid | Pobiera dane elementu harmonogramu na podstawie ScheduleItemIdGuid |
| ScheduleItemIdGuid | `System.Guid` | bazodanowe | Identyfikator elementu harmonogramu | Określa identyfikator elementu harmonogramu |
| StartDate | `Soneta.Types.Date` |  | Data rozpoczęcia logu | Określa datę rozpoczęcia logu |
| StartDateTime | `System.DateTime` | bazodanowe | Czas rozpoczęcia | Określa czas rozpoczęcia |
| StartTime | `Soneta.Types.TimeSec` |  | Czas rozpoczęcia logu | Określa czas rozpoczęcia logu |
| Task | `Soneta.Business.Db.Task` |  | Zadanie na podstawie TaskGuid | Pobiera dane zadania na podstawie TaskGuid |
| TaskGuid | `System.Guid` | bazodanowe | Guid wiersza zadania | Określa guid wiersza zadania |
| TaskParentGuid | `System.Guid` | bazodanowe | Guid wiersza powiązanego | Określa guid wiersza powiązanego |
| TaskParentTable | `string` | bazodanowe | Nazwa tabeli wiersza powiązanego | Określa nazwę tabeli wiersza powiązanego |
| Value | `Soneta.Business.MemoText` | bazodanowe | Informacja | Określa dodatkową informację o danym zadaniu |
