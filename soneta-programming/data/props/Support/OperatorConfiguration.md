# Pola i właściwości klasy biznesowej: `Soneta.Support.Support.OperatorConfiguration`
Nazwa tabeli: `OperatorsConfig`
Tytuł: Operator
Opis: Konfiguracja operatora w module wsparcia technicznego. Przechowuje adres email operatora wykorzystywany do wysyłania powiadomień o zgłoszeniach serwisowych i zmianach ich statusów.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Email | `string` | bazodanowe |  |  |
| Operator | `Soneta.Business.App.Operator` | bazodanowe |  |  |
