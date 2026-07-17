# Pola i właściwości klasy biznesowej: `Soneta.Zadania.TypZadania`
Nazwa tabeli: `TypyZadan`
Tytuł: Typy zadan
Opis: Element szczegółowy definicji zadania (DefZadania). Klasyfikuje rodzaj aktywności w ramach definicji zadania CRM, np. spotkanie, telefon, praca twórcza.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Definicja` → `DefZadania`

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Zablokowany | Określa zablokowanie typu. Zablokowane typy dokumentów nie będą wyświetlane w liście wyboru. |
| Definicja | `Soneta.Zadania.DefZadania` | bazodanowe, guided-parent |  | Definicja zadania, do której jest przypisany ten typ |
| Ident | `int` | bazodanowe | Identyfikator | Identyfikator typu na definicji zadania. Wykorzystywany w relacji do zadania. |
| Kod | `string` |  |  |  |
| Lp | `int` | bazodanowe | Lp | Liczba porządkowa typu realizacji w ramach zadania. |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa typu aktywności zadania |
| PracaTworcza | `bool` | bazodanowe | Praca twórcza | Wskazuje czy dany typ zadania jest określany jako praca twórcza. |
