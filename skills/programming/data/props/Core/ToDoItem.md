# Pola i właściwości klasy biznesowej: `Soneta.Core.ToDoItem`
Nazwa tabeli: `ToDoItems`
Tytuł: Elementy do wykonania
Opis: Lista zadań do wykonania (to-do) powiązana z obiektem biznesowym. Każdy element posiada numer porządkowy, temat i flagę wykonania. Służy do śledzenia prostych czynności w kontekście dokumentu lub procesu.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Completed | `bool` | bazodanowe | Wykonany |  |
| Host | `IToDoItemHost` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| Lp | `int` | bazodanowe |  |  |
| Subject | `string` | bazodanowe | Temat |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IToDoItemHost` | `Zadanie` |
