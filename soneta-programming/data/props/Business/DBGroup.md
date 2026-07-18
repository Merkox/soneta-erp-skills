# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.DBGroup`
Nazwa tabeli: `DBGroups`
Tytuł: Grupy baz danych
Opis: Grupa baz danych klientów biura rachunkowego. Umożliwia organizowanie baz danych klientów w nazwane grupy dla celów zarządzania.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DBGroupItems | `SubTable<Db.DBGroupItem>` | podlista |  |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa grupy baz danych |
