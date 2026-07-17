# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Budzetowanie.DefZadaniaRelacja`
Nazwa tabeli: `DefZadanRelacje`
Tytuł: Relacje definicji zadań
Opis: Tabela konfiguracyjna przechowująca relacje hierarchiczne między definicjami zadań CRM. Definiuje powiązania nadrzędna-podrzędna między definicjami, umożliwiając budowanie drzewiastej struktury kategorii zadań.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Nadrzedna | `Soneta.Zadania.DefZadania` | bazodanowe | Nadrzędna definicja zadania |  |
| Podrzedna | `Soneta.Zadania.DefZadania` | bazodanowe | Podrzędna definicja zadania |  |
