# Pola i właściwości klasy biznesowej: `Soneta.Support.Support.OperatorConfiguration`
Nazwa tabeli: `OperatorsConfig`
Tytuł: Operator
Opis: Konfiguracja operatora w module wsparcia technicznego. Przechowuje adres email operatora wykorzystywany do wysyłania powiadomień o zgłoszeniach serwisowych i zmianach ich statusów.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Email | `string` | bazodanowe |  |  |
| Operator | `App.Operator` | bazodanowe |  |  |
