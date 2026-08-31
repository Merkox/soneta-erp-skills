# Pola i właściwości klasy biznesowej: `Soneta.Core.RecordSequence`
Nazwa tabeli: `RecordSequences`
Tytuł: Kolejność rekordów
Opis: Tabela przechowująca niestandardową kolejność rekordów ustawioną przez użytkownika (drag and drop). Zawiera powiązanie z wykonującym, źródłem danych, zakresem i numerem sekwencji.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataSource | `IRowSequencer` | bazodanowe |  |  |
| DataSourceParent | `int` | bazodanowe |  |  |
| Performer | `IWykonujacy` | bazodanowe |  |  |
| Scope | `string` | bazodanowe |  |  |
| Sequence | `int` | bazodanowe |  |  |
