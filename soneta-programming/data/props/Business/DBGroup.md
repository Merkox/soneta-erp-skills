# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.DBGroup`
Nazwa tabeli: `DBGroups`
Tytuł: Grupy baz danych
Opis: Grupa baz danych klientów biura rachunkowego. Umożliwia organizowanie baz danych klientów w nazwane grupy dla celów zarządzania.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 1
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DBGroupItems | `Soneta.Business.SubTable<Soneta.Business.Db.DBGroupItem>` |  |  |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa grupy baz danych |
