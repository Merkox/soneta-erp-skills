# Pola i właściwości klasy biznesowej: `Soneta.Core.Schedule.JobInvokeLog`
Nazwa tabeli: `JobInvokeLogs`
Tytuł: Logi prac
Opis: Log wykonania zadania harmonogramu. Rejestruje identyfikator elementu harmonogramu, GUID zadania, czas rozpoczęcia i zakończenia, informacje o definicji harmonogramu oraz dodatkowe dane o przebiegu zadania.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| EndDate | `Date` | tylko-odczyt | Data zakończenia logu | Określa datę zakończenia logu |
| EndDateTime | `System.DateTime` | bazodanowe | Czas zakończenia | Określa czas zakończenia |
| EndTime | `TimeSec` | tylko-odczyt | Czas zakończenia logu | Określa czas zakończenia logu |
| HasDefinition | `bool` | tylko-odczyt | Czy określono definicję harmonogramu |  |
| Host | `GuidedRow` | tylko-odczyt | Wiersz na podstawie HostGuid | Pobiera dane wiersza na podstawie HostGuid |
| HostGuid | `System.Guid` | bazodanowe | Guid wiersza powiązanego | Określa guid wiersza powiązanego |
| HostTable | `string` | bazodanowe | Tabela wiersza powiązanego | Określa tabelę wiersza powiązanego |
| Parent | `IGuidedRow` | tylko-odczyt | Wiersz dla zadania | Pobiera dane wiersza dla zadania |
| ParentTable | `string` | tylko-odczyt | Nazwa tabeli dla wiersza | Pobiera nazwę tabeli dla wiersza |
| ScheduleDefinition | `Soneta.Core.Schedule.ScheduleDefinition` | tylko-odczyt | Wiersz na podstawie ScheduleDefGuid | Pobiera dane definicji harmonogramu na podstawie ScheduleDefGuid |
| ScheduleDefinitionGuid | `System.Guid` | bazodanowe | Guid definicji harmonogramu | Określa guid definicji harmonogramu |
| ScheduleDefinitionName | `string` | bazodanowe | Nazwa definicji harmonogramu | Określa nazwę definicji harmonogramu |
| ScheduleItem | `Soneta.Core.Schedule.ScheduleItem` | tylko-odczyt | Element harmonogramu na podstawie ScheduleItemIdGuid | Pobiera dane elementu harmonogramu na podstawie ScheduleItemIdGuid |
| ScheduleItemIdGuid | `System.Guid` | bazodanowe, tylko-odczyt | Identyfikator elementu harmonogramu | Określa identyfikator elementu harmonogramu |
| StartDate | `Date` | tylko-odczyt | Data rozpoczęcia logu | Określa datę rozpoczęcia logu |
| StartDateTime | `System.DateTime` | bazodanowe | Czas rozpoczęcia | Określa czas rozpoczęcia |
| StartTime | `TimeSec` | tylko-odczyt | Czas rozpoczęcia logu | Określa czas rozpoczęcia logu |
| Task | `Db.Task` | tylko-odczyt | Zadanie na podstawie TaskGuid | Pobiera dane zadania na podstawie TaskGuid |
| TaskGuid | `System.Guid` | bazodanowe | Guid wiersza zadania | Określa guid wiersza zadania |
| TaskParentGuid | `System.Guid` | bazodanowe | Guid wiersza powiązanego | Określa guid wiersza powiązanego |
| TaskParentTable | `string` | bazodanowe | Nazwa tabeli wiersza powiązanego | Określa nazwę tabeli wiersza powiązanego |
| Value | `MemoText` | bazodanowe, podlista | Informacja | Określa dodatkową informację o danym zadaniu |
