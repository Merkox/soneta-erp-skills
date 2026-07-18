# Pola i właściwości klasy biznesowej: `Soneta.Core.Schedule.JobInvokeLogDetail`
Nazwa tabeli: `JobInvokeLogDets`
Tytuł: Szczegółowe logi prac
Opis: Szczegółowy wpis logu wykonania zadania harmonogramu. Zawiera treść komunikatu, daty utworzenia i ostatniego wpisu, nazwę operatora, stos błędu, informacje o instancji harmonogramu (port, usługa, priorytet).
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 4
- podlisty: 6
- subrowy: 0
- razem: 10

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CreationDateTime | `System.DateTime` | bazodanowe, tylko-odczyt | Data utworzenia | Określa datę utworzenia |
| HzInstance | `MemoText` | bazodanowe, podlista | Nazwa instancji harmonogramu | Określa nazwę instancji harmonogramu |
| IsService | `bool` | bazodanowe, tylko-odczyt | Usługa | Określa czy HZ jest uruchomiony jako usługa |
| JobInvokeLog | `Soneta.Core.Schedule.JobInvokeLog` | bazodanowe, tylko-odczyt | Referencja do tabeli JobInvokeLog | Określa referencję do tabeli JobInvokeLog |
| LastEntryDateTime | `System.DateTime` | bazodanowe, tylko-odczyt | Data ostatniego wpisu | Określa datę ostatniego wpisu |
| Message | `MemoText` | bazodanowe, podlista | Informacja | Określa dodatkową informację o danym zadaniu |
| OperatorName | `MemoText` | bazodanowe, podlista | Nazwa operatora | Określa nazwę operatora |
| PortNumber | `MemoText` | bazodanowe, podlista | Numer portu | Określa numer portu HZ |
| Priority | `MemoText` | bazodanowe, podlista | Priorytet | Określa priorytet |
| StackTrace | `MemoText` | bazodanowe, podlista | Stos błędu | Określa stos błędu |
