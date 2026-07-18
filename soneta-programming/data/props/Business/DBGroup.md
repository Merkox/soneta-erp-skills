# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.DBGroup`
Nazwa tabeli: `DBGroups`
Tytuł: Grupy baz danych
Opis: Grupa baz danych klientów biura rachunkowego. Umożliwia organizowanie baz danych klientów w nazwane grupy dla celów zarządzania.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 1
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DBGroupItems | `SubTable<Db.DBGroupItem>` | podlista |  |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa grupy baz danych |
