# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Cti.Models.CtiCallTransferLog`
Nazwa tabeli: `CallTransferLogs`
Opis: Tabela przechowująca logi z przekierowań połączeń między numerami wewnętrznymi. Zawiera szczegółowe dane o połączeniach, takie jak numery wewnętrzne, operatorzy oraz czas wykonania przekierowania.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CR | `int` | bazodanowe |  |  |
| CreatedAt | `System.DateTime` | bazodanowe |  |  |
| OperatorNumber | `string` | bazodanowe |  |  |
| OriginalCallingNumber | `string` | bazodanowe |  |  |
