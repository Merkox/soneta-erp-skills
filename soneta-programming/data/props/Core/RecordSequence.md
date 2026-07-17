# Pola i właściwości klasy biznesowej: `Soneta.Core.RecordSequence`
Nazwa tabeli: `RecordSequences`
Tytuł: Kolejność rekordów
Opis: Tabela przechowująca niestandardową kolejność rekordów ustawioną przez użytkownika (drag and drop). Zawiera powiązanie z wykonującym, źródłem danych, zakresem i numerem sekwencji.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataSource | `Soneta.Business.IRowSequencer` | bazodanowe |  |  |
| DataSourceParent | `int` | bazodanowe |  |  |
| Performer | `Soneta.Business.IWykonujacy` | bazodanowe |  |  |
| Scope | `string` | bazodanowe |  |  |
| Sequence | `int` | bazodanowe |  |  |
