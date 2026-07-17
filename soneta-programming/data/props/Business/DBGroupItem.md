# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.DBGroupItem`
Nazwa tabeli: `DBGroupItems`
Tytuł: Pozycje grupy bazy danych
Opis: Przypisanie bazy danych klienta do grupy. Tworzy relację wiele-do-wielu między bazami danych a grupami.
Tabela konfiguracyjna: Tak

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DBGroup | `Soneta.Business.Db.DBGroup` | bazodanowe | Grupa bazy danych | Grupa bazy danych |
| DBItem | `Soneta.Business.Db.DBItem` | bazodanowe | Baza danych | Bazy danych |
