# Pola i właściwości klasy biznesowej: `Soneta.CRM.PodpisOperatora`
Nazwa tabeli: `PodpisyOper`
Tytuł: Podpisy operatorów
Opis: Podpis operatora dołączany automatycznie do wysyłanych wiadomości e-mail. Umożliwia każdemu operatorowi zdefiniowanie indywidualnej stopki z danymi kontaktowymi i informacjami firmowymi.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Operator | `App.Operator` | bazodanowe |  |  |
| Podpis | `MemoText` | bazodanowe, podlista |  |  |
