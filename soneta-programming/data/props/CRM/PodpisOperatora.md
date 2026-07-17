# Pola i właściwości klasy biznesowej: `Soneta.CRM.PodpisOperatora`
Nazwa tabeli: `PodpisyOper`
Tytuł: Podpisy operatorów
Opis: Podpis operatora dołączany automatycznie do wysyłanych wiadomości e-mail. Umożliwia każdemu operatorowi zdefiniowanie indywidualnej stopki z danymi kontaktowymi i informacjami firmowymi.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Operator | `Soneta.Business.App.Operator` | bazodanowe |  |  |
| Podpis | `Soneta.Business.MemoText` | bazodanowe |  |  |
