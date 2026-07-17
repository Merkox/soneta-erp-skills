# Pola i właściwości klasy biznesowej: `Soneta.Zadania.PriorytetZadania`
Nazwa tabeli: `PriorytetyZadan`
Tytuł: Priorytety zadań CRM
Opis: Element szczegółowy definicji zadania (DefZadania). Definiuje priorytet (wagę) zadania CRM, np. niski, normalny, wysoki, używany do sortowania i filtrowania zadań.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Zablokowany | Określa zablokowanie stanu. Zablokowane stany dokumentów nie będą wyświetlane w liście wyboru. |
| Definicja | `Soneta.Zadania.DefZadania` | bazodanowe |  | Definicja zadania, do której jest przypisana waga |
| Ident | `int` | bazodanowe | Identyfikator | Identyfikator priorytetu na definicji zadania. Wykorzystywany w relacji do zadania. |
| Kod | `string` |  |  |  |
| Kolor | `string` | bazodanowe | Kolor | Kolor dla priorytetu |
| Lp | `int` | bazodanowe | Lp | Liczba porządkowa priorytetu w ramach zadania. |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa priorytetu zadania |
