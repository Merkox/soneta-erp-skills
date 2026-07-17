# Pola i właściwości klasy biznesowej: `Soneta.Core.Schedule.JobInvokeLogDetail`
Nazwa tabeli: `JobInvokeLogDets`
Tytuł: Szczegółowe logi prac
Opis: Szczegółowy wpis logu wykonania zadania harmonogramu. Zawiera treść komunikatu, daty utworzenia i ostatniego wpisu, nazwę operatora, stos błędu, informacje o instancji harmonogramu (port, usługa, priorytet).
Tabela konfiguracyjna: Nie

- pola bazodanowe: 10
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CreationDateTime | `System.DateTime` | bazodanowe | Data utworzenia | Określa datę utworzenia |
| HzInstance | `Soneta.Business.MemoText` | bazodanowe | Nazwa instancji harmonogramu | Określa nazwę instancji harmonogramu |
| IsService | `bool` | bazodanowe | Usługa | Określa czy HZ jest uruchomiony jako usługa |
| JobInvokeLog | `Soneta.Core.Schedule.JobInvokeLog` | bazodanowe | Referencja do tabeli JobInvokeLog | Określa referencję do tabeli JobInvokeLog |
| LastEntryDateTime | `System.DateTime` | bazodanowe | Data ostatniego wpisu | Określa datę ostatniego wpisu |
| Message | `Soneta.Business.MemoText` | bazodanowe | Informacja | Określa dodatkową informację o danym zadaniu |
| OperatorName | `Soneta.Business.MemoText` | bazodanowe | Nazwa operatora | Określa nazwę operatora |
| PortNumber | `Soneta.Business.MemoText` | bazodanowe | Numer portu | Określa numer portu HZ |
| Priority | `Soneta.Business.MemoText` | bazodanowe | Priorytet | Określa priorytet |
| StackTrace | `Soneta.Business.MemoText` | bazodanowe | Stos błędu | Określa stos błędu |
